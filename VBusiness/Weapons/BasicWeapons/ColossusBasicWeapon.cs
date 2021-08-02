namespace VBusiness.Weapons
{
	public class ColossusBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 20;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackCount => 2;

		public override double AttackIncrement => 2.2;
	}
}
