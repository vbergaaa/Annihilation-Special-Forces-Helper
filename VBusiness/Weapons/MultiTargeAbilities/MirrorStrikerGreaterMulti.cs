namespace VBusiness.Weapons
{
	class MirrorStrikerGreaterMulti : MultiAttackAbilityWeapon
	{
		// targets 11;
		// cd: 25
		// dur: 10
		protected override double Duration => 25;

		protected override double TargetsHit => 11;

		protected override double AbilityCooldown => 25;

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new MirrorStrikerBasicWeapon();
		}
	}
}
