namespace VBusiness.Weapons
{
	class WarpLordWarpAnnihilation : BasicAbilityWeapon
	{
		// deal 15-215 damage
		// cd: 15
		public override double AttackIncrement => 2;

		protected override double AbilityDamage => 15;

		protected override double AbilityCooldown => 15;

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(5); // guestimate
	}
}
