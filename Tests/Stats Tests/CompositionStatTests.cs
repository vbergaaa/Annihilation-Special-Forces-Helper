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
		[TestCase(DifficultyLevel.Brutal, 479233813, 199373199)]
		[TestCase(DifficultyLevel.Divine, 109388839, 2246008)]
		[TestCase(DifficultyLevel.Easy, 672830304, 199373199)]
		[TestCase(DifficultyLevel.Hard, 569359387, 199373199)]
		[TestCase(DifficultyLevel.Hell, 268748434, 188366064)]
		[TestCase(DifficultyLevel.Impossible, 44760877, 580488)]
		[TestCase(DifficultyLevel.Insane, 503662439, 199373199)]
		[TestCase(DifficultyLevel.Mythic, 175130901, 8173615)]
		[TestCase(DifficultyLevel.Nightmare, 398052940, 199373199)]
		[TestCase(DifficultyLevel.Normal, 677217210, 199373199)]
		[TestCase(DifficultyLevel.Titanic, 224390095, 36985862)]
		[TestCase(DifficultyLevel.Torment, 308575257, 191484105)]
		[TestCase(DifficultyLevel.VeryEasy, 671014396, 199373199)]
		[TestCase(DifficultyLevel.VeryHard, 539090062, 199373199)]
		public void TestCalculatedStats(DifficultyLevel difficulty, double expectedDamage, double expectedToughness)
		{
			var loadout = LoadMaxPage14();
			loadout.UnitConfiguration.DifficultyLevel = difficulty;
			Assert.That(loadout.Stats.Damage, Is.EqualTo(expectedDamage).Within(1));
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expectedToughness).Within(1));
		}

        static VLoadout LoadMaxPage14()
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
