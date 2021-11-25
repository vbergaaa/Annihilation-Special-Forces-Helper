namespace VBusiness.Weapons
{
	public class ArchonOpenFire : OpenFireAbility
	{
		// passive: damaged enemies are marked for 3s
		// active: atk all marked enemies with basic atk
		protected override BasicAOEAttackWeapon GetNewAOEWeapon()
		{
			return new ArchonBasicAttackAOE();
		}

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new ArchonBasicWeapon();
		}

		protected override BasicAbilityWeapon GetNewStormWeapon()
		{
			return new TemplarStorm();
		}
	}
}
