namespace VBusiness.Weapons
{
	class ParadoxStrikerGreaterMulti : MultiAttackAbilityWeapon
	{
		// cd:25,
		// dur: 10;
		// targets: 15
		protected override double Duration => 10;

		protected override double TargetsHit => 90; // multishot = 15, but passive effect splits all attacks into 5 more, so 15 + 75

		protected override double AbilityCooldown => 25;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new ParadoxStrikerBasicWeapon();
		}
	}
}
