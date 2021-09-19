namespace VBusiness.Weapons
{
	public class OrbDancerBasicWeapon : CommonOrbAttack
	{
		public override double BaseAttack => 30;

		// orbs attack every second, but orbs are released every 4 seconds
		public override double BaseAttackPeriod => 4;

		public override double AttackIncrement => 1.3;

		public override int OrbTravelDuration => 1;

		public override int OrbsPerAttack => 1;
	}
}
