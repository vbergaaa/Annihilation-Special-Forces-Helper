namespace VBusiness.Weapons
{
	class DisruptorDisplacementNova : BasicAbilityWeapon
	{
		// deal 60-360 damage to an area (0-100 atk ups)
		// CD: 12
		public override double AttackIncrement => 3;

		protected override double AbilityDamage => 60;

		protected override double AbilityCooldown => 12;

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(2); // guestimate
	}
}
