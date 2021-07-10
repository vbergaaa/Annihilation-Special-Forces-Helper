using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VEntityFramework.Model;

namespace Tests.Stats_Tests
{
	public class CompositionStatTests
	{
		// The idea of this test isn't that all these values are exact. 
		// Its very likely you can and will need to change them.
		// They're far too complicated to work out manually.
		// They are just simply what they were when I made this test,
		// so I don't accidently change something
		[TestCase(DifficultyLevel.Brutal,		9812134, 199373199)]
		[TestCase(DifficultyLevel.Divine,       2117927, 2656003)]
		[TestCase(DifficultyLevel.Easy,         14178245, 199373199)]
		[TestCase(DifficultyLevel.Hard,         11854016, 199373199)]
		[TestCase(DifficultyLevel.Hell,         5386411, 188366064)]
		[TestCase(DifficultyLevel.Impossible,   426217, 580488)]
		[TestCase(DifficultyLevel.Insane,       10355889, 199373199)]
		[TestCase(DifficultyLevel.Mythic,       3531988, 10327791)]
		[TestCase(DifficultyLevel.Nightmare,    8033915, 199373199)]
		[TestCase(DifficultyLevel.Normal,       14214922, 199373199)]
		[TestCase(DifficultyLevel.Titanic,      4529566, 39874158)]
		[TestCase(DifficultyLevel.Torment,      6235095, 191484105)]
		[TestCase(DifficultyLevel.VeryEasy,		14200778, 199373199)]
		[TestCase(DifficultyLevel.VeryHard,		11177816, 199373199)]
		public void TestCalculatedStats(DifficultyLevel difficulty, double expectedDamage, double expectedToughness)
		{
			var loadout = LoadMaxPage14();
			loadout.UnitConfiguration.DifficultyLevel = difficulty;
			Assert.That(loadout.Stats.Damage, Is.EqualTo(expectedDamage).Within(1));
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expectedToughness).Within(1));
		}

		VLoadout LoadMaxPage14()
		{
			var loadout = new Loadout();
			loadout.UseUnitStats = true;
			loadout.ShouldRestrict = false;
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
