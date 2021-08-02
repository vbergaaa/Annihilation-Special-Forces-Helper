namespace VBusiness.Weapons
{
	public class MirrorStrikerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 28;

		public override double AttackCount => 5; // Multishot = 5, Greater Multishot = 11?

		public override double BaseAttackPeriod => 1.3;

		public override double AttackIncrement => 1.6;
	}
}
