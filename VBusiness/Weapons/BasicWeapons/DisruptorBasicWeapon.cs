namespace VBusiness.Weapons
{
	public class DisruptorBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 20;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 2;
	}
}
