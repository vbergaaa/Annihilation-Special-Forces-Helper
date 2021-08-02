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
		[TestCase(DifficultyLevel.Brutal,		16158767, 199373199)]
		[TestCase(DifficultyLevel.Divine,       4085083, 2601555)]
		[TestCase(DifficultyLevel.Easy,         22940201, 199373199)]
		[TestCase(DifficultyLevel.Hard,         19264105, 199373199)]
		[TestCase(DifficultyLevel.Hell,         8969264, 188366064)]
		[TestCase(DifficultyLevel.Impossible,   1967891, 580488)]
		[TestCase(DifficultyLevel.Insane,       17005123, 199373199)]
		[TestCase(DifficultyLevel.Mythic,       6177724, 10327791)]
		[TestCase(DifficultyLevel.Nightmare,    13368830, 199373199)]
		[TestCase(DifficultyLevel.Normal,       22994801, 199373199)]
		[TestCase(DifficultyLevel.Titanic,      7692197, 39874158)]
		[TestCase(DifficultyLevel.Torment,      10312348, 191484105)]
		[TestCase(DifficultyLevel.VeryEasy,		22898807, 199373199)]
		[TestCase(DifficultyLevel.VeryHard,		18223585, 199373199)]
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
