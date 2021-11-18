namespace VBusiness.Weapons
{
	class ColossusSplitBeam : MultiAttackAbilityWeapon
	{
		// atk 4 enemies at once
		// I have no data here so I'm assuming the duration for this is 5 seconds
		// cd: 10

		protected override double AbilityCooldown => 10;

		protected override double Duration => 5;

		protected override double TargetsHit => BaseWeapon.AttackCount * 2; // original beam sends two beams, this sends 4

		protected override BasicAttackWeapon GetBaseWeapon()
		{
			return new ColossusBasicWeapon();
		}
	}
}
