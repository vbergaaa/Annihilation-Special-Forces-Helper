namespace VBusiness.Weapons
{
	public class CrimsonArchonOpenFire : OpenFireAbility
	{
		// passive: enemies damaged are marked for 3 seconds
		// active: attack all marked enemies with basic attack
		// gain 1 armor for 5 second for each enemy hit
		// CD: 20
		protected override BasicAOEAttackWeapon GetNewAOEWeapon()
		{
			return new CrimsonArchonBasicAttackAOE();
		}

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new CrimsonArchonBasicWeapon();
		}

		protected override BasicAbilityWeapon GetNewStormWeapon()
		{
			return new HighTemplarStorm();
		}
	}
}
