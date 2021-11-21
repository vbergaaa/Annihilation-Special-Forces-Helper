namespace VBusiness.Weapons
{
	class DarkArchonOpenFire : OpenFireAbility
	{
		// exactly the same as CrismonArchonOpenFire.cs (but, a different attack behind the scenes
		// actual name: Dark Open Fire
		protected override BasicAOEAttackWeapon GetNewAOEWeapon() => new DarkArchonBasicAttackAOE();

		protected override BasicAttackWeapon GetNewBaseWeapon() => new DarkArchonBasicWeapon();

		protected override BasicAbilityWeapon GetNewStormWeapon() => new TemplarStorm();
	}
}
