namespace VBusiness.Weapons
{
	class AnnihilationDreadnoughtAnnihilationCannon : BasicAbilityWeapon
	{
		// deal 200-1800 damage to a target unit  (0-100 atk ups)
		// cd 15
		public override double AttackIncrement => 16;

		protected override double AbilityDamage => 200;

		protected override double AbilityCooldown => 15;
	}
}
