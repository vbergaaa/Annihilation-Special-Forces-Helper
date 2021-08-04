using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class BasicAbilityWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => AbilityDamage;
		protected abstract double AbilityDamage { get; }

		public override double BaseAttackPeriod => AbilityCooldown;
		protected abstract double AbilityCooldown { get; }

		public abstract override double AttackIncrement { get; }

		protected override double GetActualWeaponPeriod(VLoadout loadout)
		{
			return BaseAttackPeriod / (loadout.Stats.CooldownSpeed / 100);
		}
	}
}
