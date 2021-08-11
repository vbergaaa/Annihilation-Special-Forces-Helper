namespace VBusiness.Weapons
{
	class DarkStrikerGreaterMulti : MultiAttackAbilityWeapon
	{
		// cd 25
		// dur: 10
		// targets 8
		protected override double Duration => 10;

		protected override double TargetsHit => 8;

		protected override double AbilityCooldown => 25;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new DarkStrikerBasicWeapon();
		}
	}
}
