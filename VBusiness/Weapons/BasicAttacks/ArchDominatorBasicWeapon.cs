namespace VBusiness.Weapons
{
	public class ArchDominatorBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 60;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 3.5;
	}
}
