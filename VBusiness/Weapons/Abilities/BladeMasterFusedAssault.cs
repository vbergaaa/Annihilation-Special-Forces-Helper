using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class BladeMasterFusedAssault : BasicAbilityWeapon
	{
		// this attack combines the power of 20 bm blades into 5, on a 15 second cooldown
		public override double AttackCount => 5;

		public override double AttackIncrement => 6; // 4x 1.5

		protected override double AbilityDamage => 60; // 4x 15

		public override double ArmorPenetration => 35;

		protected override double AbilityCooldown => 15;

		public override double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy, ICritChances crits)
		{
			return base.GetDamageToEnemy(loadout, enemy, crits);
		}
	}
}
