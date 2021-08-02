namespace VBusiness.Weapons
{
	public class DreadnoughtBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 2;

		public override double AttackIncrement => 1.5;
	}
}
