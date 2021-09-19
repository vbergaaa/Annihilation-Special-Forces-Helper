namespace VBusiness.Weapons
{
	class GalaxianOrbiterGalacticResonance : CommonOrbAbility
	{
		// create up to 15 orbs from nearby enemies
		// cd 15
		public override int OrbTravelDuration => 6;

		public override int OrbsPerAttack => 15;

		protected override double AbilityCooldown => 15;

		protected override CommonOrbAttack GetBasicOrbWeapon()
		{
			return new GalaxianOrbiterBasicWeapon();
		}
	}
}
