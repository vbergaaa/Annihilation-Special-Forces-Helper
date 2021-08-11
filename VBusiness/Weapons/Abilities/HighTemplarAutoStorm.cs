namespace VBusiness.Weapons
{
	class HighTemplarAutoStorm : HighTemplarStorm
	{
		// 5% to autostorm on dealing damage
		// 1.5s cd

		protected override double AbilityCooldown => 2; // cooldown is 1.5, but there is some delay for the second proc
		protected override double Radius => base.Radius * 0.5; // because this is autocast, let's assume it hits less enemies
	}
}
