namespace VBusiness.Weapons
{
	class AnnihilationDreadnoughtAnnihilationCore : BasicAbilityWeapon
	{
		// 10% chance on getting hit
		// .75 cd
		// deal 20-220 damage radius 3, heal for 5% shields
		public override double AttackIncrement => 2;

		protected override double AbilityDamage => 20;

		protected override double AbilityCooldown => 1; // give 0.25 sec to proc on average

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(3);
	}
}
