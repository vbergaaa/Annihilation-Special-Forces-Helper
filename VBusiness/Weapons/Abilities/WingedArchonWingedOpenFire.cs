namespace VBusiness.Weapons
{
	public class WingedArchonWingedOpenFire : OpenFireAbility
	{
		// attacks all marked enemies with basic attack
		// enemies damaged get marked for 3 seconds
		// gain 2 armor for 5 seconds for each enemy hit
		// CD = 15;

		// How many enemies does this hit?
		// by the app's judgement, winged storm can hit up to 116 units
		// winged storm has a 40% up time with no cooldown speed.
		// however, the app thinks each attack does aoe ot 36 units (it does, 3 radius aoe on main atk)
		// that means when storm is up,  open fire damages 4176 units... 
		// ..which is impossibly high for a unit with the highest base damage in the game.
		// a typical wave wouldn't even spawn 100 units
		// I know this is arbituary, and I haven't done this in other places, 
		// but I'm going to reduce the number of targets this hits by the number of aoe targets it should hit, so it's slightly more balanced
		// this would mean when storm is up,you
		//
		// when storm isn't up, lets calculate how many attacks it makes in it's 15 second cooldown, and go from there.

		protected override double AbilityCooldown => 15;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new WingedArchonBasicWeapon();
		}

		protected override BasicAbilityWeapon GetNewStormWeapon()
		{
			return new WingedArchonWingedStorm();
		}

		protected override BasicAOEAttackWeapon GetNewAOEWeapon()
		{
			return new WingedArchonBasicAttackAOE();
		}
	}
}
