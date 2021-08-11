namespace VBusiness.Weapons
{
	public class ParadoxStrikerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 36;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackCount => 42; // Multishot 7, passive effect - all attacks split to 5 targets, therefore 7 + 35

		public override double AttackIncrement => 2;
	}
}
