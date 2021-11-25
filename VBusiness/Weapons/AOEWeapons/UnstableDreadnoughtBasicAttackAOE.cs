using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	class UnstableDreadnoughtBasicAttackAOE : BasicAOEAttackWeapon
	{
		// deal 15-135 damage in a radius of 1.25
		public override double AOERadius => 1.25;

		public override double AOEDamagePercent => throw new System.NotImplementedException();

		protected override double GetWeaponDamage(VLoadout loadout)
		{
			return 15 + 1.2 * loadout.Upgrades.AttackUpgrade;
		}

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new UnstableDreadnoughtBasicWeapon();
		}
	}
}
