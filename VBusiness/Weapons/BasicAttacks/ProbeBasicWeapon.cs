namespace VBusiness.Weapons
{
	public class ProbeBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 5;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackIncrement => 0.5;
	}
}
