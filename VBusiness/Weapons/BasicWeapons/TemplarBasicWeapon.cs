namespace VBusiness.Weapons
{
	public class TemplarBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 20;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackIncrement => 1;
	}
}
