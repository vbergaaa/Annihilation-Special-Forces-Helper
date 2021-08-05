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
		[TestCase(DifficultyLevel.Brutal, 1883716, 199373199)]
		[TestCase(DifficultyLevel.Divine, 460294, 2601555)]
		[TestCase(DifficultyLevel.Easy, 2633051, 199373199)]
		[TestCase(DifficultyLevel.Hard, 2234284, 199373199)]
		[TestCase(DifficultyLevel.Hell, 1071747, 188366064)]
		[TestCase(DifficultyLevel.Impossible, 219940, 580488)]
		[TestCase(DifficultyLevel.Insane, 1978458, 199373199)]
		[TestCase(DifficultyLevel.Mythic, 713246, 10327791)]
		[TestCase(DifficultyLevel.Nightmare, 1567967, 199373199)]
		[TestCase(DifficultyLevel.Normal, 2653614, 199373199)]
		[TestCase(DifficultyLevel.Titanic, 900191, 39874158)]
		[TestCase(DifficultyLevel.Torment, 1227472, 191484105)]
		[TestCase(DifficultyLevel.VeryEasy, 2624427, 199373199)]
		[TestCase(DifficultyLevel.VeryHard, 2116570, 199373199)]
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
