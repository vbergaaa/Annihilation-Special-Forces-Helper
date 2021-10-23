using EnumsNET;
using NUnit.Framework;
using VEntityFramework.Model;

namespace Tests
{
	class UnitRankTests
	{
		[Test]
		public void TestNew()
		{
			var allRanks = Enums.GetValues<UnitRankType>();
			foreach (var rank in allRanks)
			{
				var generatedRank = VBusiness.Ranks.UnitRank.New(rank);
				var rankName = generatedRank.GetType().Name;

				if (rank == UnitRankType.None)
				{
					Assert.That(rankName, Is.EqualTo("EmptyRank"));
				}
				else
				{
					Assert.That(rankName, Contains.Substring($"Rank{rank}"));
				}
			}
		}
	}
}
