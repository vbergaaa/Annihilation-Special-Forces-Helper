namespace VBusiness.Weapons
{
	public class AscendantMindBlast : BasicAbilityWeapon
	{
		// deals 50-400 damage to a unit (0-100 atk ups)
		// cd: 20
		public override double AttackIncrement => 3.5;

		protected override double AbilityDamage => 50;

		protected override double AbilityCooldown => 20;
	}
}
