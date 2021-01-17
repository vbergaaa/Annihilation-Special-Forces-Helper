using System.Collections.Generic;

namespace VBusiness.Ranks
{
	public class RankLookup
	{
		public List<VEntityFramework.Model.UnitRank> GetRanks()
		{
			return new List<VEntityFramework.Model.UnitRank>
			{
				VEntityFramework.Model.UnitRank.None,
				VEntityFramework.Model.UnitRank.D,
				VEntityFramework.Model.UnitRank.C,
				VEntityFramework.Model.UnitRank.B,
				VEntityFramework.Model.UnitRank.A,
				VEntityFramework.Model.UnitRank.S,
				VEntityFramework.Model.UnitRank.SD,
				VEntityFramework.Model.UnitRank.SC,
				VEntityFramework.Model.UnitRank.SB,
				VEntityFramework.Model.UnitRank.SA,
				VEntityFramework.Model.UnitRank.SS,
				VEntityFramework.Model.UnitRank.SSD,
				VEntityFramework.Model.UnitRank.SSC,
				VEntityFramework.Model.UnitRank.SSB,
				VEntityFramework.Model.UnitRank.SSA,
				VEntityFramework.Model.UnitRank.SSS,
				VEntityFramework.Model.UnitRank.X,
				VEntityFramework.Model.UnitRank.SX,
				VEntityFramework.Model.UnitRank.SSX,
				VEntityFramework.Model.UnitRank.SSSX,
				VEntityFramework.Model.UnitRank.XX,
				VEntityFramework.Model.UnitRank.XD,
				VEntityFramework.Model.UnitRank.SXD,
				VEntityFramework.Model.UnitRank.Z,
				VEntityFramework.Model.UnitRank.SZ,
				VEntityFramework.Model.UnitRank.SSZ,
				VEntityFramework.Model.UnitRank.SSSZ,
				VEntityFramework.Model.UnitRank.XZ,
				VEntityFramework.Model.UnitRank.XDZ,
				VEntityFramework.Model.UnitRank.SXDZ,
				VEntityFramework.Model.UnitRank.XYZ
			};
		}
	}
}
