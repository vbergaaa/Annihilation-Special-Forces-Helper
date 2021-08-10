namespace VBusiness.Weapons
{
	public class WarpLordBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 11;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackCount => 2;

		public override double AttackIncrement => 0.6;
	}
}
