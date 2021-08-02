namespace VBusiness.Weapons
{
	public class BerserkerWarpLordBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 16;

		public override double BaseAttackPeriod => 1;

		public override double AttackCount => 2;

		public override double AttackIncrement => 1.2;
	}
}
