using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VPlayerRank : VBusinessObject
	{
		public override string BizoName => "PlayerRank";

		internal static PlayerRank GetPlayerRankFromString(string rank)
		{
			return rank switch
			{
				"None" => PlayerRank.None,
				"Rookie" => PlayerRank.Rookie,
				"SuperRookie" => PlayerRank.SuperRookie,
				"PrestigeRookie" => PlayerRank.PrestigeRookie,
				"Profressional" => PlayerRank.Profressional,
				"SuperProfressional" => PlayerRank.SuperProfressional,
				"PrestigeProfressional" => PlayerRank.PrestigeProfressional,
				"Expert" => PlayerRank.Expert,
				"SuperExpert" => PlayerRank.SuperExpert,
				"PrestigeExpert" => PlayerRank.PrestigeExpert,
				"Master" => PlayerRank.Master,
				"SuperMaster" => PlayerRank.SuperMaster,
				"PrestigeMaster" => PlayerRank.PrestigeMaster,
				_ => PlayerRank.None
			};
		}
	}
}
