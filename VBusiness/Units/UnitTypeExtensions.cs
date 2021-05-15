using System;
using VBusiness.HelperClasses;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public static class UnitTypeExtensions
	{
		public static bool IsBasic(this UnitType unitType)
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

		public static int GetBasicUnitRawCost(this UnitType unitType)
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

		static int GetInvalidZero()
		{
			ErrorReporter.ReportDebug("Basic Units Only");
			return 0;
		}
	}
}
