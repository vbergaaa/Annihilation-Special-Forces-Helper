namespace VBusiness.Weapons
{
	class PurificationWalkerPurificationBeam : DamagePerSecondAbility
	{
		// deal 257-1971-3642 damage over 15 seconds (0-100 atk ups, 0-15 as ups)
		// CD: 20
		public override double AttackIncrement => 17.14;

		protected override double Radius => 4; // guestimate

		protected override double AbilityDamage => 257;

		protected override double AbilityCooldown => 20;
	}
}
