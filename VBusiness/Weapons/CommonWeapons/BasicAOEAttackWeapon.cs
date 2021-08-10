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

		public override double AttackCount => GetEnemiesInRadius() * BasicWeapon.AttackCount;

		protected override double GetWeaponDamage(VLoadout loadout)
		{
			return base.GetWeaponDamage(loadout) * AOEDamagePercent / 100;
		}

		double GetEnemiesInRadius()
		{
			// it's assumed throughout this app for damage calculationsthat there can be 4 enemies in a 1 radius block
			// therefore, in a 2 radius block, there can be 16, and a 3 radius block there can be 36

			return 4 * AOERadius * AOERadius;
		}
	}
}
