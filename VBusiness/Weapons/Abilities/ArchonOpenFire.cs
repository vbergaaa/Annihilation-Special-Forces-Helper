namespace VBusiness.Weapons
{
	public class ArchonOpenFire : OpenFireAbility
	{
		// passive: damaged enemies are marked for 3s
		// active: atk all marked enemies with basic atk
		protected override BasicAOEAttackWeapon GetNewAOEWeapon() => new ArchonBasicAttackAOE();

		protected override BasicAttackWeapon GetNewBaseWeapon() => new ArchonBasicWeapon();

		protected override BasicAbilityWeapon GetNewStormWeapon() => new TemplarStorm();
	}
}
