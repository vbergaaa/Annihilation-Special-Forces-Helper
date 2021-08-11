namespace VBusiness.Weapons
{
	class WrathwalkerTaldarimBeam : BasicAbilityWeapon
	{
		// deals 40-440 damage to all enemies in a line (0-100 atk ups)
		// CD:10
		public override double AttackIncrement => 4;

		protected override double AbilityDamage => 40;

		protected override double AbilityCooldown => 10;

		public override double AttackCount => 20; // it's a pretty big zone, probably 2x10 area
	}
}
