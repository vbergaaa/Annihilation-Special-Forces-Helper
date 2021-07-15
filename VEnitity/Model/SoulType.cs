using EnumsNET;
using System.ComponentModel;

namespace VEntityFramework.Model
{
	public enum SoulType
	{
		None,
		Lowest,
		Lower,
		Low,
		Mid,
		High,
		Higher,
		Highest,
		Night,
		Tormented,
		Demonic,
		Titan,
		Divine,
		Black,
		[Description("Half Pitch Black")]
		HalfPitchBlack,

		// Uniques
		// Lowest
		Bronze,
		Mirrors,
		[Description("The Hunter")]
		Hunter,

		// Lower
		Silver,
		Reflection,
		Veterancy,

		// Low
		Urusy,
		Scavenger,
		Hunger,

		// Mid
		Luck,
		Greed,
		Sharing,

		// High
		Convenience,
		Promotion,
		Status,

		// Higher
		Predestination,
		[Description("Rapid Mutation")]
		RapidMutation,
		Sales,

		// Highest
		[Description("Glowing Determination")]
		GlowingDetermination,
		[Description("Well Amplification")]
		WellAmplification,
		[Description("Accellerated Advancement")]
		AccelleratedAdvancement,

		// Night
		[Description("Ghost Force")]
		GhostForce,
		Training,
		[Description("Power Warping")]
		PowerWarping,

		// Tormented
		Demolition,
		Tanking,
		Unchained,

		// Demonic
		Draining,
		Alacrity,
		Stats,

		// Titan
		[Description("The Striding Titan")]
		StridingTitan,
		[Description("Unbound Reflection")]
		UnboundReflection,
		Acceleration,

		// Divine
		Supporting,
		[Description("Lucky Status")]
		LuckyStatus,
		[Description("Divine Speed")]
		DivineSpeed,

		// Black
		Sanctuary,
		Domination,
		Shadows,

		// Half Pitch Black
		[Description("Beginner Limit Breaking")]
		BeginnerLimitBreaking,
		[Description("Experimental Ranking")]
		ExperimentalRanking,
		[Description("Experimental Evolution")]
		ExperimentalEvolution
	}

	public static class SoulTypeExtentions
	{
		public static string GetDescription(this SoulType type)
		{
			return type.AsString(EnumFormat.Description, EnumFormat.Name);
		}
	}
}
