using VEntityFramework;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public static class WeaponHelper
	{
		public static double GetEnemiesInRadius(double radius)
		{
			// it's assumed throughout this app for damage calculations that there can be 4 enemies in a 1 radius block
			// therefore, averaging out the area using pi*r^2, in a 2 radius block, there can be 16 enemies, and a 3 radius block there can be 36 enemies

			return 4 * radius * radius;
		}

		internal static double GetEnemiesAttackedInDuration(double duration, VLoadout loadout, BasicAttackWeapon weapon)
		{
			var attackSpeed = weapon.GetActualWeaponPeriod(loadout);
			return duration / attackSpeed;
		}

		public static ICritChances Crits
		{
			get
			{
				if (crits == default)
				{
					ErrorReporter.ReportDebug("Crits gotta be set up first");
					crits = new CritChances() { RegularChance = 1 };
				}
				return crits;
			}
		}
		static ICritChances crits;

		public static void RefreshCritChances(VLoadout loadout)
		{
			var critChances = GetCritChances(loadout);
			crits = critChances;
		}

		internal static CritChances GetCritChances(VLoadout loadout)
		{
			var perks = loadout.Perks;
			var stats = loadout.Stats;
			var critChances = new CritChances();

			if (stats.CriticalChance <= 0)
			{
				critChances.RegularChance = 1.0;
			}
			else
			{
				var remainingChance = 1.0;

				var blackCritChance = stats.HasBlackCrits ? stats.CriticalChance / 300.0 : 0;
				blackCritChance = blackCritChance > 1 ? 1 : blackCritChance;
				critChances.BlackChance = blackCritChance;
				remainingChance -= blackCritChance;

				var redCritChance = stats.HasRedCrits ? remainingChance * stats.CriticalChance / 200 : 0;
				redCritChance = redCritChance > remainingChance ? remainingChance : redCritChance;
				critChances.RedChance = redCritChance;
				remainingChance -= redCritChance;

				var yellowCritChance = remainingChance * stats.CriticalChance / 100;
				yellowCritChance = yellowCritChance > remainingChance ? remainingChance : yellowCritChance;
				critChances.YellowChance = yellowCritChance;
				remainingChance -= yellowCritChance;

				critChances.RegularChance = remainingChance;
			}

			ErrorReporter.ReportDebug("your crit calculations need to equal 100", () => System.Math.Round(critChances.RegularChance + critChances.YellowChance + critChances.RedChance + critChances.BlackChance, 6) != 1);
			return critChances;
		}
	}

	struct CritChances : ICritChances
	{
		public double YellowChance { get; set; }
		public double RedChance { get; set; }
		public double BlackChance { get; set; }
		public double RegularChance { get; set; }
	}
}
