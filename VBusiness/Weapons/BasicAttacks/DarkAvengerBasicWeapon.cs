namespace VBusiness.Weapons
{
	public class DarkAvengerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 30;

		public override double BaseAttackPeriod => 0.9;

		public override double AttackIncrement => 2;
	}
}
