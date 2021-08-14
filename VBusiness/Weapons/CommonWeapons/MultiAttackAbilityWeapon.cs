using System;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	abstract class MultiAttackAbilityWeapon : BasicAbilityWeapon
	{
		public MultiAttackAbilityWeapon()
		{
			BaseWeapon = GetBaseWeapon();
		}
		protected BasicAttackWeapon BaseWeapon { get; }

		protected abstract BasicAttackWeapon GetBaseWeapon();

		public override double AttackIncrement => throw new System.NotImplementedException();

		protected override double AbilityDamage => throw new System.NotImplementedException();

		protected virtual double ProcChance => 100;

		protected abstract double Duration { get; }

		protected abstract double TargetsHit { get; }

		public override double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy)
		{
			var abilityCd = AbilityCooldown / (loadout.Stats.CooldownSpeed / 100);
			var abilityUptime = Duration / abilityCd;
			abilityUptime = Math.Min(abilityUptime, 1);

			var extraAttacksModifier = (TargetsHit - BaseWeapon.AttackCount) / BaseWeapon.AttackCount;

			var baseWeaponDamage = BaseWeapon.GetDamageToEnemy(loadout, enemy);
			return baseWeaponDamage * abilityUptime * extraAttacksModifier * (ProcChance / 100);
		}
	}
}