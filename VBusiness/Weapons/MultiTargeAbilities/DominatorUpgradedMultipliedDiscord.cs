namespace VBusiness.Weapons
{
	class DominatorUpgradedMultipliedDiscord : MultiAttackAbilityWeapon
	{
		//35% chance to hit 7 addititional targets
		//dur: 10
		//cd: 20
		protected override double Duration => 10;

		protected override double TargetsHit => 13;

		protected override double AbilityCooldown => 20;

		protected override double ProcChance => 100;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new DominatorUpgradedBasicWeapon();
		}
	}
}
