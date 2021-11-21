namespace VBusiness.Weapons
{
	class DominatorMultipliedDiscord : MultiAttackAbilityWeapon
	{
		//35% chance to hit 7 addititional targets
		//dur: 10
		//cd: 20
		protected override double Duration => 10;

		protected override double TargetsHit => 8;

		protected override double AbilityCooldown => 20;

		protected override double ProcChance => 35;

		protected override BasicAttackWeapon GetBaseWeapon() => new DominatorBasicWeapon();
	}
}
