namespace VBusiness.Weapons
{
	public class BladeMasterFusedAssault : BasicAbilityWeapon
	{
		// this attack combines the power of 20 bm blades into 5, on a 15 second cooldown
		// deals 30-330 in a radius of 5
		public override double AttackCount => 5 * WeaponHelper.GetEnemiesInRadius(5); // ticks 5 times

		public override double AttackIncrement => 2.25;

		protected override double AbilityDamage => 40;

		public override double ArmorPenetration => 35;

		protected override double AbilityCooldown => 15;
	}
}
