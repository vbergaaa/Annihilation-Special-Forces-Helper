namespace VBusiness.Weapons
{
	public class UnstableDreadnoughtBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 30;

		public override double BaseAttackPeriod => 1.7;

		public override double AttackIncrement => 2;
	}
}
