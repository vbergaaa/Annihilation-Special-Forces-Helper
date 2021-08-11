namespace VBusiness.Weapons
{
	class DisruptorPurificationNova : BasicAbilityWeapon
	{
		// deal 150-550 damage after a delay  (0-100 atk ups)
		// CD: 20
		public override double AttackIncrement => 4;

		protected override double AbilityDamage => 150;

		protected override double AbilityCooldown => 20;

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(2); // guestimate
	}
}
