namespace VBusiness.Weapons
{
	public class StrikerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 15;

		public override double AttackCount => 2;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackIncrement => 1;
	}
}
