using System;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class OpenFireAbility : BasicAbilityWeapon
	{
		public override double AttackIncrement => BaseWeapon.AttackIncrement;

		protected override double AbilityDamage => BaseWeapon.BaseAttack;

		protected override double AbilityCooldown => 15;

		protected BasicAttackWeapon BaseWeapon => baseWeapon ??= GetNewBaseWeapon();

		BasicAttackWeapon baseWeapon;
		protected abstract BasicAttackWeapon GetNewBaseWeapon();


		protected BasicAbilityWeapon BaseStorm => baseStormWeapon ??= GetNewStormWeapon();

		BasicAbilityWeapon baseStormWeapon;
		protected abstract BasicAbilityWeapon GetNewStormWeapon();


		protected BasicAOEAttackWeapon BaseAOEWeapon => baseAOEWeapon ??= GetNewAOEWeapon();

		BasicAOEAttackWeapon baseAOEWeapon;
		protected abstract BasicAOEAttackWeapon GetNewAOEWeapon();

		protected override double GetAttackCount(VLoadout loadout)
		{
			var stormCoolDown = BaseStorm.GetActualWeaponPeriod(loadout);
			var stormUptime = Math.Min(4 / stormCoolDown, 1); // all Storms have an uptime of 4 seconds

			var enemiesHitWithStormDown = WeaponHelper.GetEnemiesAttackedInDuration(duration: 3.0, loadout, weapon: BaseWeapon);
			var enemiesHitWithStormUp = enemiesHitWithStormDown + BaseStorm.AttackCount;

			var averageEnemiesHit = enemiesHitWithStormUp * stormUptime + enemiesHitWithStormDown * (1 - stormUptime);
			return averageEnemiesHit * BaseAOEWeapon.AttackCount / 4; // arbituarily quarting the result because this thinks an XYZ WA hit's 8000 units, which is impossibly unrealistic
		}
	}
}
