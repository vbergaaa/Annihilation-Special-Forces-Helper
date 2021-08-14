using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class EmptyWeapon : IWeaponData
	{
		public double AttackCount => 0;

		public double AttackIncrement => 0;

		public double AttackPeriodIncrement => 0;

		public double BaseAttack => 0;

		public double BaseAttackPeriod => 1;

		public double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy) => 0;
	}
}
