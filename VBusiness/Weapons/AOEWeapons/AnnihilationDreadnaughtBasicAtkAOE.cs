using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	class AnnihilationDreadnaughtBasicAtkAOE : BasicAOEAttackWeapon
	{
		// deal 20-170 damage in a radius of 1.5
		public override double AOERadius => 1.5;

		public override double AOEDamagePercent => throw new System.NotImplementedException();

		protected override double GetWeaponDamage(VLoadout loadout)
		{
			return 20 + 1.5 * loadout.Upgrades.AttackUpgrade;
		}

		protected override BasicAttackWeapon GetNewBaseWeapon() => new AnnihilationDreadnoughtBasicWeapon();
	}
}
