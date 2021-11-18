using System;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class BasicAttackWeapon : IWeaponData
	{
		public virtual double AttackCount => 1;

		public static double AttackPeriodIncrement => 0.94;

		public abstract double BaseAttack { get; }

		public abstract double BaseAttackPeriod { get; }

		public abstract double AttackIncrement { get; }

		public virtual double ArmorPenetration => 0;

		protected virtual ICritChances Crits => WeaponHelper.Crits;

		public virtual double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy)
		{
			// get damage of weapon scaled with damage increase and damage reduction
			double rawDamage = GetWeaponDamage(loadout);
			rawDamage *= loadout.Stats.Attack / 100;
			rawDamage *= 1 + loadout.Stats.DamageIncrease / 100;
			rawDamage *= (1 - enemy.DamageReduction / 100);

			// get the enemies armor, allowing for quasar buff's armor reduction
			var enemyArmor = loadout.CurrentUnit.UnitRank >= UnitRankType.SXDZ
				? enemy.Armor * 0.7
				: enemy.Armor;

			// get the bonus critical damage from void buff
			var bonusCritDamage = loadout.CurrentUnit.UnitRank >= UnitRankType.XYZ
				? enemyArmor / 5
				: 0;

			// determine the effective armor when armor pierce is considered
			enemyArmor *= (1 - ArmorPenetration / 100);

			// get the core damage dealt to the unit, before crits.
			// if the enemy has more armor than the weapon can deal, deal 0.5 damage
			var effectiveDamage = Math.Max(rawDamage - enemyArmor, 0.5);

			// apply an average crit modifier to increase the damage dealt
			var totalDamage = effectiveDamage * CritModifier(Crits, loadout.Stats.CriticalDamage + bonusCritDamage);

			// multiple the attack by the number of units hit
			totalDamage *= GetAttackCount(loadout);

			// divide damage by attack speed to get the damage dealt per second
			var totalDps = totalDamage / GetActualWeaponPeriod(loadout);
			return totalDps;
		}

		protected virtual double GetWeaponDamage(VLoadout loadout)
		{
			return BaseAttack + loadout.Upgrades.AttackUpgrade * AttackIncrement;
		}

		protected internal virtual double GetActualWeaponPeriod(VLoadout loadout)
		{
			var rawAttackSpeed = BaseAttackPeriod * Math.Pow(0.96, loadout.Upgrades.AttackSpeedUpgrade);
			var actualAttackSpeed = rawAttackSpeed / (loadout.Stats.AttackSpeed / 100);
			actualAttackSpeed /= loadout.Stats.Acceleration / 100;
			return actualAttackSpeed;
		}

		internal static double CritModifier(ICritChances crits, double critDamage)
		{
			var totalCritDamage = critDamage / 100.0;
			var avgCritMultiplier = (1 * crits.RegularChance)
				+ (1 + totalCritDamage) * crits.YellowChance
				+ (1 + 2 * totalCritDamage) * crits.RedChance
				+ (1 + 3.5 * totalCritDamage) * crits.BlackChance;
			return avgCritMultiplier;
		}

		protected virtual double GetAttackCount(VLoadout loadout)
		{
			return AttackCount;
		}
	}
}
