using System.Collections.Generic;

namespace VBusiness.Weapons
{
	class OrbDancerOrbExtension : CommonOrbExtension
	{
		// freeze actively moving orbs in 7 range and set their duration to 5 seconds
		// looks like 6 atks in this time with no ups

		protected override double AbilityCooldown => 15;

		protected override double OrbFreezeDuration => 5;

		protected override CommonOrbAttack GetBasicOrbWeapon()
		{
			return new OrbDancerBasicWeapon();
		}

		protected override IEnumerable<CommonOrbAbility> GetOrbAbilities()
		{
			yield return new OrbDancerOrbArc();
		}
	}
}
