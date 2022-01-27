using EnumsNET;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VBusiness.PlayerRanks;
using VEntityFramework.Model;

namespace Tests
{
	public class PerksTest
	{
		[Test]
		public void TestAllSoulsAreInSoulCollection()
		{
			var perkCollection = new PerkCollectionForTest();

			var allPerkPropertyInfos = typeof(PerkCollection).GetProperties().Where(p => p.PropertyType == typeof(VPerk));

			foreach (var property in allPerkPropertyInfos)
			{
				var actualPerk = property.GetValue(perkCollection);
				Assert.That(perkCollection.AllPerks.Contains(actualPerk), $"{actualPerk.GetType().Name} wasn't found in AllPerks");
			}
		}

		[Test]
		public void TestAllPerkPagesAreImplementedForRank()
		{
			var maxPlayerRank = Enums.GetValues<PlayerRank>().Last();
			var lastPage = maxPlayerRank.GetMaxPerkPage();

			var allPerkPropertyInfos = typeof(PerkCollection).GetProperties().Where(p => p.PropertyType == typeof(VPerk) && !p.Name.StartsWith("Perk")).ToList();

			Assert.That(allPerkPropertyInfos, Has.Count.EqualTo(lastPage * 6),
				$"Page {lastPage} has been unlocked based on the maximum rank, but you haven't loaded all the perks for that rank. \r\nPlease add the required ranks, fix the max page finding logic, or remove the additional ranks");
		}

		[Test]
		public void TestPerksPageAndPostions()
		{
			var lastPage = Enums.GetValues<PlayerRank>().Last().GetMaxPerkPage();

			var perkCollection = new PerkCollectionForTest();
			for (var i = 0; i < lastPage; i++)
			{
				for (var j = 0; j < 6; j++)
				{
					var matchingPerks = perkCollection.AllPerks.Where(p => p.Position == j + 1 && p.Page == i + 1).ToList();
					Assert.That(matchingPerks, Has.Count.EqualTo(1), $"Fail at Page {i+1} and Position {j+1}");
				}
			}
		}

		[Test]
		public void TestAllPerksHaveDescriptions()
		{
			var perkCollection = new PerkCollectionForTest();

			foreach (var perk in perkCollection.AllPerks)
			{
				Assert.That(!string.IsNullOrEmpty(perk.Description), $"Add a description for {perk.Name} Perk");
			}
		}

		[Test]
		public void TestProposedValues_DontChangeState()
		{
			var loadout = TestHelper.GetEmptyLoadout();
			loadout.CurrentUnit = VUnit.New(UnitType.Striker, loadout);
			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.VeryEasy;
			loadout.CurrentUnit.CurrentInfusion = loadout.CurrentUnit.MaximumInfusion;
			loadout.CurrentUnit.CurrentKills = loadout.CurrentUnit.MaximumKills;

			var oldDamage = loadout.Stats.Damage;
			var oldToughness = loadout.Stats.Toughness;
			var perks = loadout.Perks as PerkCollection;

			foreach(var perk in perks.AllPerks)
			{
				perk.GetIncrementHint(perk.MinimumIncreaseForOptimise);
				Assert.That(loadout.Stats.Damage, Is.EqualTo(oldDamage), $"{perk.Name} Perk permanently modifies damage when getting it's increment hint");
				Assert.That(loadout.Stats.Toughness, Is.EqualTo(oldToughness), $"{perk.Name} Perk permanently modifies toughness when getting it's increment hint");

				perk.GetDecrementHint(perk.MinimumIncreaseForOptimise);
				Assert.That(loadout.Stats.Damage, Is.EqualTo(oldDamage), $"{perk.Name} Perk permanently modifies damage when getting it's decrement hint");
				Assert.That(loadout.Stats.Toughness, Is.EqualTo(oldToughness), $"{perk.Name} Perk permanently modifies toughness when getting it's decrement hint");
			}
		}
	}

	class PerkCollectionForTest : PerkCollection
	{
		public PerkCollectionForTest() : base(new Loadout())
		{
		}

		public new IEnumerable<VPerk> AllPerks => allPerks;
	}
}
