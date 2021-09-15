namespace VBusiness.Weapons
{
	public class TemplarStorm : DamagePerSecondAbility
	{
		// deal 70-840 damage
		// dur: 4
		// cd: 8
		public override double AttackIncrement => 7.7;

		public override double ArmorPenetration => 40;

		protected override double Radius => 2;

		protected override double AbilityDamage => 70;

		protected override double AbilityCooldown => 8;
	}
}
