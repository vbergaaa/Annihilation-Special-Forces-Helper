namespace VBusiness.Weapons
{
	class OrbOrbiterBasicWeapon : CommonOrbAttack
	{
		public override double BaseAttack => 20;

		public override double BaseAttackPeriod => 3.75;

		public override double AttackIncrement => 1.8;

		public override int OrbTravelDuration => 3;

		public override int OrbsPerAttack => 2;
	}
}
