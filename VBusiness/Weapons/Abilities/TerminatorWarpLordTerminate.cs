namespace VBusiness.Weapons
{
	class TerminatorWarpLordTerminate : BasicAbilityWeapon
	{
		// blink to and attack an enemy 20 times
		// cd: 50

		public TerminatorWarpLordTerminate()
		{
			BaseWeapon = new TerminatorWarpLordBasicWeapon();
		}
		public override double AttackIncrement => BaseWeapon.AttackIncrement * 20;

		protected override double AbilityDamage => BaseWeapon.BaseAttack * 20;

		protected override double AbilityCooldown => 50;

		protected BasicAttackWeapon BaseWeapon { get; }
	}
}
