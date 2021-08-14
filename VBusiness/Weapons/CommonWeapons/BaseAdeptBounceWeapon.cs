using System;
using System.Linq;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class BaseAdeptBounceWeapon : BasicAttackWeapon
	{

		protected abstract int MaxBounces { get; }
		protected abstract double BounceDamagePercentage { get; }
		protected abstract bool IncludeTransferInDamageCalcs { get; }

		protected internal override double GetActualWeaponPeriod(VLoadout loadout)
		{
			if (!IncludeTransferInDamageCalcs)
			{
				return base.GetActualWeaponPeriod(loadout);
			}

			// this method incorporates attacks from annihilation transfer into the base adept attack speed
			// each transfer sends out 5 attacks
			// each attack can hit 4 units with aoe
			// therefore the light adept gets 20 additional attacks in the duration of the transfer cooldown
			// cd: 16
			var transferCoolDown = 16 / (loadout.Stats.CooldownSpeed / 100);
			var additionalAttacksPerSecond = 5 * 4 / transferCoolDown;

			var originalAttackPerSecond = 1 / base.GetActualWeaponPeriod(loadout);
			var newAttacksPerSecond = originalAttackPerSecond + additionalAttacksPerSecond;
			return 1 / newAttacksPerSecond;
		}
		public override double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy, ICritChances crits)
		{
			// if crit, deal 80%-90% damage to nearby enemy
			// max bounce 3-4

			var startingDamage = GetWeaponDamage(loadout);
			startingDamage *= loadout.Stats.Attack / 100;
			startingDamage *= 1 + loadout.Stats.DamageIncrease / 100;
			startingDamage *= (1 - enemy.DamageReduction / 100);

			var damageDealt = GetAdeptDamage(loadout, startingDamage, enemy, crits);

			// I'm intentionally removing this attack count, because SA deals a *stupid* amount of damage as it is already, 
			// (100x stronger than SuperHero units at max stats) and we don't need to multiply it by 3. It can be humble
			//damageDealt *= AttackCount;
			var dps = damageDealt / GetActualWeaponPeriod(loadout);
			return dps;
		}

		double GetAdeptDamage(VLoadout loadout, double baseDamage, IEnemyStatCard enemy, ICritChances crits)
		{
			var damages = new (double, double)[] { (1, baseDamage) };
			return GetAdeptChainDamage(loadout, damages, enemy, crits, 0, calculateFirstEntry: true);
		}

		double GetAdeptChainDamage(VLoadout loadout, (double Chance, double Damage)[] damageChances, IEnemyStatCard enemy, ICritChances crits, int bounce, bool calculateFirstEntry = false)
		{
			var totalDamageDealt = 0.0;
			if (bounce >= MaxBounces)
			{
				return totalDamageDealt;
			}

			foreach (var damageChance in damageChances)
			{
				if ((!calculateFirstEntry && damageChances.First() == damageChance) || damageChance.Chance == 0)
				{
					continue;
				}

				var baseDamage = damageChance.Damage * (bounce == 0 ? 1 : BounceDamagePercentage / 100);

				var damageDealt = GetCoreDamageDealt(loadout, enemy, baseDamage, out var bonusCritDamage);
				var critDamage = (loadout.Stats.CriticalDamage + bonusCritDamage) / 100.0;

				var newDamageChances = new (double Chance, double Damage)[]
				{
					(damageChance.Chance * crits.RegularChance, damageDealt),
					(damageChance.Chance * crits.YellowChance, damageDealt * (1 + critDamage)),
					(damageChance.Chance * crits.RedChance, damageDealt * (1 + 2 * critDamage)),
					(damageChance.Chance * crits.BlackChance, damageDealt * (1 + 3.5 * critDamage))
				};
				var singleTargetDamageToUnit = newDamageChances.Sum(x => x.Chance * x.Damage);
				totalDamageDealt += singleTargetDamageToUnit;
				totalDamageDealt += GetAdeptChainDamage(loadout, newDamageChances, enemy, crits, bounce + 1) * AttackCount;
			}
			return totalDamageDealt;
		}

		double GetCoreDamageDealt(VLoadout loadout, IEnemyStatCard enemy, double rawDamage, out double bonusCritDamage)
		{
			// get the enemies armor, allowing for quasar buff's armor reduction
			var enemyArmor = loadout.CurrentUnit.UnitRank >= UnitRankType.SXDZ
				? enemy.Armor * 0.7
				: enemy.Armor;

			// get the bonus critical damage from void buff
			bonusCritDamage = loadout.CurrentUnit.UnitRank >= UnitRankType.XYZ
				? enemyArmor / 5
				: 0;

			// determine the effective armor when armor pierce is considered
			enemyArmor *= (1 - ArmorPenetration / 100);

			// get the core damage dealt to the unit, before crits.
			// if the enemy has more armor than the weapon can deal, deal 0.5 damage
			return Math.Max(rawDamage - enemyArmor, 0.5);
		}
	}
}
