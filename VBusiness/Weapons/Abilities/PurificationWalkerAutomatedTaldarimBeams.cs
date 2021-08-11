namespace VBusiness.Weapons
{
	class PurificationWalkerAutomatedTaldarimBeams : WrathwalkerTaldarimBeam
	{
		// 5% chance to cast a taldarim beam on dealing damage
		// as a guess, assuming we fire one of these every 2 seconds

		protected override double AbilityCooldown => 2;
	}
}
