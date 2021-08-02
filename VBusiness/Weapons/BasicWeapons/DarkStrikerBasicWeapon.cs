namespace VBusiness.Weapons
{
	public class DarkStrikerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 22;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackCount => 3;

		public override double AttackIncrement => 1.25;
	}
}
