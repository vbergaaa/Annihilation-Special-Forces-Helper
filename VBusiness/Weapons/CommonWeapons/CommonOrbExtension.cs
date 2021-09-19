using System;
using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class CommonOrbExtension : CommonOrbAbility
	{
		public override int OrbTravelDuration => throw new NotImplementedException();
		public override int OrbsPerAttack => throw new NotImplementedException();
		protected abstract double OrbFreezeDuration { get; }

		protected IEnumerable<CommonOrbAttack> OrbAttacksAndAbilities => orbAttacksAndAbilities ??= GetOrbAbilities().Cast<CommonOrbAttack>().Union(new[] { BasicOrbWeapon });
		IEnumerable<CommonOrbAttack> orbAttacksAndAbilities;

		protected abstract IEnumerable<CommonOrbAbility> GetOrbAbilities();

		protected virtual int DurationAbilityEffectAppliesFor => 0;

		protected override double GetAttackCount(VLoadout loadout)
		{
			var orbsAffectedByAbility = 0.0;

			foreach (var weapon in OrbAttacksAndAbilities)
			{
				orbsAffectedByAbility += DurationAbilityEffectAppliesFor == 0
					? (weapon.OrbTravelDuration * BasicOrbWeapon.OrbsPerAttack) / weapon.GetActualWeaponPeriod(loadout)
					: DurationAbilityEffectAppliesFor * weapon.OrbsPerAttack / weapon.GetActualWeaponPeriod(loadout);
			}


			var orbAttackSpeed = Math.Pow(0.96, loadout.Upgrades.AttackSpeedUpgrade);
			var attacksPerOrb = OrbFreezeDuration / orbAttackSpeed;

			return orbsAffectedByAbility * attacksPerOrb * WeaponHelper.GetEnemiesInRadius(RadiusOfOrbAttacks);
		}
	}
}
