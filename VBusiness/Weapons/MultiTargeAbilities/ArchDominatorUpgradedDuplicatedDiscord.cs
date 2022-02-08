namespace VBusiness.Weapons
{
	class ArchDominatorUpgradedDuplicatedDiscord : MultiAttackAbilityWeapon
	{
		protected override double Duration => 10;

		protected override double TargetsHit => 14;

		protected override double AbilityCooldown => 20;

		protected override double ProcChance => 60;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new ArchDominatorUpgradedBasicWeapon();
		}
	}
}
