namespace VBusiness.Weapons
{
	class GalaxianOrbiterBasicWeapon : CommonOrbAttack
	{
		public override double BaseAttack => 30;

		public override double BaseAttackPeriod => 3.5;

		public override double AttackIncrement => 2.5;

		// duration looks to be 11, but half that is orbited behind it's head, so shouldn't attack anything, so scaling it to 6 seconds of effective attacking
		public override int OrbTravelDuration => 6;

		public override int OrbsPerAttack => 4;
	}
}
