using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VUnitRank
	{
		#region Constructor 

		public VUnitRank(VUnitConfiguration config)
		{
			UnitConfiguration = config;
		}

		#endregion

		#region Properties

		#region Unit Configuration

		[VXML(false)]
		public VUnitConfiguration UnitConfiguration { get; private set; }

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

		public static UnitRank GetUnitRankFromString(string rank)
		{
			return rank switch
			{
				("D") => UnitRank.D,
				("C") => UnitRank.C,
				("B") => UnitRank.B,
				("A") => UnitRank.A,
				("S") => UnitRank.S,
				("SD") => UnitRank.SD,
				("SC") => UnitRank.SC,
				("SB") => UnitRank.SB,
				("SA") => UnitRank.SA,
				("SS") => UnitRank.SS,
				("SSD") => UnitRank.SSD,
				("SSC") => UnitRank.SSC,
				("SSB") => UnitRank.SSB,
				("SSA") => UnitRank.SSA,
				("SSS") => UnitRank.SSS,
				("X") => UnitRank.X,
				("SX") => UnitRank.SX,
				("SSX") => UnitRank.SSX,
				("SSSX") => UnitRank.SSSX,
				("XX") => UnitRank.XX,
				("XD") => UnitRank.XD,
				("SXD") => UnitRank.SXD,
				("Z") => UnitRank.Z,
				("SZ") => UnitRank.SZ,
				("SSZ") => UnitRank.SSZ,
				("SSSZ") => UnitRank.SSSZ,
				("XZ") => UnitRank.XZ,
				("XDZ") => UnitRank.XDZ,
				("SXDZ") => UnitRank.SXDZ,
				("XYZ ") => UnitRank.XYZ,
				_ => UnitRank.None
			};
		}
	}
}