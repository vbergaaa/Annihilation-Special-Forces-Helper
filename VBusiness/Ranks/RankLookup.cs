using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankLookup
	{
		public List<UnitRank> GetRanks()
		{
			return new List<UnitRank>
			{
				UnitRank.None,
				UnitRank.D,
				UnitRank.C,
				UnitRank.B,
				UnitRank.A,
				UnitRank.S,
				UnitRank.SD,
				UnitRank.SC,
				UnitRank.SB,
				UnitRank.SA,
				UnitRank.SS,
				UnitRank.SSD,
				UnitRank.SSC,
				UnitRank.SSB,
				UnitRank.SSA,
				UnitRank.SSS,
				UnitRank.X,
				UnitRank.SX,
				UnitRank.SSX,
				UnitRank.SSSX,
				UnitRank.XX,
				UnitRank.XD,
				UnitRank.SXD,
				UnitRank.Z,
				UnitRank.SZ,
				UnitRank.SSZ,
				UnitRank.SSSZ,
				UnitRank.XZ,
				UnitRank.XDZ,
				UnitRank.SXDZ,
				UnitRank.XYZ
			};
		}
	}
}
