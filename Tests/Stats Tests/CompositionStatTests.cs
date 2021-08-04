using NUnit.Framework;
using System.Linq;
using VBusiness.Perks;
using VEntityFramework.Model;

namespace Tests.Stats_Tests
{
	public class CompositionStatTests
	{
		// These tests are for santity, to make sure damage and toughness calculations
		// don't unexpectedly change. These values can be changed as more features/bugs
		// are added or squashed
		[TestCase(DifficultyLevel.Brutal, 16349267, 199373199)]
		[TestCase(DifficultyLevel.Divine, 4600012, 2601555)]
		[TestCase(DifficultyLevel.Easy, 22976157, 199373199)]
		[TestCase(DifficultyLevel.Hard, 19361440, 199373199)]
		[TestCase(DifficultyLevel.Hell, 9239312, 188366064)]
		[TestCase(DifficultyLevel.Impossible, 2984702, 580488)]
		[TestCase(DifficultyLevel.Insane, 17179106, 199373199)]
		[TestCase(DifficultyLevel.Mythic, 6579538, 10327791)]
		[TestCase(DifficultyLevel.Nightmare, 13603671, 199373199)]
		[TestCase(DifficultyLevel.Normal, 23056096, 199373199)]
		[TestCase(DifficultyLevel.Titanic, 8038562, 39874158)]
		[TestCase(DifficultyLevel.Torment, 10543097, 191484105)]
		[TestCase(DifficultyLevel.VeryEasy, 22916006, 199373199)]
		[TestCase(DifficultyLevel.VeryHard, 18330892, 199373199)]
		public void TestCalculatedStats(DifficultyLevel difficulty, double expectedDamage, double expectedToughness)
		{
			var loadout = LoadMaxPage14();
			loadout.UnitConfiguration.DifficultyLevel = difficulty;
			Assert.That(loadout.Stats.Damage, Is.EqualTo(expectedDamage).Within(1));
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expectedToughness).Within(1));
		}

		VLoadout LoadMaxPage14()
		{
			var loadout = TestHelper.GetTestLoadout();
			var perks = loadout.Perks as PerkCollection;
			foreach (var perk in perks.AllPerks.Where(p => p.Page <= 14))
			{
				perk.DesiredLevel = perk.MaxLevel;
			}
			perks.DominatorDamage.DesiredLevel = 50; //lets be realisic
			perks.DominatorSpeed.DesiredLevel = 50;
			loadout.CurrentUnit = VUnit.New(UnitType.BladeMaster, loadout);
			loadout.CurrentUnit.CurrentInfusion = 10;
			loadout.CurrentUnit.EssenceStacks = 25;
			loadout.CurrentUnit.UnitRank = UnitRankType.XYZ;
			loadout.Upgrades.MaxAll();
			loadout.Gems.CritChanceGem.CurrentLevel = 50;
			loadout.Gems.CritDamageGem.CurrentLevel = 50;
			loadout.Gems.AttackGem.CurrentLevel = 50;
			loadout.Gems.AttackSpeedGem.CurrentLevel = 50;
			loadout.Gems.HealthArmorGem.CurrentLevel = 50;
			loadout.Gems.HealthGem.CurrentLevel = 50;
			return loadout;
		}
	}
}
