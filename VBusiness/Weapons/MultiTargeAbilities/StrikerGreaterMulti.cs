namespace VBusiness.Weapons
{
	class StrikerGreaterMulti : MultiAttackAbilityWeapon
	{
		// hits 6 
		// cd: 25
		// dur: 10
		protected override double Duration => 10;

		protected override double TargetsHit => 6;

		protected override double AbilityCooldown => 25;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new StrikerBasicWeapon();
		}
	}
}
