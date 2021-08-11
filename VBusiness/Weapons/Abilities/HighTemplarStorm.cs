namespace VBusiness.Weapons
{
	class HighTemplarStorm : DamagePerSecondAbility
	{
		// deal 140-1050-1814 damage to all units (0-100 atk ups)
		// dur: 4
		// cd: 6
		public override double AttackIncrement => 9.1;

		public override double ArmorPenetration => 60;

		protected override double Radius => 3;

		protected override double AbilityDamage => 140;

		protected override double AbilityCooldown => 6;
	}
}
