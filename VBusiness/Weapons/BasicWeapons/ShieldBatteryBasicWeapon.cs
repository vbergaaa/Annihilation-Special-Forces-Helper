namespace VBusiness.Weapons
{
	public class ShieldBatteryBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => -5;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackIncrement => -0.25;
	}
}
