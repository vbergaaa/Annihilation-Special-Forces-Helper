namespace VBusiness.Weapons
{
	public class ParadoxStrikerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 36;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackCount => 7; // Multishot 7, GreaterMultishot: ?

		public override double AttackIncrement => 2;
	}
}
