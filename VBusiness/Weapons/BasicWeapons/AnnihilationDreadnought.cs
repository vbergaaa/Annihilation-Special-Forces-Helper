namespace VBusiness.Weapons
{
	public class AnnihilationDreadnoughtBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 40;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 2.5;
	}
}
