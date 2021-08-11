namespace VBusiness.Weapons
{
	class ReaverUnstableScarab : BasicAbilityWeapon
	{
		// CD 15;
		// deal 50-350 damage radius 4 (0-100 atk ups)
		public override double AttackIncrement => 3;

		protected override double AbilityDamage => 50;

		protected override double AbilityCooldown => 15;

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(4);
	}
}
