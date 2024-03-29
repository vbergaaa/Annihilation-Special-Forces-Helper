﻿using EnumsNET;
using System.ComponentModel;

namespace VEntityFramework.Model
{
	public enum PlayerRank
	{
		None,
		Rookie,
		[Description("Super Rookie")]
		SuperRookie,
		[Description("Prestige Rookie")]
		PrestigeRookie,
		Professional,
		[Description("Super Professional")]
		SuperProfessional,
		[Description("Prestige Professional")]
		PrestigeProfessional,
		Crusader,
		[Description("Super Crusader")]
		SuperCrusader,
		[Description("Prestige Crusader")]
		PrestigeCrusader,
		Expert,
		[Description("Super Expert")]
		SuperExpert,
		[Description("Prestige Expert")]
		PrestigeExpert,
		Master,
		[Description("Super Master")]
		SuperMaster,
		[Description("Prestige Master")]
		PrestigeMaster,
		Dominator,
		[Description("Arch Dominator")]
		ArchDominator,
		[Description("Exalted Dominator")]
		ExaltedDominator,
		Destroyer,
		[Description("Arch Destroyer")]
		ArchDestroyer,
		[Description("Exalted Destroyer")]
		ExaltedDestroyer,
	}

	public static class PlayerRankExtentions
	{
		public static string GetDescription(this PlayerRank type)
		{
			return type.AsString(EnumFormat.Description, EnumFormat.Name);
		}
	}
}
