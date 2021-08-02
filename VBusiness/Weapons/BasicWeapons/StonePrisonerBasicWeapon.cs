namespace VBusiness.Weapons
{
	public class StonePrisonerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 1.25;

		public override double AttackIncrement => 1.8;
	}
}
