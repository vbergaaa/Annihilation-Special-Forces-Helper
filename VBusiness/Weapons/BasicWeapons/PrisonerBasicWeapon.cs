namespace VBusiness.Weapons
{
	public class PrisonerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 15;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackCount => 2;

		public override double AttackIncrement => 1.5;
	}
}
