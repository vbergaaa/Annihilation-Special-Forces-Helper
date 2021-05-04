using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Difficulties;
using VBusiness.Enemies;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class StatCalculationHelper
	{
		public static double GetToughness(VLoadout loadout)
		{
			if (loadout.UseUnitStats && loadout.CurrentUnit != null)
			{
				var difficulty = loadout.UnitConfiguration.Difficulty;
				if (difficulty == null || difficulty is EmptyDifficulty)
				{
					difficulty = new Normal();
				}
				var rawEnemyDamages = GetUnitRawDamages(difficulty);
				var enemyDamages = rawEnemyDamages.Select(tuple => (tuple.Item1, tuple.Item2* (1 - loadout.Stats.DamageReduction / 100)));

				var hitsTillDeath = GetHitsTillDeath(enemyDamages, loadout.Stats);
				var totalDamageTillDeath = hitsTillDeath * rawEnemyDamages.Sum(tuple => (tuple.Item1 * tuple.Item2));
				return totalDamageTillDeath;
			}
			return 0;
		}

		public static double GetDamage(VLoadout loadout)
		{
			if (loadout.UseUnitStats && loadout.CurrentUnit != null)
			{
				var crits = GetCritChances(loadout);
				var composition = GetEnemyUnitComposition(loadout.UnitConfiguration.Difficulty, CompositionOptions.Normal);
				var enemyArmors = GetEnemyArmor(composition, loadout.UnitConfiguration.Difficulty);
				var damages = GetBaseDamageDealt(enemyArmors, loadout);
				damages = ApplyCrits(damages, crits, loadout.Stats.CriticalDamage);
				var averageDamagePerHit = damages.Sum(x => (x.Item1 * x.Item2));
				var dps = averageDamagePerHit / loadout.Stats.UnitAttackSpeed * loadout.CurrentUnit.UnitData.AttackCount;

				return Math.Round(dps, 2);
			}
			return 0;
		}

		static IEnumerable<(double, double)> ApplyCrits(IEnumerable<(double, double)> damages, CritChances crits, double critDamage)
		{
			critDamage /= 100.0;
			var avgCritMultiplier = (1 * crits.RegularChance)
				+ (1 + critDamage) * crits.YellowChance
				+ (1 + 2 * critDamage) * crits.RedChance
				+ (1 + 3.5 * critDamage) * crits.BlackChance;
			return damages.Select(e => (e.Item1, e.Item2 * avgCritMultiplier));
		}

		static IEnumerable<(double, double)> GetBaseDamageDealt(IEnumerable<(double, double)> enemyArmors, VLoadout loadout)
		{
			var unitDamage = loadout.Stats.UnitAttack;
			unitDamage *= loadout.Stats.DamageIncrease / 100;
			unitDamage *= (1 - loadout.UnitConfiguration.Difficulty.DamageReduction / 100.0);

			return enemyArmors.Select(e => (e.Item1, Math.Max(unitDamage - e.Item2, 0.5)));
		}

		static IEnumerable<(double, double)> GetEnemyArmor(IEnumerable<(EnemyType, double)> composition, VDifficulty difficulty)
		{
			var units = composition.Select(u => (u.Item2, EnemyUnit.New(u.Item1)));
			return units.Select(u => (u.Item1, GetEnemyArmorForDifficulty(u.Item2, difficulty)));
		}

		static double GetEnemyArmorForDifficulty(EnemyUnit unit, VDifficulty difficulty)
		{
			var baseArmor = unit.HealthArmor + (difficulty.RoomToClear + difficulty.StartingUpgrades) * unit.HealthArmorIncrement;
			return baseArmor * difficulty.Armor;
		}

		static CritChances GetCritChances(VLoadout loadout)
		{
			var perks = loadout.Perks as PerkCollection;
			var stats = loadout.Stats;
			var critChances = new CritChances();

			var remainingChance = 1.0;

			var blackCritChance = perks.BlackCrits.DesiredLevel > 0 ? stats.CriticalChance / 300.0 : 0;
			blackCritChance = blackCritChance > 1 ? 1 : blackCritChance;
			critChances.BlackChance = blackCritChance;
			remainingChance -= blackCritChance;

			var redCritChance = perks.RedCrits.DesiredLevel>0 ? remainingChance * stats.CriticalChance / 200 : 0;
			redCritChance = redCritChance > remainingChance ? remainingChance : redCritChance;
			critChances.RedChance = redCritChance;
			remainingChance -= redCritChance;

			var yellowCritChance = remainingChance * stats.CriticalChance / 100;
			yellowCritChance = yellowCritChance > remainingChance ? remainingChance : yellowCritChance;
			critChances.YellowChance = yellowCritChance;
			remainingChance -= yellowCritChance;

			critChances.RegularChance = remainingChance;

			ErrorReporter.ReportDebug(critChances.RegularChance + critChances.YellowChance + critChances.RedChance + critChances.BlackChance != 1, "your crit calculations need to equal 100");
			return critChances;
		}

		static double GetHitsTillDeath(IEnumerable<(double, double)> enemyDamages, VStats stats)
		{
			if (!stats.Loadout.UseUnitStats || stats.Loadout.CurrentUnit == null)
			{
				throw new NotImplementedException();
			}

			var damageOnShields = enemyDamages.Select(tuple => (tuple.Item1, Math.Max(0.5, tuple.Item2 - stats.UnitShieldsArmor)));
			var damageOnHealth = enemyDamages.Select(tuple => (tuple.Item1, Math.Max(0.5, tuple.Item2 - stats.UnitHealthArmor)));

			var averageShieldDamage = damageOnShields.Sum(tuple => tuple.Item1 * tuple.Item2);
			var averageHealthDamage = damageOnHealth.Sum(tuple => tuple.Item1 * tuple.Item2);
			var hitsTillNoShields = stats.UnitShields / averageShieldDamage;
			var hitsTillNoHealth = stats.UnitHealth / averageHealthDamage;

			return hitsTillNoShields + hitsTillNoHealth;
		}

		static IEnumerable<(double, double)> GetUnitRawDamages(VDifficulty difficulty)
		{
			var unitComp = GetEnemyUnitComposition(difficulty, CompositionOptions.ExcludeNoAttack);
			return unitComp.Select(kvp => (kvp.Item2, GetAdjustedUnitAttack(difficulty, kvp.Item1)));
		}

		static double GetAdjustedUnitAttack(VDifficulty difficulty, EnemyType unitType)
		{
			var unit = EnemyUnit.New(unitType);
			var unitDamage = unit.Attack + unit.AttackIncrement * (difficulty.RoomToClear + difficulty.StartingUpgrades);
			unitDamage *= difficulty.Damage;
			unitDamage *= (1 + difficulty.DamageIncrease / 100.0);
			return unitDamage;
		}

		static IEnumerable<(EnemyType, double)> GetEnemyUnitComposition(VDifficulty difficulty, CompositionOptions options)
		{
			if (UnitCompOverride != null)
			{
				return UnitCompOverride;
			}
			return UnitCompositionGenerator.GetComposition(difficulty, options);
		}

		internal static IEnumerable<(EnemyType, double)> UnitCompOverride;

	}

	public struct CritChances
	{
		public double YellowChance { get; set; }
		public double RedChance { get; set; }
		public double BlackChance { get; set; }
		public double RegularChance { get; set; }
	}
}
