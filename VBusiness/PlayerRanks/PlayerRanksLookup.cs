using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.PlayerRanks
{
	public class PlayerRankLookups
	{
		public List<PlayerRank> GetPlayerRanks()
		{
			return new List<PlayerRank>
			{
				PlayerRank.None,
				PlayerRank.Rookie,
				PlayerRank.SuperRookie,
				PlayerRank.PrestigeRookie,
				PlayerRank.Profressional,
				PlayerRank.SuperProfressional,
				PlayerRank.PrestigeProfressional,
				PlayerRank.Expert,
				PlayerRank.SuperExpert,
				PlayerRank.PrestigeExpert,
				PlayerRank.Master,
				PlayerRank.SuperMaster,
				PlayerRank.PrestigeMaster
			};
		}
	}
}