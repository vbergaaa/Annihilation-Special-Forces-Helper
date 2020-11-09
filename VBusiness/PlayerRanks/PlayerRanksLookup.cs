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
				PlayerRank.Professional,
				PlayerRank.SuperProfessional,
				PlayerRank.PrestigeProfessional,
				PlayerRank.Professional,
				PlayerRank.SuperCrusader,
				PlayerRank.PrestigeCrusader,
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