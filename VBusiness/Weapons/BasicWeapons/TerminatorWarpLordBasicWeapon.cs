namespace VBusiness.Weapons
{
	public class TerminatorWarpLordBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 30;

		public override double BaseAttackPeriod => 0.8;

		public override double AttackIncrement => 2.2;
	}
}
