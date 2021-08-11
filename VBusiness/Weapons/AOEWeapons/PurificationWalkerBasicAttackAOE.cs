using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	class PurificationWalkerBasicAttackAOE : BasicAOEAttackWeapon
	{
		// burn ground dealing 10-110 damage every 0.5 seconds for 5 seconds  (0-100 atk ups)
		public override double AOERadius => throw new System.NotImplementedException();
		public override double AttackCount => 80; // 2 beams, aoe hits 4 enemies each, damages 10 times over 5s

		public override double AOEDamagePercent => throw new System.NotImplementedException();
		protected override double GetWeaponDamage(VLoadout loadout)
		{
			return 10 + 0.5 * loadout.Upgrades.AttackUpgrade;
		}

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new PurificationWalkerBasicWeapon();
		}
	}
}
