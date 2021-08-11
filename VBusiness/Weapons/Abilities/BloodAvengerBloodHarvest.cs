namespace VBusiness.Weapons
{
	class BloodAvengerBloodHarvest : BasicAbilityWeapon
	{
		// deal 30-330 damage radius 2
		// CD: 8
		public override double AttackIncrement => 1;

		protected override double AbilityDamage => 30;

		protected override double AbilityCooldown => 8;

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(2);
	}
}
