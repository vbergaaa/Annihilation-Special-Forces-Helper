using VEntityFramework.Model;

namespace VBusiness.PlayerRanks
{
	public static class PlayerRankExtensions
	{
		public static int GetMaxPerkPage(this PlayerRank rank)
		{
			return rank switch
			{
				PlayerRank.None => 1,
				PlayerRank.Rookie => 1,
				PlayerRank.SuperRookie => 2,
				PlayerRank.PrestigeRookie => 3,
				PlayerRank.Professional => 4,
				PlayerRank.SuperProfessional => 5,
				PlayerRank.PrestigeProfessional => 6,
				PlayerRank.Crusader => 7,
				PlayerRank.SuperCrusader => 7,
				PlayerRank.PrestigeCrusader => 7,
				PlayerRank.Expert => 8,
				PlayerRank.SuperExpert => 9,
				PlayerRank.PrestigeExpert => 10,
				PlayerRank.Master => 11,
				PlayerRank.SuperMaster => 12,
				PlayerRank.PrestigeMaster => 13,
				_ => (58 - (int)rank) / 3 // should cover all ranks after dominator
			};
		}
	}
}
