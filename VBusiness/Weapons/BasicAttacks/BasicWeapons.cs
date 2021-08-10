namespace VBusiness.Weapons
{
	public class SplitterAdeptBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 45;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackIncrement => 1.8;
	}
}
