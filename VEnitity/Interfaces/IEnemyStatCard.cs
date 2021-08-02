using VEntityFramework.Model;

namespace VEntityFramework.Interfaces
{
	public interface IEnemyStatCard
	{
		public EnemyType Type { get; set; }
		public bool IsTitan { get; set; }
		public double Damage { get; set; }
		public double Armor { get; set; }
		public double DamageIncrease { get; set; }
		public double DamageReduction { get; set; }
	}
}