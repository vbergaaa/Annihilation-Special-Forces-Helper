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
		[TestCase(DifficultyLevel.Brutal, 478819113, 199373199)]
		[TestCase(DifficultyLevel.Divine, 110259189, 2601555)]
		[TestCase(DifficultyLevel.Easy, 672830304, 199373199)]
		[TestCase(DifficultyLevel.Hard, 569247640, 199373199)]
		[TestCase(DifficultyLevel.Hell, 268720925, 188366064)]
		[TestCase(DifficultyLevel.Impossible, 44760877, 580488)]
		[TestCase(DifficultyLevel.Insane, 503230120, 199373199)]
		[TestCase(DifficultyLevel.Mythic, 175518080, 10327791)]
		[TestCase(DifficultyLevel.Nightmare, 397768242, 199373199)]
		[TestCase(DifficultyLevel.Normal, 677206614, 199373199)]
		[TestCase(DifficultyLevel.Titanic, 224547873, 39874158)]
		[TestCase(DifficultyLevel.Torment, 308452725, 191484105)]
		[TestCase(DifficultyLevel.VeryEasy, 671014396, 199373199)]
		[TestCase(DifficultyLevel.VeryHard, 538980776, 199373199)]
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
