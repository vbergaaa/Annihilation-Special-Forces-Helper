using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VUnitRank
	{
		public abstract void ActivateRank();
		public abstract void DeactivateRank();

		#region Properties

		public abstract VLoadout Loadout { get; set; }

		#endregion

		#region Stats

		public abstract UnitRankType Rank { get; }
		public abstract double DamageIncrease { get; }
		public abstract double DamageReduction { get; }
		public abstract double Attack { get; }
		public abstract double AttackSpeed { get; }
		public abstract double Vitals { get; }
		public abstract double Armor { get; }
		public abstract double Speed { get; }

		#endregion
	}
}