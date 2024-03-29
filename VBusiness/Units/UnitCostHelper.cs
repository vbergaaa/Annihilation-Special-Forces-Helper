﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VBusiness.Loadouts;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class UnitCostHelper
	{
		private readonly VLoadout loadout;

		public UnitCostHelper(VLoadout loadout)
		{
			this.loadout = loadout;
			ResetCalculationVariables();
		}

		UnitCost GetRawUnitCost(UnitRecepePiece piece)
		{
			return GetRawUnitCost(piece.Unit, piece.Infuse, piece.Rank, false);
		}

		public UnitCost GetUnitCost(VUnit unit)
		{
			return GetUnitCost(new VUnit[] { unit });
		}

		public UnitCost GetUnitCost(IEnumerable<VUnit> units)
		{
			ResetCalculationVariables();
			var cost = new UnitCost();
			foreach (var unit in units)
			{
				cost += GetUnitCost(unit.UnitData.Type, unit.CurrentInfusion, unit.UnitRank, unit.IsLimitBroken);
			}
			return cost;
		}

		public UnitCost GetUnitCost(UnitType unitType, int infuse, UnitRankType rank, bool isLimitBroken = false)
		{
			if (unitType != UnitType.None)
			{
				return GetRawUnitCost(unitType, infuse, rank, isLimitBroken);
			}
			return new UnitCost(0, 0);
		}

		UnitCost GetRawUnitCost(UnitType unitType, int infuse, UnitRankType rank, bool isLimitBroken)
		{
			var unitData = VUnit.GetUnitData(unitType);

			// theres some horrible spaghetti with the logic for adding two UnitCost structs because we don't want to sum the ExcessKills.
			// It takes the Excess Kills from the element on the right side of the '+' operator.
			// Please ensure you leave these cost additions in this order to avoid breaking this accidently
			var cost = GetRankCost(rank);
			cost += GetBaseCreationCost(unitData, isLimitBroken);
			cost += GetInfusionCosts(unitData, infuse, cost.CurrentUnitKills);
			return cost;
		}

		UnitCost GetRankCost(UnitRankType rank)
		{
			var rankCost = UnitRankUpHelper.GetRankCost(rank, loadout.IncomeManager.RankRevision, loadout.IncomeManager.HasRefundSoul);

			if (hasRSSS && rank >= UnitRankType.SSS)
			{
				hasRSSS = false;
				rankCost -= UnitRankUpHelper.GetRankCost(UnitRankType.SSS, loadout.IncomeManager.RankRevision, loadout.IncomeManager.HasRefundSoul);
			}
			else if (hasRSS && rank >= UnitRankType.SS)
			{
				hasRSS = false;
				rankCost -= UnitRankUpHelper.GetRankCost(UnitRankType.SS, loadout.IncomeManager.RankRevision, loadout.IncomeManager.HasRefundSoul);
			}
			return new UnitCost(0, rankCost);
		}

		UnitCost GetInfusionCosts(IUnitData unitData, int infusion, int excessKills)
		{
#if DEBUG
			RecordDNAStartUnit(unitData, infusion);
#endif
			if (infusion < 11)
			{
				if (infusion == 0)
				{
					return new UnitCost(0, 0, excessKills);
				}

				var infuseDiscount = 0;
				if (unitData.Type.IsCoreBasic() && infusion >= 3 && TryUseQSCharge())
				{
					infuseDiscount = 3;
				}

				if (unitData.Type.IsDNA1() && infusion >= loadout.Perks.DNAStart.DesiredLevel && TryUseDNAStart())
				{
					infuseDiscount = loadout.Perks.DNAStart.DesiredLevel;
				}
				else if (shouldGrantDNAFreeInf1 && unitData.Type.IsDNA1())
				{
					infuseDiscount = 1;
				}

				var material = new UnitRecepePiece(unitData.BasicType, (int)unitData.Evolution, UnitRankType.None, 1);
				var materialCost = GetRawUnitCost(material);
				var (Cost, ExcessKills) = GetFeedCost(infusion, unitData.Type, excessKills, infuseDiscount);
				var materialQty = UnitsRequiredForInfuse(infusion, infuseDiscount);
				var killRecycleRefund = GetKillRecycleRefund(materialCost, infusion, infuseDiscount, materialQty);
				var infuseRecycleRefund = GetInfuseRecycleRefund(infusion, infuseDiscount);
				var totalKillCost = materialCost.Kills * materialQty + Cost - infuseRecycleRefund - killRecycleRefund;
				return new UnitCost(materialCost.Minerals * materialQty, totalKillCost, ExcessKills);
			}
			else
			{
				return GetOverInfusionCosts(unitData, infusion, excessKills);
			}
		}

		UnitCost GetOverInfusionCosts(IUnitData unitData, int infusion, int excessKills)
		{
			// over infuse logic. Because this is annoyingly complex, it gets comments

			// We use recursion to get the cost of the previous infuse, then add on our current infusion
			var previousInfCost = GetInfusionCosts(unitData, infusion - 1, excessKills);
			var material = new UnitRecepePiece(unitData.BasicType, 10, UnitRankType.None, 1);

			// Get the material count - this may not be correct, I only tested inf10->11, which was 11 units
			var materialQty = infusion;


			// check see if any qs charges will be involved in the cost of the infuse materials
			UnitCost qsMaterialCost = default;
			var remainingQsCharges = qsCharges;
			if (remainingQsCharges > 0)
			{
				// cost of the infuse feed if we have a qs charge
				qsMaterialCost = GetRawUnitCost(material);

				// as we need 10+ mats, we are going to exhaust our QS charges
				// at this stage it isn't possible to have more than 10 QS charges
				qsCharges = 0;
			}

			// get the cost of our unit without any qs charges
			var fullMaterialCost = GetRawUnitCost(material);

			// cost of feed, e.g, 3000 for inf 11, 4000 for inf 12;
			var mainUnitFeedCost = 2000 + (infusion - 10) * 1000;

			// at this stage it seems unrealistic we will get more than 11,000 vet, so it's unlikely there will be any kills on our materials.
			var killRecycleRefund = 0;

			// as we use recursion for each infuse, we should only get the bonus of one here
			var infuseRecycleRefund = GetInfuseRecycleRefund(1);

			// finally we can total it all together
			var materialKills = fullMaterialCost.Kills * (materialQty - remainingQsCharges) + qsMaterialCost.Kills * remainingQsCharges;
			var materialMinerals = fullMaterialCost.Minerals * (materialQty - remainingQsCharges) + qsMaterialCost.Minerals * remainingQsCharges;
			var totalKillCost = materialKills + mainUnitFeedCost - infuseRecycleRefund - killRecycleRefund;
			return new UnitCost(previousInfCost.Minerals + materialMinerals, previousInfCost.Kills + totalKillCost, 0);
		}

		int GetInfuseRecycleRefund(int infusion, int infuseDiscount = 0)
		{
			return (infusion - infuseDiscount) * loadout.IncomeManager.InfuseRecycle;
		}

		(double Cost, int ExcessKills) GetFeedCost(int infuse, UnitType unitType, int currentUnitFeed, int infuseDiscount)
		{
			ErrorReporter.ReportDebug($"param:{nameof(infuseDiscount)} should never be higher then param:{nameof(infuse)}", () => infuseDiscount > infuse);
			ErrorReporter.ReportDebug("Infuse doesn't go there", () => infuse < 0 || infuse > 10);
			var coreCost = infuse * (infuse + 1) * 100 - infuseDiscount * (infuseDiscount + 1) * 100;

			currentUnitFeed = unitType.IsCoreBasic()
				? loadout.IncomeManager.Veterancy
				: currentUnitFeed;
			var cost = coreCost - currentUnitFeed;
			var excessKills = Math.Max(0, -cost);
			cost = Math.Max(0, cost);
			return (cost, excessKills);
		}

        static int UnitsRequiredForInfuse(double infuse, double infuseDiscount)
		{
			var x = (infuse + 1) / 2;
			var unitsRequired = (int)(Math.Floor(x) * Math.Floor(x + 0.5));

			var y = (infuseDiscount + 1) / 2;
			unitsRequired -= (int)(Math.Floor(y) * Math.Floor(y + 0.5));
			return unitsRequired;
		}

		UnitCost GetBaseCreationCost(IUnitData unitData, bool isLimitBroken)
		{
			if (isLimitBroken)
			{
				var cost = GetRawUnitCost(unitData.Type, 10, UnitRankType.XD, false);
				cost += GetRawUnitCost(unitData.Type, 10, UnitRankType.None, false);
				return cost;
			}
			else if (unitData.Evolution == Evolution.Basic && !unitData.Type.IsHidden())
			{
				var cost = unitData.Type.GetBasicUnitMineralCost(loadout);
				return new UnitCost(cost, 0, loadout.IncomeManager.Veterancy);
			}
			else if (unitData.Evolution == Evolution.DNA1 && !unitData.Type.IsHidden() && loadout.Perks.BlackMarket.DesiredLevel > 0)
			{
				var mineralCost = unitData.BasicType.GetBasicUnitMineralCost(loadout) * 15;
				var killCost = 2200 / (1 + loadout.IncomeManager.DoubleWarp / 100.0 + loadout.IncomeManager.TripleWarp / 50.0);
				return new UnitCost(mineralCost, killCost, loadout.IncomeManager.Veterancy);
			}
			else
			{
				var cost = new UnitCost(0, 0);
				var costs = new List<(UnitCost UnitCost, bool CanUseForEvo)>();

				foreach (var piece in unitData.Recepe)
				{
					for (var i = 0; i < piece.Quantity; i++)
					{
						var newCost = GetRawUnitCost(piece.Unit, piece.Infuse, piece.Rank, false);
						costs.Add((newCost, piece.CanUseForEvo));
						if (!piece.CanUseForEvo)
						{
							newCost.CurrentUnitKills = 0;
							cost = newCost + cost; // don't += this as '+' is sensitive to left and right
						}
						else
						{
							var excessKills = Math.Max(newCost.CurrentUnitKills, cost.CurrentUnitKills);
							cost += newCost;
							cost.CurrentUnitKills = excessKills;
						}
					}
				}
				var killRecycleRefund = GetKillRecycleRefund(costs);
				cost.Kills -= killRecycleRefund;
				return cost;
			}
		}

		double GetKillRecycleRefund(List<(UnitCost UnitCost, bool CanUseForEvo)> costs)
		{
			var killRecycle = (double)loadout.IncomeManager.KillRecycle;
			if (killRecycle > 0)
			{
				killRecycle /= 100.0;
				var orderedCosts = costs.OrderBy(x => !x.CanUseForEvo).ThenBy(x => x.UnitCost.CurrentUnitKills).ToList();

				// main unit refund
				var refundAmount = GetKillRecycleRefund(orderedCosts[0].UnitCost);

				// sacrificed unit refund
				if (orderedCosts.Count > 1)
				{
					refundAmount += GetKillRecycleRefund(orderedCosts[1].UnitCost);
				}

				if (hasFullKillRecycle && orderedCosts.Count > 2)
				{
					for (var i = 2; i < orderedCosts.Count; i++)
					{
						refundAmount += GetKillRecycleRefund(orderedCosts[i].UnitCost);
					}
				}
				return refundAmount;
			}
			return 0;
		}

		double GetKillRecycleRefund(UnitCost materialCost, int infusion = 1, int infuseDiscount = 0, int materialCount = 1)
		{
			var killRecycle = (double)loadout.IncomeManager.KillRecycle;

			if (hasFullKillRecycle)
			{
				killRecycle /= 100.0;
				return killRecycle * materialCount * materialCost.CurrentUnitKills;
			}
			else if (killRecycle > 0)
			{
				killRecycle /= 100.0;
				return killRecycle * (infusion - infuseDiscount) * materialCost.CurrentUnitKills;
			}

			return 0;
		}

		#region Resetable variables

		#region Quick Start

		bool TryUseQSCharge()
		{
			if (qsCharges > 0)
			{
				qsCharges--;
				return true;
			}
			return false;
		}
		int qsCharges;

		#endregion

		#region DNA Start

		bool TryUseDNAStart()
		{
			if (!hasUsedDNAStart)
			{
				hasUsedDNAStart = true;
				return true;
			}
			return false;
		}
		bool hasUsedDNAStart;

		#endregion

		#region shouldGrantDNAFreeInf1

		bool shouldGrantDNAFreeInf1;

		#endregion

		#region hasFullKillRecycle

		bool hasFullKillRecycle;

		#endregion

		internal void ResetCalculationVariables()
		{
			qsCharges = loadout.Perks.QuickStart.DesiredLevel;
			if (qsCharges == 3 && loadout.Perks.UpgradeCache.DesiredLevel == 1)
			{
				qsCharges += 2;
			}
			hasUsedDNAStart = false;
			shouldGrantDNAFreeInf1 = loadout.Perks.DNAStart.DesiredLevel == 5 && loadout.Perks.UpgradeCache.DesiredLevel == 1;
			hasFullKillRecycle = loadout.Perks.KillRecycle.DesiredLevel == 5 && loadout.Perks.UpgradeCache.DesiredLevel == 1;
			hasRSS = loadout.IncomeManager.HasRSS;
			hasRSSS = loadout.IncomeManager.HasRSSS;

#if DEBUG
			firstDNAStart = UnitType.None;
#endif
		}

		bool hasRSS;
		bool hasRSSS;

		#endregion

		#region Recipes

		public static IEnumerable<UnitRecepePiece> GetEmptyRecipe()
		{
			return Array.Empty<UnitRecepePiece>();
		}

		public static IEnumerable<UnitRecepePiece> GetDNA1Recipe(UnitType type)
		{
			yield return new UnitRecepePiece(type, 3, UnitRankType.None, 1, true);
			yield return new UnitRecepePiece(type, 1, UnitRankType.None, 5, false);

			ErrorReporter.ReportDebug("This should always be a basic unit", () => !type.IsCoreBasic());
		}

		public static IEnumerable<UnitRecepePiece> GetDNA2Recipe(UnitType type)
		{
			yield return new UnitRecepePiece(type, 5, UnitRankType.None, 1, true);
			yield return new UnitRecepePiece(type, 1, UnitRankType.None, 4, false);

			ErrorReporter.ReportDebug("This should always be a dna1 unit", () => !type.IsDNA1());
		}

		#endregion

		#region DEBUG
#if DEBUG
		void RecordDNAStartUnit(IUnitData unitData, int infusion)
		{
			if (unitData.Type.IsDNA1() && infusion >= loadout.Perks.DNAStart.DesiredLevel)
			{
				// we need to use a loadout that does not contain spec for the error reporter as it can cause an error if two units have the same cost but spec makes one cheaper then the other
				var emptyLoadout = new Loadout();
				if (!hasAlerted && firstDNAStart != UnitType.None && firstDNAStart.GetBasicUnitMineralCost(emptyLoadout) < unitData.BasicType.GetBasicUnitMineralCost(emptyLoadout))
				{
					hasAlerted = true;
					_ = $"DNA start should have used the most expensive DNA. It was used on the DNA with a {firstDNAStart} as a base unit instead of a {unitData.BasicType} as the base unit. Consider changing the recepe order to ensure this occurs.";
					Debugger.Break(); // I don't want to exception here as this isn't actually a problem. this is less invasive
				}
				firstDNAStart = firstDNAStart != UnitType.None ? firstDNAStart : unitData.BasicType;
			}
		}
		static bool hasAlerted;
		UnitType firstDNAStart;
#endif
		#endregion
	}

	public struct UnitCost
	{
		public UnitCost(double mins, double kills, int excessKills)
		{
			Minerals = mins;
			Kills = kills;
			CurrentUnitKills = excessKills;
		}
		public UnitCost(double mins, double kills) : this(mins, kills, 0)
		{
		}

		public double Minerals { get; set; }
		public double Kills { get; set; }
		public int CurrentUnitKills { get; set; }

		public static UnitCost operator -(UnitCost a) => new(-a.Minerals, -a.Kills, a.CurrentUnitKills);
		public static UnitCost operator +(UnitCost a, UnitCost b) => new(a.Minerals + b.Minerals, a.Kills + b.Kills, b.CurrentUnitKills);
		public static UnitCost operator -(UnitCost a, UnitCost b) => a += (-b);
		public static UnitCost operator *(UnitCost a, double b) => new(a.Minerals * b, a.Kills * b, a.CurrentUnitKills);
		public static UnitCost operator /(UnitCost a, (double, double) b) => new(a.Minerals / b.Item1, a.Kills / b.Item2, a.CurrentUnitKills);
	}
}
