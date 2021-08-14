using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class WingedArchonWingedPower : BasicAbilityWeapon
	{
		// cast WingedOpenFire every 3 seconds
		// DUR 20
		// CD 60
		public WingedArchonWingedPower()
		{
			WingedOpenFireWeapon = new WingedArchonWingedOpenFire();
		}

		protected override double AbilityCooldown => 60;

		public override double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy, ICritChances crits)
		{
			// this effectively gets the damage from open fire, and casts it 7 times in the cooldown time
			var damageDealtByOpenFire = WingedOpenFireWeapon.GetDamageToEnemy(loadout, enemy, crits) * WingedOpenFireWeapon.GetActualWeaponPeriod(loadout);
			damageDealtByOpenFire *= 7;
			return damageDealtByOpenFire / GetActualWeaponPeriod(loadout);
		}

		protected BasicAbilityWeapon WingedOpenFireWeapon { get; }

		protected override double AbilityDamage => throw new System.NotImplementedException();

		public override double AttackIncrement => throw new System.NotImplementedException();
	}
}
