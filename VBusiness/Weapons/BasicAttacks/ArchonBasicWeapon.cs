namespace VBusiness.Weapons
{
	public class ArchonBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 1.3;
	}
}
