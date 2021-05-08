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
		[TestCase(DifficultyLevel.VeryEasy,		4984467.79, 287088960.04)]
		[TestCase(DifficultyLevel.Easy,			4976403.42, 287088960.04)]
		[TestCase(DifficultyLevel.Normal,		4988844.42, 287088960.04)]
		[TestCase(DifficultyLevel.Hard,			4160747.87, 287088960.04)]
		[TestCase(DifficultyLevel.VeryHard,		3923402.12, 287088960.04)]
		[TestCase(DifficultyLevel.Insane,		3634906.8, 287088960.04)]
		[TestCase(DifficultyLevel.Brutal,		3444049.36, 287088960.04)]
		[TestCase(DifficultyLevel.Nightmare,	2819896.34, 287088960.04)]
		[TestCase(DifficultyLevel.Torment,		2276052.62, 279175136.57)]
		[TestCase(DifficultyLevel.Hell,			1998221.54, 276038129.87)]
		[TestCase(DifficultyLevel.Titanic,		1722362.55, 22954988.36)]
		[TestCase(DifficultyLevel.Mythic,		1377471.48, 6932033.95)]
		[TestCase(DifficultyLevel.Divine,		840354.48,  2760504.24)]
		[TestCase(DifficultyLevel.Impossible,	172108.45,  766238.49)]
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
