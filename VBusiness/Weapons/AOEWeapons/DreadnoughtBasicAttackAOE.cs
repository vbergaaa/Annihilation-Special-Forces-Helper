using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	class DreadnoughtBasicAttackAOE : BasicAOEAttackWeapon
	{
		// deal 12-92 damage radius 1
		public override double AOERadius => 1;

		public override double AOEDamagePercent => throw new System.NotImplementedException();

		protected override double GetWeaponDamage(VLoadout loadout)
		{
			return 12 + 0.8 * loadout.Upgrades.AttackUpgrade;
		}

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new DreadnoughtBasicWeapon();
		}
	}
}
