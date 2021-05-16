using System;
using System.Collections.Generic;
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
		}

		UnitCost GetRawUnitCost(UnitRecepePiece piece)
		{
			return GetRawUnitCost(piece.Unit, piece.Infuse, piece.Rank);
		}

		public UnitCost GetUnitCost(VUnit unit)
		{
			return GetUnitCost(unit.UnitData.Type, unit.CurrentInfusion, unit.UnitRank);
		}

		public UnitCost GetUnitCost(UnitType unitType, int infuse, UnitRankType rank)
		{
			if (unitType != UnitType.None)
			{
				var cost = GetRawUnitCost(unitType, infuse, rank);
				var effectiveDW = (1 + loadout.IncomeManager.DoubleWarp / 100.0 + loadout.IncomeManager.TripleWarp / 50.0);
				return cost / (effectiveDW, 1);
			}
			return new UnitCost(0, 0);
		}

		UnitCost GetRawUnitCost(UnitType unitType, int infuse, UnitRankType rank)
		{
			IUnitData unitData = VUnit.GetUnitData(unitType);

			// theres some horrible spaghetti with the logic for adding two UnitCost structs because we don't want to sum the ExcessKills.
			// It takes the Excess Kills from the element on the right side of the '+' operator.
			// Please ensure you leave these cost additions in this order to avoid breaking this accidently
			var cost = GetRankCost(rank);
			cost += GetBaseCreationCost(unitData);
			cost += GetInfusionCosts(unitData, infuse, cost.ExcessKills);
			return cost;
		}

		UnitCost GetRankCost(UnitRankType rank)
		{
			var rankCost = UnitRankUpHelper.GetRankCost(rank, loadout.IncomeManager.RankRevision, loadout.IncomeManager.HasRefundSoul);
			return new UnitCost(0, rankCost);
		}

		UnitCost GetInfusionCosts(IUnitData unitData, int infuse, int excessKills)
		{
			if (infuse == 0)
			{
				return new UnitCost(0, 0, excessKills);
			}

			var material = new UnitRecepePiece(unitData.BasicType, (int)unitData.Evolution, UnitRankType.None, 1);
			var materialCost = GetRawUnitCost(material);
			var mainUnitFeedCost = GetFeedCost(infuse, unitData.Type, excessKills);
			var materialQty = UnitsRequiredForInfuse(infuse);
			return new UnitCost(materialCost.Minerals * materialQty, materialCost.Kills * materialQty + mainUnitFeedCost.Cost, mainUnitFeedCost.ExcessKills);
		}

		(double Cost, int ExcessKills) GetFeedCost(int infuse, UnitType unitType, int currentUnitFeed)
		{
			ErrorReporter.ReportDebug("Infuse doesn't go there", () => infuse < 0 || infuse > 10);
			var coreCost = infuse * (infuse + 1) * 100;

			currentUnitFeed = unitType.IsCoreBasic()
				? loadout.IncomeManager.Veterancy
				: currentUnitFeed;
			var cost = coreCost - currentUnitFeed;
			var excessKills = Math.Max(0, -cost);
			cost = Math.Max(0, cost);
			return (cost, excessKills);
		}

		int UnitsRequiredForInfuse(double infuse)
		{
			var x = (infuse + 1) / 2;
			return (int)(Math.Floor(x) * Math.Floor(x + 0.5));
		}

		int GetInvalidZero()
		{
			ErrorReporter.ReportDebug("Invalid Switch Option");
			return 0;
			throw new NotImplementedException();
		}

		UnitCost GetBaseCreationCost(IUnitData unitData)
		{
			if (unitData.Evolution == Evolution.Basic && !unitData.Type.IsHidden())
			{
				var cost = unitData.Type.GetBasicUnitRawCost();
				return new UnitCost(cost, 0, loadout.IncomeManager.Veterancy);
			}
			else
			{
				var cost = new UnitCost(0, 0);
				foreach (var piece in unitData.Recepe)
				{
					var newCost = GetRawUnitCost(piece.Unit, piece.Infuse, piece.Rank) * piece.Quantity;
					if (!piece.CanUseForEvo)
					{
						newCost.ExcessKills = 0;
						cost = newCost + cost; // don't += this as '+' is sensitive to left and right
					}
					else
					{
						var excessKills = Math.Max(newCost.ExcessKills, cost.ExcessKills);
						cost += newCost;
						cost.ExcessKills = excessKills;
					}
				}
				return cost;
			}
		}

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
	}

	public struct UnitCost
	{
		public UnitCost(double mins, double kills, int excessKills)
		{
			Minerals = mins;
			Kills = kills;
			ExcessKills = excessKills;
		}
		public UnitCost(double mins, double kills) : this (mins, kills, 0)
		{
		}

		public double Minerals { get; set; }
		public double Kills { get; set; }
		public int ExcessKills { get; set; }

		public static UnitCost operator -(UnitCost a) => new UnitCost(-a.Minerals, -a.Kills, a.ExcessKills);
		public static UnitCost operator +(UnitCost a, UnitCost b) => new UnitCost(a.Minerals + b.Minerals, a.Kills + b.Kills, b.ExcessKills);
		public static UnitCost operator -(UnitCost a, UnitCost b) => a += (-b);
		public static UnitCost operator *(UnitCost a, double b) => new UnitCost(a.Minerals * b, a.Kills * b, a.ExcessKills);
		public static UnitCost operator /(UnitCost a, (double, double) b) => new UnitCost(a.Minerals / b.Item1, a.Kills / b.Item2, a.ExcessKills);
	}
}
