namespace VBusiness.Weapons
{
	class DominatorUpgradedBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 50;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackIncrement => 2.5;

		public override double AttackCount => 3;
	}
}
