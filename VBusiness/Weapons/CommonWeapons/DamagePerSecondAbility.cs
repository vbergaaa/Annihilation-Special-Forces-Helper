using System;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class DamagePerSecondAbility : BasicAbilityWeapon
	{
		protected abstract double Radius { get; }

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(Radius);
		protected override double GetWeaponDamage(VLoadout loadout)
		{
			// here is an example string defining how the damages scale with atk speed upgrades
			// 840-871-902-934-968-1004-1041-1079-1119-1161-1204-1250-1296-1346-1397-1451.
			// I can't work out the equation that governs this, the closest relationship I saw was an exponiental increase of 1.037

			return AbilityDamage + loadout.Upgrades.AttackUpgrade * AttackIncrement * Math.Pow(1.037, loadout.Upgrades.AttackSpeedUpgrade);
		}
	}
}
