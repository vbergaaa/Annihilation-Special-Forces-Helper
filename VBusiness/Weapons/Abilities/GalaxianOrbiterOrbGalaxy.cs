using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	class GalaxianOrbiterOrbGalaxy : CommonOrbExtension
	{
		// passive : attacks orbit for 6 seconds after finishing
		//
		// cd: 60
		// dur: 20
		// active : duration changed to 12 seconds
		protected override double OrbFreezeDuration => 6;

		protected override double AbilityCooldown => 60;

		protected internal override double GetActualWeaponPeriod(VLoadout loadout)
		{
			// if this cooldown is any faster than 20 seconds, it doesn't actually deal extra damage,
			// we will just have perma 12s orbs, which effectively means that every orb spawned has
			// an additional 6 seconds of timed life
			// (passive 6 seconds are built into weapons)
			return System.Math.Max(base.GetActualWeaponPeriod(loadout), 20);
		}

		protected override int DurationAbilityEffectAppliesFor => 20;

		protected override CommonOrbAttack GetBasicOrbWeapon() => new GalaxianOrbiterBasicWeapon();

		protected override IEnumerable<CommonOrbAbility> GetOrbAbilities()
		{
			yield return new GalaxianOrbiterOrbSpiral();
			yield return new GalaxianOrbiterGalacticResonance();
		}
	}
}
