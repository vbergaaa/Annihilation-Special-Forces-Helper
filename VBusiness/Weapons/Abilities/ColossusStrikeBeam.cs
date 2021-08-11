namespace VBusiness.Weapons
{
	class ColossusStrikeBeam : DamagePerSecondAbility
	{
		// deal 120-920-1699 over 10 seconds (0-100 atk ups, 0-15 as ups)
		// cd: 30
		public override double AttackIncrement => 8;

		protected override double Radius => 4; // guessimate

		protected override double AbilityDamage => 120;

		protected override double AbilityCooldown => 30;
	}
}
