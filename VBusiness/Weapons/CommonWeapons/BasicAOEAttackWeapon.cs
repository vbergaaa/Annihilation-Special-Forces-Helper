using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public abstract class BasicAOEAttackWeapon : BasicAttackWeapon
	{
		public BasicAttackWeapon BasicWeapon => fBasicWeapon ??= GetNewBaseWeapon();
		BasicAttackWeapon fBasicWeapon;
		protected abstract BasicAttackWeapon GetNewBaseWeapon();
		public abstract double AOERadius { get; }
		public abstract double AOEDamagePercent { get; }

		public override double BaseAttack => BasicWeapon.BaseAttack;
		public override double BaseAttackPeriod => BasicWeapon.BaseAttackPeriod;
		public override double AttackIncrement => BasicWeapon.AttackIncrement;

		public override double AttackCount => WeaponHelper.GetEnemiesInRadius(AOERadius) * BasicWeapon.AttackCount;

		protected override double GetWeaponDamage(VLoadout loadout)
		{
			return base.GetWeaponDamage(loadout) * AOEDamagePercent / 100;
		}
	}
}
