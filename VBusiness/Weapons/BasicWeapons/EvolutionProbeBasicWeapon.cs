namespace VBusiness.Weapons
{
	public class EvolutionProbeBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 22;

		public override double BaseAttackPeriod => 1;

		public override double AttackIncrement => 1.2;
	}
}
