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
		PrestigeMaster
	}
}
