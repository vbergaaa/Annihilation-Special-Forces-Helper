namespace VBusiness.Weapons
{
	public class BladeMasterBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 15;

		public override double BaseAttackPeriod => 2.3;

		public override double AttackCount => 20;

		public override double AttackIncrement => 1.5;

		public override double ArmorPenetration => 35;
	}
}
