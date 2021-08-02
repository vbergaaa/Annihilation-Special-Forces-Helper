namespace VBusiness.Weapons
{
	public class DarkShadowBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 20;

		public override double BaseAttackPeriod => 1;

		public override double AttackIncrement => 1.5;
	}
}
