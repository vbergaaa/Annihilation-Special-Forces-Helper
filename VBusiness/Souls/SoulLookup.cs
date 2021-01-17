using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class SoulLookup
	{
		public List<SoulType> GetSouls()
		{
			return new List<SoulType>()
			{
				SoulType.None,
				SoulType.Lowest,
				SoulType.Lower,
				SoulType.Low,
				SoulType.Mid,
				SoulType.High,
				SoulType.Higher,
				SoulType.Highest,
				SoulType.Night,
				SoulType.Tormented,
				SoulType.Demonic,
				SoulType.Titan,
				SoulType.Bronze,
				SoulType.Mirrors,
				SoulType.Hunter,
				SoulType.Silver,
				SoulType.Reflection,
				SoulType.Veterancy,
				SoulType.Urusy,
				SoulType.Scavenger,
				SoulType.Hunger,
				SoulType.Luck,
				SoulType.Greed,
				SoulType.Sharing,
				SoulType.Convenience,
				SoulType.Promotion,
				SoulType.Status,
				SoulType.Predestination,
				SoulType.RapidMutation,
				SoulType.Sales,
				SoulType.GlowingDetermination,
				SoulType.WellAmplification,
				SoulType.AccelleratedAdvancement,
				SoulType.GhostForce,
				SoulType.Training,
				SoulType.PowerWarping,
				SoulType.Demolition,
				SoulType.Tanking,
				SoulType.Unchained,
				SoulType.Draining,
				SoulType.Alacrity,
				SoulType.Stats,
				SoulType.StridingTitan,
				SoulType.UnboundReflection,
				SoulType.Acceleration,
			};
		}

		//List<KeyValuePair<string, SoulType>> SoulTypeList
		//{
		//	get
		//	{
		//		if (fSoulTypeList == null)
		//		{
		//			// TODO - This is disgusting lets change it
		//			var list = new Dictionary<string, SoulType>
		//			{
		//				{ "None", SoulType.None },
		//				{ $"{SoulType.Lowest.GetDescription()} Soul", SoulType.Lowest },
		//				{ $"{SoulType.Lower.GetDescription()} Soul", SoulType.Lower },
		//				{ $"{SoulType.Low.GetDescription()} Soul", SoulType.Low },
		//				{ $"{SoulType.Mid.GetDescription()} Soul", SoulType.Mid },
		//				{ $"{SoulType.High.GetDescription()} Soul", SoulType.High },
		//				{ $"{SoulType.Higher.GetDescription()} Soul", SoulType.Higher },
		//				{ $"{SoulType.Highest.GetDescription()} Soul", SoulType.Highest },
		//				{ $"{SoulType.Night.GetDescription()} Soul", SoulType.Night },
		//				{ $"{SoulType.Tormented.GetDescription()} Soul", SoulType.Tormented },
		//				{ $"{SoulType.Demonic.GetDescription()} Soul", SoulType.Demonic },
		//				{ $"{SoulType.Titan.GetDescription()} Soul", SoulType.Titan },
		//				{ $"Lowest Soul of {SoulType.Bronze.GetDescription()}", SoulType.Bronze },
		//				{ $"Lowest Soul of {SoulType.Mirrors.GetDescription()}", SoulType.Mirrors },
		//				{ $"Lowest Soul of {SoulType.Hunter.GetDescription()}", SoulType.Hunter },
		//				{ $"Lower Soul of {SoulType.Silver.GetDescription()}", SoulType.Silver },
		//				{ $"Lower Soul of {SoulType.Reflection.GetDescription()}", SoulType.Reflection },
		//				{ $"Lower Soul of {SoulType.Veterancy.GetDescription()}", SoulType.Veterancy },
		//				{ $"Low Soul of {SoulType.Urusy.GetDescription()}", SoulType.Urusy },
		//				{ $"Low Soul of {SoulType.Scavenger.GetDescription()}", SoulType.Scavenger },
		//				{ $"Low Soul of {SoulType.Hunger.GetDescription()}", SoulType.Hunger },
		//				{ $"Mid Soul of {SoulType.Luck.GetDescription()}", SoulType.Luck },
		//				{ $"Mid Soul of {SoulType.Greed.GetDescription()}", SoulType.Greed },
		//				{ $"Mid Soul of {SoulType.Sharing.GetDescription()}", SoulType.Sharing },
		//				{ $"High Soul of {SoulType.Convenience.GetDescription()}", SoulType.Convenience },
		//				{ $"High Soul of {SoulType.Promotion.GetDescription()}", SoulType.Promotion },
		//				{ $"High Soul of {SoulType.Status.GetDescription()}", SoulType.Status },
		//				{ $"Higher Soul of {SoulType.Predestination.GetDescription()}", SoulType.Predestination },
		//				{ $"Higher Soul of {SoulType.RapidMutation.GetDescription()}", SoulType.RapidMutation },
		//				{ $"Higher Soul of {SoulType.Sales.GetDescription()}", SoulType.Sales },
		//				{ $"Highest Soul of {SoulType.GlowingDetermination.GetDescription()}", SoulType.GlowingDetermination },
		//				{ $"Highest Soul of {SoulType.WellAmplification.GetDescription()}", SoulType.WellAmplification },
		//				{ $"Highest Soul of {SoulType.AccelleratedAdvancement.GetDescription()}", SoulType.AccelleratedAdvancement },
		//				{ $"Night Soul of {SoulType.GhostForce.GetDescription()}", SoulType.GhostForce },
		//				{ $"Night Soul of {SoulType.Training.GetDescription()}", SoulType.Training },
		//				{ $"Night Soul of {SoulType.PowerWarping.GetDescription()}", SoulType.PowerWarping },
		//				{ $"Tormented Soul of {SoulType.Demolition.GetDescription()}", SoulType.Demolition },
		//				{ $"Tormented Soul of {SoulType.Tanking.GetDescription()}", SoulType.Tanking },
		//				{ $"Tormented Soul of {SoulType.Unchained.GetDescription()}", SoulType.Unchained },
		//				{ $"Demonic Soul of {SoulType.Draining.GetDescription()}", SoulType.Draining },
		//				{ $"Demonic Soul of {SoulType.Alacrity.GetDescription()}", SoulType.Alacrity },
		//				{ $"Demonic Soul of {SoulType.Stats.GetDescription()}", SoulType.Stats },
		//				{ $"Titan Soul of {SoulType.Acceleration.GetDescription()}", SoulType.Acceleration },
		//				{ $"Titan Soul of {SoulType.StridingTitan.GetDescription()}", SoulType.StridingTitan },
		//				{ $"Titan Soul of {SoulType.UnboundReflection.GetDescription()}", SoulType.UnboundReflection },
		//			};
		//			fSoulTypeList = list.ToList();
		//		}
		//		return fSoulTypeList;
		//	}
		//}
		//private List<KeyValuePair<string, SoulType>> fSoulTypeList;
	}
}
