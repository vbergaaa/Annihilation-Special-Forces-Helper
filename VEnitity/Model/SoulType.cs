using System;
using System.Collections.Generic;
using System.Text;

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

		// Uniques
		// Lowest
		Bronze,
		Mirrors,
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
		RapidMutation,
		Sales,

		// Highest
		GlowingDetermination,
		WellAmplification,
		AccelleratedAdvancement,

		// Night
		GhostForce,
		Training,
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
		StridingTitan,
		UnboundReflection,
	}

	public static class SoulTypeExtentions
	{
		public static string GetDescription(this SoulType type)
		{
			return type switch
			{
				(SoulType.Hunter) => "The Hunter",
				(SoulType.RapidMutation) => "Rapid Mutation",
				(SoulType.GlowingDetermination) => "Glowing Determination",
				(SoulType.WellAmplification) => "Well Amplification",
				(SoulType.AccelleratedAdvancement) => "Accellerated Advancement",
				(SoulType.GhostForce) => "Ghost Force",
				(SoulType.PowerWarping) => "Power Warping",
				(SoulType.StridingTitan) => "The Striding Titan",
				(SoulType.UnboundReflection) => "Unbound Reflection",
				_ => type.ToString(),
			};
		}
	}
}
