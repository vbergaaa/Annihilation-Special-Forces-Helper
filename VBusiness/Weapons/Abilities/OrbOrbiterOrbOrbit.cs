using System.Collections.Generic;

namespace VBusiness.Weapons
{
	public class OrbOrbiterOrbOrbit : CommonOrbExtension
	{
		// locks existing orbs 6 range away for 6.5 seconds
		// looks like 8 atks in this time with no ups (tho says 1/s)
		protected override double OrbFreezeDuration => 6.5;

		protected override double AbilityCooldown => 15;

		protected override CommonOrbAttack GetBasicOrbWeapon()
		{
			return new OrbOrbiterBasicWeapon();
		}

		protected override IEnumerable<CommonOrbAbility> GetOrbAbilities()
		{
			yield return new OrbOrbiterOrbWave();
		}
	}
}
