using System;
using System.Collections.Generic;
using System.Text;
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
				var rawEnemyDamage = GetUnitRawDamage(difficulty);
				var enemyDamage = rawEnemyDamage * (1 - loadout.Stats.DamageReduction / 100);

				var hitsTillDeath = GetHitsTillDeath(enemyDamage, loadout.Stats);
				var totalDamageTillDeath = hitsTillDeath * rawEnemyDamage;
				return totalDamageTillDeath;
			}
			return 0;
		}

		static double GetHitsTillDeath(double enemyDamage, VStats stats)
		{
			if (!stats.Loadout.UseUnitStats || stats.Loadout.CurrentUnit == null)
			{
				throw new NotImplementedException();
			}

			var damageOnShields = Math.Max(0.5, enemyDamage - stats.UnitShieldsArmor);
			var damageOnHealth = Math.Max(0.5, enemyDamage - stats.UnitHealthArmor);

			var hitsTillNoShields = stats.UnitShields / damageOnShields;
			var hitsTillNoHealth = stats.UnitHealth / damageOnHealth;

			return hitsTillNoShields + hitsTillNoHealth;
		}

		static double GetUnitRawDamage(VDifficulty difficulty)
		{
			var unit = new Zergling();
			var unitDamage = unit.Attack + unit.AttackIncrement * difficulty.RoomToClear;
			unitDamage *= difficulty.Damage;
			unitDamage *= (1 + difficulty.DamageIncrease / 100.0);
			return unitDamage;
		}
	}
}
