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
		// That's far too complicated to work out.
		// They are just simply what they were when I made this test,
		// so I don't accidently change something
		[TestCase(DifficultyLevel.VeryEasy,		4960738.45, 3786552.03)]
		[TestCase(DifficultyLevel.Easy,			4934730.62, 7234722.16)]
		[TestCase(DifficultyLevel.Normal,		4899392.00, 12171043.81)]
		[TestCase(DifficultyLevel.Hard,			4522013.12, 18603287.96)]
		[TestCase(DifficultyLevel.VeryHard,		4261424.99, 22290725.40)]
		[TestCase(DifficultyLevel.Insane,		3888035.63, 32071495.77)]
		[TestCase(DifficultyLevel.Brutal,		3670536.83, 37060395.11)]
		[TestCase(DifficultyLevel.Nightmare,	2974529.67, 56884939.89)]
		[TestCase(DifficultyLevel.Torment,		2391767.63, 71620525.63)]
		[TestCase(DifficultyLevel.Hell,			2071842.24, 92489781.99)]
		[TestCase(DifficultyLevel.Titanic,		1755140.30, 29230683.13)]
		[TestCase(DifficultyLevel.Mythic,		1383523.22, 10125757.81)]
		[TestCase(DifficultyLevel.Divine,		835916.78,  3707227.17)]
		[TestCase(DifficultyLevel.Impossible,	560339.61,  2152849.89)]
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
