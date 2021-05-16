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

			var cost = GetBaseCreationCost(unitData);
			cost += GetInfusionCosts(unitData, infuse);
			cost += GetRankCost(rank);
			return cost;
		}

		UnitCost GetRankCost(UnitRankType rank)
		{
			var rankCost = UnitRankUpHelper.GetRankCost(rank, loadout.IncomeManager.RankRevision);
			return new UnitCost(0, rankCost);
		}

		UnitCost GetInfusionCosts(IUnitData unitData, int infuse)
		{
			if (infuse == 0)
			{
				return new UnitCost(0, 0);
			}

			var material = new UnitRecepePiece(unitData.BasicType, (int)unitData.Evolution, UnitRankType.None, 1);
			var materialCost = GetRawUnitCost(material);
			var mainUnitFeedCost = GetFeedCost(infuse);
			var materialQty = UnitsRequiredForInfuse(infuse);
			return new UnitCost(materialCost.Minerals * materialQty, materialCost.Kills * materialQty + mainUnitFeedCost);
		}

		double GetFeedCost(int infuse)
		{
			return infuse switch
			{
				0 => 0,
				1 => 200,
				2 => 600,
				3 => 1200,
				4 => 2000,
				5 => 3000,
				6 => 4200,
				7 => 5600,
				8 => 7200,
				9 => 9000,
				10 => 11000,
				_ => GetInvalidZero()
			};
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
				return new UnitCost(cost, 0);
			}
			else
			{
				var cost = new UnitCost(0, 0);
				foreach (var piece in unitData.Recepe)
				{
					cost += GetRawUnitCost(piece.Unit, piece.Infuse, piece.Rank) * piece.Quantity;
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
			yield return new UnitRecepePiece(type, 3, UnitRankType.None, 1);
			yield return new UnitRecepePiece(type, 1, UnitRankType.None, 5);

			ErrorReporter.ReportDebug("This should always be a basic unit", () => !type.IsBasic());
		}

		public static IEnumerable<UnitRecepePiece> GetDNA2Recipe(UnitType type)
		{
			yield return new UnitRecepePiece(type, 5, UnitRankType.None, 1);
			yield return new UnitRecepePiece(type, 1, UnitRankType.None, 4);

			ErrorReporter.ReportDebug("This should always be a dna1 unit", () => !type.IsDNA1());
		}
	}

	public struct UnitCost
	{
		public UnitCost(double mins, double kills)
		{
			Minerals = mins;
			Kills = kills;
		}

		public double Minerals { get; set; }
		public double Kills { get; set; }

		public static UnitCost operator -(UnitCost a) => new UnitCost(-a.Minerals, -a.Kills);
		public static UnitCost operator +(UnitCost a, UnitCost b) => new UnitCost(a.Minerals + b.Minerals, a.Kills + b.Kills);
		public static UnitCost operator -(UnitCost a, UnitCost b) => a += (-b);
		public static UnitCost operator *(UnitCost a, double b) => new UnitCost(a.Minerals * b, a.Kills * b);
		public static UnitCost operator /(UnitCost a, (double, double) b) => new UnitCost(a.Minerals / b.Item1, a.Kills / b.Item2);
	}
}
