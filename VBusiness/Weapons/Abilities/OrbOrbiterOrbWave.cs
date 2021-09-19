namespace VBusiness.Weapons
{
	class OrbOrbiterOrbWave : CommonOrbAbility
	{
		// shoot 10 orbs in an arc to the target location
		// orbs atk 3 times in duration with no ups
		// cd 8
		public override int OrbTravelDuration => 3;

		public override int OrbsPerAttack => 10;

		protected override double AbilityCooldown => 8;

		protected override CommonOrbAttack GetBasicOrbWeapon()
		{
			return new OrbOrbiterBasicWeapon();
		}
	}
}
