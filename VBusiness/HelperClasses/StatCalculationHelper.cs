using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Difficulties;
using VBusiness.Enemies;
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
			var unitComp = GetUnitComposition(difficulty);
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

		static IEnumerable<(EnemyType, double)> GetUnitComposition(VDifficulty difficulty)
		{
			if (UnitCompOverride != null)
			{
				return UnitCompOverride;
			}
			return UnitCompositionGenerator.GetComposition(difficulty);
		}

		internal static IEnumerable<(EnemyType, double)> UnitCompOverride;
	}
}
