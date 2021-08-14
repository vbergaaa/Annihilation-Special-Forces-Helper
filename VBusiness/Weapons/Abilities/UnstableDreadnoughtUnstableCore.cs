namespace VBusiness.Weapons
{
	public class UnstableDreadnoughtUnstableCore : BasicAbilityWeapon
	{
		// 5% chance to explode on hit
		// 20-220 damage in a radius of 3  (0-100 atk ups)
		// CD: 1
		public override double AttackIncrement => 2;

		protected override double AbilityDamage => 20;

		protected override double AbilityCooldown => 1.25; // give 0.25 sec to proc on average

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(3);
	}
}
