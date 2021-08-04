using VEntityFramework.Interfaces;

namespace VEntityFramework.Model
{
	public interface IWeaponData
	{
		double AttackIncrement { get; }
		double BaseAttack { get; }
		double BaseAttackPeriod { get; }
		double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy, ICritChances crits);
	}
}
