namespace VBusiness.Weapons
{
	public class OmniBladerUnboundAssault : BasicAbilityWeapon
	{
		// channel 40 blades into 1
		// blink to location
		// cast an additional 13 blades
		// deal 65-465 damage in 5 radius  (0-100 atk ups)
		// CD: 15
		public override double AttackIncrement => 3;

		protected override double AbilityDamage => 65;

		protected override double AbilityCooldown => 15;

		public override double AttackCount => 5 * WeaponHelper.GetEnemiesInRadius(5);

		public override double ArmorPenetration => 40;
	}
}
