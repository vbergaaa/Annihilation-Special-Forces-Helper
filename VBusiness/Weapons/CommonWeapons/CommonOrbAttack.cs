using System;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class CommonOrbAttack : BasicAttackWeapon
	{
		public abstract int OrbTravelDuration { get; }
		public abstract int OrbsPerAttack { get; }

		// look, this is really like 6. But it's not fair to other units that the orb family can attack 26k units with each ability, and it's certainly not realistic in game.
		// so, we scale this down to 2, which can still hit 2k units, which is still stupidly high, but in theory, if that many units existed this would hit them all, so it gets
		// the point accross that this unit family can do insane AOE damage
		protected static int RadiusOfOrbAttacks => 2;

		// orbs attack once per second without ups. It scales with attack speed upgrades, but not attack speed stats.
		// 
		// orbs can hit all units in a radius of 6, but it requires you to have vision of the target. 
		// Because we likely won't have vision of all enemies in radius 6 from the orb, 
		// this has been scaled to a radius of 4 to attempt to mimic that
		protected override double GetAttackCount(VLoadout loadout)
		{
			var orbAtkSpeed = 1.0 * Math.Pow(0.96, loadout.Upgrades.AttackSpeedUpgrade);
			var zapsPerOrb = OrbTravelDuration / orbAtkSpeed;
			return zapsPerOrb * OrbsPerAttack * WeaponHelper.GetEnemiesInRadius(RadiusOfOrbAttacks);
		}
	}
}
