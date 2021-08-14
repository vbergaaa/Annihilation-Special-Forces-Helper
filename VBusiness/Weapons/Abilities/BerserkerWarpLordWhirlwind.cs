namespace VBusiness.Weapons
{
	class BerserkerWarpLordWhirlwind : DamagePerSecondAbility
	{
		// deal 10 - 110 - 203 damage per second to nearby units
		// dur: 3
		// cd: 10
		public override double AttackIncrement => 1;

		protected override double Radius => 2.5; // this might only be 2, but because it lasts 3 secs it hits more units so it's inflated 

		protected override double AbilityDamage => 10;

		protected override double AbilityCooldown => 10;
	}
}
