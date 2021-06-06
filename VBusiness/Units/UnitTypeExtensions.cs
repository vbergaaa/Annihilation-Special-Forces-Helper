using System;
using VBusiness.HelperClasses;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public static class UnitTypeExtensions
	{
		public static bool IsCoreBasic(this UnitType unitType)
		{
			return unitType <= UnitType.Dominator;
		}

		public static bool IsDNA1(this UnitType unitType)
		{
			return unitType > UnitType.Dominator && unitType <= UnitType.ArchDominator;
		}

		public static bool IsHidden(this UnitType unitType)
		{
			return unitType >= UnitType.Dragoon;
		}

		public static double GetBasicUnitMineralCost(this UnitType unitType, VLoadout loadout)
		{
			var rawCost = GetBasicUnitRawCost(unitType);
			var cost = ApplyUnitSpec(unitType, loadout, rawCost);
			if (loadout.IncomeManager.HasSales)
			{
				cost *= 0.9;
			}
			return cost;
		}

		static double GetBasicUnitRawCost(UnitType unitType)
		{
			return unitType switch
			{
				UnitType.Probe => 750,
				UnitType.WarpLord => 2000,
				UnitType.ShieldBattery => 2250,
				UnitType.Striker => 4000,
				UnitType.LightAdept => 5000,
				UnitType.DarkShadow => 2000,
				UnitType.Dreadnought => 8000,
				UnitType.Templar => 20000,
				UnitType.Dominator => 70000,
				_ => GetInvalidZero(),
			};
		}

		static double ApplyUnitSpec(UnitType unitType, VLoadout loadout, double rawCost)
		{
			if ((loadout.Perks.UnitSpecialization.DesiredLevel > 0
				&& loadout.UnitSpec != UnitType.None
				&& unitType == loadout.UnitSpec)
				|| (loadout.Perks.UnitSpecialization.DesiredLevel == 10
				&& loadout.Perks.UpgradeCache.DesiredLevel > 0))
			{
				rawCost *= 1 - 0.02 * loadout.Perks.UnitSpecialization.DesiredLevel;
			}
			else if (loadout.UnitSpec != UnitType.None && loadout.Perks.UnitSpecialization.DesiredLevel > 0)
			{
				rawCost *= 2 - 0.1 * loadout.Perks.UnitSpecialization.DesiredLevel;
			}

			return rawCost;
		}

		static int GetInvalidZero()
		{
			ErrorReporter.ReportDebug("Basic Units Only");
			return 0;
		}
	}
}
