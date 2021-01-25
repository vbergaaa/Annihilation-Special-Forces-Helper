using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace Tests
{
	class UnitRankTests
	{
		[Test]
		public void TestNew()
		{
			var allRanks = Enums.GetValues<UnitRank>();
			foreach (var rank in allRanks)
			{
				var generatedRank = VBusiness.Ranks.UnitRank.New(rank, null);
				var rankName = generatedRank.GetType().Name;

				if (rank == UnitRank.None)
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
