namespace VBusiness.Weapons
{
	public class DarkProbeBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 12;

		public override double BaseAttackPeriod => 1.3;

		public override double AttackIncrement => 0.8;
	}
}
