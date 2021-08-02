namespace VBusiness.Weapons
{
	public class WrathWalkerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 35;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackCount => 3;

		public override double AttackIncrement => 2;
	}
}
