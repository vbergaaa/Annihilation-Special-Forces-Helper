using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class EmptyWeapon : IWeaponData
	{
		public static double AttackCount => 0;

		public double AttackIncrement => 0;

		public static double AttackPeriodIncrement => 0;

		public double BaseAttack => 0;

		public double BaseAttackPeriod => 0;

		public double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy)
		{
			return 0;
		}
	}
}
