namespace VBusiness.Weapons
{
	public class BladeDancerCombinatedAssault : BasicAbilityWeapon
	{
		// 10 blades into 1
		// deals 25-225 damage  (0-100 atk ups)
		// cd: 15
		public override double AttackIncrement => 2;

		protected override double AbilityDamage => 25;

		protected override double AbilityCooldown => 15;

		public override double AttackCount => 5 * WeaponHelper.GetEnemiesInRadius(5);

		public override double ArmorPenetration => 30;
	}
}
