namespace VBusiness.Weapons
{
	class ArchDominatorDuplicatedDiscord : MultiAttackAbilityWeapon
	{
		// 60% chance to attack 10 extra enemies
		// DUR: 10
		// CD: 20
		protected override double Duration => 10;

		protected override double TargetsHit => 11;

		protected override double AbilityCooldown => 20;

		protected override double ProcChance => 60;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new ArchDominatorBasicWeapon();
		}
	}
}
