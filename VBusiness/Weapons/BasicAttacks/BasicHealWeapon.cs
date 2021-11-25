using System;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class BasicHealWeapon : IWeaponData
	{
		public static double AttackCount => 1;

		public static double AttackPeriodIncrement => 0.94;

		public abstract double BaseAttack { get; }

		public abstract double BaseAttackPeriod { get; }

		public abstract double AttackIncrement { get; }

		public double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy)
		{
			// get damage of weapon scaled with damage increase
			var rawHeal = BaseAttack + loadout.Upgrades.AttackUpgrade * AttackIncrement;
			rawHeal *= loadout.Stats.Attack / 100;
			rawHeal *= 1 + loadout.Stats.DamageIncrease / 100;

			// apply an average crit modifier to increase the damage dealt
			var totalHealed = rawHeal * BasicAttackWeapon.CritModifier(WeaponHelper.Crits, loadout.Stats.CriticalDamage);

			// divide damage by attack speed to get the damage dealt per second
			var rawAttackSpeed = BaseAttackPeriod * Math.Pow(0.96, loadout.Upgrades.AttackSpeedUpgrade);
			var actualAttackSpeed = rawAttackSpeed / (loadout.Stats.AttackSpeed / 100);
			actualAttackSpeed /= loadout.Stats.Acceleration / 100;

			var totalHps = totalHealed / actualAttackSpeed;
			return totalHps;
		}
	}
}