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
				"Professional" => PlayerRank.Professional,
				"SuperProfessional" => PlayerRank.SuperProfessional,
				"PrestigeProfessional" => PlayerRank.PrestigeProfessional,
				"Crusader" => PlayerRank.Crusader,
				"SuperCrusader" => PlayerRank.SuperCrusader,
				"PrestigeCrusader" => PlayerRank.PrestigeCrusader,
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
