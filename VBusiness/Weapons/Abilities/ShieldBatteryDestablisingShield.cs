namespace VBusiness.Weapons
{
	public class ShieldBatteryDestablisingShield : DamagePerSecondAbility
	{
		// 6-66 damage ?/s or total 
		// duration 3
		// cd: 10
		public override double AttackIncrement => 0.6;

		protected override double Radius => 6; //guessimate

		protected override double AbilityDamage => 6;

		protected override double AbilityCooldown => 10;
	}
}
