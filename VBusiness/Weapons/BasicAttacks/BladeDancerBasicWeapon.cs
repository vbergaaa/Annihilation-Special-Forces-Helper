namespace VBusiness.Weapons
{
	public class BladeDancerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 10;

		public override double BaseAttackPeriod => 3.5;

		public override double AttackCount => 10 * WeaponHelper.GetEnemiesInRadius(3);

		public override double AttackIncrement => 1;

		public override double ArmorPenetration => 30;
	}
}
