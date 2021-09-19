using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class CommonOrbAbility : CommonOrbAttack
	{
		protected abstract CommonOrbAttack GetBasicOrbWeapon();
		protected CommonOrbAttack BasicOrbWeapon => fBasicOrbWeapon ??= GetBasicOrbWeapon();
		CommonOrbAttack fBasicOrbWeapon;

		public override double BaseAttack => BasicOrbWeapon.BaseAttack;

		public override double BaseAttackPeriod => AbilityCooldown;
		protected abstract double AbilityCooldown { get; }

		public override double AttackIncrement => BasicOrbWeapon.AttackIncrement;

		protected internal override double GetActualWeaponPeriod(VLoadout loadout)
		{
			return AbilityCooldown / (loadout.Stats.CooldownSpeed / 100);
		}
	}
}
