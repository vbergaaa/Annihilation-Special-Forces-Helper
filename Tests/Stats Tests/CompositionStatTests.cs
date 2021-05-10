using NUnit.Framework;
using System;
using System.Collections.Generic;
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
		[TestCase(DifficultyLevel.Brutal,		3684331.87, 379487907.43)]
		[TestCase(DifficultyLevel.Divine,       898983.86, 5006238.04)]
		[TestCase(DifficultyLevel.Easy,         5323594.36, 379487907.43)]
		[TestCase(DifficultyLevel.Hard,         4451032.61, 379487907.43)]
		[TestCase(DifficultyLevel.Hell,         2137632.35, 355534217.12)]
		[TestCase(DifficultyLevel.Impossible,   184116.02, 1086245.25)]
		[TestCase(DifficultyLevel.Insane,       3888504.95, 379487907.43)]
		[TestCase(DifficultyLevel.Mythic,       1473574.14, 19666151.44)]
		[TestCase(DifficultyLevel.Nightmare,    3016633.29, 379487907.43)]
		[TestCase(DifficultyLevel.Normal,       5336903.33, 379487907.43)]
		[TestCase(DifficultyLevel.Titanic,      1842527.37, 76179651.25)]
		[TestCase(DifficultyLevel.Torment,      2434846.99, 362301325.40)]
		[TestCase(DifficultyLevel.VeryEasy,		5332221.36, 379487907.43)]
		[TestCase(DifficultyLevel.VeryHard,		4197127.85, 379487907.43)]
		public void TestCalculatedStats(DifficultyLevel difficulty, double expectedDamage, double expectedToughness)
		{
			var loadout = LoadMaxAll();
			loadout.UnitConfiguration.DifficultyLevel = difficulty;
			Assert.That(loadout.Stats.Damage, Is.EqualTo(expectedDamage).Within(0.01));
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expectedToughness).Within(0.01));
		}

		VLoadout LoadMaxAll()
		{
			var loadout = new Loadout();
			loadout.UseUnitStats = true;
			loadout.ShouldRestrict = false;
			var perks = loadout.Perks as PerkCollection;
			foreach (var perk in perks.AllPerks)
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
