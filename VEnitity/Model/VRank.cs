using System;

namespace VEntityFramework.Model
{
	public abstract class VRank
	{
		public abstract Action<VStats> ActivateRank { get; }
		public abstract Action<VStats> DeactivateRank { get; }


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

		#region Buffs

		public abstract Action<VStats> ActivateMegaBuff { get; }
		public abstract Action<VStats> ActivateSuperMegaBuff { get; }
		public abstract Action<VStats> ActivateGodBuff { get; }
		public abstract Action<VStats> ActivateSuperGodBuff { get; }
		public abstract Action<VStats> ActivateDivineBuff { get; }
		public abstract Action<VStats> ActivateSuperDivineBuff { get; }
		public abstract Action<VStats> ActivateOmegaBuff { get; }
		public abstract Action<VStats> ActivateSuperOmegaBuff { get; }
		public abstract Action<VStats> ActivateQuasarBuff { get; }
		public abstract Action<VStats> ActivateVoidBuff { get; }
		public abstract Action<VStats> DeactivateMegaBuff { get; }
		public abstract Action<VStats> DeactivateSuperMegaBuff { get; }
		public abstract Action<VStats> DeactivateGodBuff { get; }
		public abstract Action<VStats> DeactivateSuperGodBuff { get; }
		public abstract Action<VStats> DeactivateDivineBuff { get; }
		public abstract Action<VStats> DeactivateSuperDivineBuff { get; }
		public abstract Action<VStats> DeactivateOmegaBuff { get; }
		public abstract Action<VStats> DeactivateSuperOmegaBuff { get; }
		public abstract Action<VStats> DeactivateQuasarBuff { get; }
		public abstract Action<VStats> DeactivateVoidBuff { get; }

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