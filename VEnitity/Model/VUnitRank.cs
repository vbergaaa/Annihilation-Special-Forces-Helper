using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VUnitRank
	{
		#region Constructor 

		public VUnitRank(VUnit config)
		{
			Unit = config;
		}

		#endregion

		#region Properties

		#region Unit Configuration

		[VXML(false)]
		public VUnit Unit { get; private set; }

		#endregion

		#endregion

		public abstract void ActivateRank();
		public abstract void DeactivateRank();


		#region Stats

		public abstract UnitRank Rank { get; }
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