namespace VBusiness.Weapons
{
	class DarkArchonOpenFire : OpenFireAbility
	{
		// exactly the same as CrismonArchonOpenFire.cs (but, a different attack behind the scenes
		// actual name: Dark Open Fire
		protected override BasicAOEAttackWeapon GetNewAOEWeapon()
		{
			return new DarkArchonBasicAttackAOE();
		}

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new DarkArchonBasicWeapon();
		}

		protected override BasicAbilityWeapon GetNewStormWeapon()
		{
			return new TemplarStorm();
		}
	}
}
