namespace VBusiness.Weapons
{
	public class DarkWarpLordBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 15;

		public override double AttackCount => 2;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackIncrement => 0.8;
	}
}
