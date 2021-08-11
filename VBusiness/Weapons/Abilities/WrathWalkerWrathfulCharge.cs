namespace VBusiness.Weapons
{
	class WrathWalkerWrathfulCharge : BasicAbilityWeapon
	{
		// dash to an area and deal 40-440 damage to all units in the way (0-100 atk ups)
		// CD:10
		public override double AttackIncrement => 4;

		protected override double AbilityDamage => 40;

		protected override double AbilityCooldown => 10;

		public override double AttackCount => 8; // probably 2x4 area
	}
}
