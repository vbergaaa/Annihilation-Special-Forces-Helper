namespace VBusiness.Weapons
{
	public class BloodAvengerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 40;

		public override double BaseAttackPeriod => 0.8;

		public override double AttackIncrement => 2.5;
	}
}
