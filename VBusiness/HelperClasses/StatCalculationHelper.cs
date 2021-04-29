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
			return unitComp.Select(kvp => (kvp.Value, GetAdjustedUnitAttack(difficulty, kvp.Key)));
		}

		static double GetAdjustedUnitAttack(VDifficulty difficulty, EnemyType unitType)
		{
			var unit = EnemyUnit.New(unitType);
			var unitDamage = unit.Attack + unit.AttackIncrement * (difficulty.RoomToClear + difficulty.StartingUpgrades);
			unitDamage *= difficulty.Damage;
			unitDamage *= (1 + difficulty.DamageIncrease / 100.0);
			return unitDamage;
		}

		static IDictionary<EnemyType, double> GetUnitComposition(VDifficulty difficulty)
		{
			if (UnitCompOverride != null)
			{
				return UnitCompOverride;
			}
			return GetBasicUnitComp(difficulty);
		}

		static IDictionary<EnemyType, double> GetBasicUnitComp(VDifficulty difficulty)
		{
			// this method assumes all units for a difficulty are the strongest basic enemy availble for that difficulty.
			// It will be enhanced in the future to be based off what the unit comp of all units + buildings for the last room/s of that difficulty
			EnemyType basicunit;

			if (difficulty.Difficulty <= DifficultyLevel.Easy)
			{
				basicunit = EnemyType.Zergling;
			}
			else if (difficulty.Difficulty <= DifficultyLevel.VeryHard)
			{
				basicunit = EnemyType.Roach;
			}
			else if (difficulty.Difficulty <= DifficultyLevel.Mythic)
			{
				basicunit = EnemyType.Hydralisk;
			}
			else if (difficulty.Difficulty <= DifficultyLevel.Divine)
			{
				basicunit = EnemyType.Pygalisk;
			}
			else
			{
				basicunit = EnemyType.PrimalHydralisk;
			}

			return new Dictionary<EnemyType, double>() { { basicunit, 1 } };
		}

		internal static IDictionary<EnemyType, double> UnitCompOverride;
	}
}
