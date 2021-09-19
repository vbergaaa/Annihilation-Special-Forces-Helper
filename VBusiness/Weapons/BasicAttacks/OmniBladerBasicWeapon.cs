namespace VBusiness.Weapons
{
	public class OmniBladerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 3;

		public override double AttackCount => 52 * WeaponHelper.GetEnemiesInRadius(3);

		public override double AttackIncrement => 2;

		public override double ArmorPenetration => 40;
	}
}
