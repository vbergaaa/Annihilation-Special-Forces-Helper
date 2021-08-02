namespace VBusiness.Weapons
{
	public class ReaverBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 2;

		public override double AttackIncrement => 2;
	}
}
