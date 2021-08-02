namespace VBusiness.Weapons
{
	public class DarkShieldBatteryBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => -7;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => -0.35;
	}
}
