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
	}

	public enum UnitRank
	{
		None,
		D,
		C,
		B,
		A,
		S,
		SD,
		SC,
		SB,
		SA,
		SS,
		SSD,
		SSC,
		SSB,
		SSA,
		SSS,
		X,
		SX,
		SSX,
		SSSX,
		XX,
		XD,
		SXD,
		Z,
		SZ,
		SSZ,
		SSSZ,
		XZ,
		XDZ,
		SXDZ,
		XYZ
	}
}