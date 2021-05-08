using NUnit.Framework;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VEntityFramework.Model;

namespace Tests.Stats_Tests
{
	[TestFixture]
	public class ToughnessTests
	{
		[Test]
		public void TestToughness_HasCurrentUnit()
		{
			var loadout = new Loadout();
			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.VeryEasy;
			loadout.UseUnitStats = true;

			loadout.Units.Add(VUnit.New(UnitType.None, loadout));
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(0));

			loadout.Units.Add(VUnit.New(UnitType.WarpLord, loadout));
			Assert.That(loadout.Stats.Toughness, Is.Not.EqualTo(0));
		}

		[Test]
		public void TestToughness_UseProfileStats()
		{
			var loadout = new Loadout();
			loadout.Units.Add(VUnit.New(UnitType.WarpLord, loadout));
			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.VeryEasy;

			loadout.UseUnitStats = true;
			Assert.That(loadout.Stats.Toughness, Is.Not.EqualTo(0));

			loadout.UseUnitStats = false;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(0));
		}

		[Test]
		public void TestToughness_HasDifficulty()
		{
			var loadout = new Loadout();
			loadout.Units.Add(VUnit.New(UnitType.WarpLord, loadout));
			loadout.UseUnitStats = true;

			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.VeryEasy;
			Assert.That(loadout.Stats.Toughness, Is.Not.EqualTo(0));

			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.None;
			Assert.That(loadout.Stats.Toughness, Is.Not.EqualTo(0));
		}

		[TestCase(DifficultyLevel.VeryEasy, 4740.85)]
		[TestCase(DifficultyLevel.Normal, 1259.26)]
		[TestCase(DifficultyLevel.VeryHard, 1014.05)]
		public void TestToughness_Difficulty(DifficultyLevel difficulty, double expected)
		{
			var loadout = GetLoadout();
			SetBasicLingComposition();
			loadout.UnitConfiguration.DifficultyLevel = difficulty;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		[TestCase(0, 444.44 + 814.81)]
		[TestCase(100, 857.14 + 814.81)]
		[TestCase(200, 12000 + 814.81)]
		public void TestToughness_HealthArmor(int additionalArmor, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.Gems.HealthArmorGem.CurrentLevel = (short)additionalArmor;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.02));
		}

		[TestCase(0, 444.444 + 814.81)]
		[TestCase(100, 444.444 * 2 + 814.81)]
		[TestCase(500, 444.444 * 6 + 814.81)]
		[TestCase(1000, 444.444 * 11 + 814.81)]
		public void TestToughness_Health(int additionalHealth, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.Gems.HealthGem.CurrentLevel = (short)additionalHealth;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.02));
		}

		[TestCase(0, 444.44 + 814.81)]
		[TestCase(100, 444.44 + 1571.43)]
		[TestCase(200, 444.44 + 22000)]
		public void TestToughness_ShieldsArmor(int additionalArmor, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.Gems.ShieldsArmorGem.CurrentLevel = (short)additionalArmor;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.02));
		}


		[TestCase(0, 444.444 + 814.815)]
		[TestCase(100, 444.444 + 814.815 * 2)]
		[TestCase(500, 444.444 + 814.815 * 6)]
		[TestCase(1000, 444.444 + 814.815 * 11)]
		public void TestToughness_Shields(int additionalShields, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.Gems.ShieldsGem.CurrentLevel = (short)additionalShields;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.02));
		}

		[TestCase(0, 1259.26)]
		[TestCase(10, 1478.26)]
		[TestCase(50, 4857.14)]
		public void TestToughness_DamageReduction(int dr, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.Stats.UpdateDamageReduction("Test", dr);
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		[TestCase(0, 1259.26)]
		[TestCase(1, 1455.25)]
		[TestCase(2, 1672.13)]
		[TestCase(3, 1913.42)]
		[TestCase(10, 4857.14)]
		public void TestToughness_Infusion(int infuse, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.CurrentUnit.CurrentInfusion = infuse;
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		[TestCase(0, 1259.26)]
		[TestCase(1, 1355.70)]
		[TestCase(2, 1457.14)]
		[TestCase(3, 1564)]
		[TestCase(25, 7403.23)]
		public void TestToughness_EssenceStacks(int essence, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.CurrentUnit.EssenceStacks = essence;

			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		[TestCase(UnitType.WarpLord, 1259.26)]
		[TestCase(UnitType.Striker, 1272.97)]
		public void TestToughness_CurrentUnit(UnitType unit, double expected)
		{
			SetBasicLingComposition();
			var loadout = GetLoadout();
			loadout.CurrentUnit = VUnit.New(unit, loadout);

			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		[TestCase(1, 0, 1259.26)]
		[TestCase(0, 1, 1178.22)]
		[TestCase(.5, .5, 1214.29)]
		public void TestToughness_UnitComposition(double lingChance, double roachChance, double expected)
		{
			// ling atk = 60;
			// roach atk = 70;
			StatCalculationHelper.UnitCompOverride = new List<(EnemyType, double)> {
				( EnemyType.Zergling, lingChance ),
				( EnemyType.Roach, roachChance )
			};
			var loadout = GetLoadout();
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		[TestCase(1, 0, 102000)]
		[TestCase(0, 1, 5950)]
		[TestCase(.5, .5, 10523.81)]
		[TestCase(.9, .1, 35758.62)]
		public void TestToughness_UnitComposition_WhenOneUnitDoesNoDamage(double lingChance, double roachChance, double expected)
		{
			// ling atk = 60;
			// roach atk = 70;
			StatCalculationHelper.UnitCompOverride = new List<(EnemyType, double)>
			{ 
				(EnemyType.Zergling, lingChance),
				(EnemyType.Roach, roachChance)
			};
			var loadout = GetLoadout();
			loadout.Gems.HealthArmorGem.CurrentLevel = 100; 
			loadout.Gems.ShieldsArmorGem.CurrentLevel = 100;
			loadout.Upgrades.HealthArmorUpgrade = 80;
			loadout.Upgrades.ShieldsArmorUpgrade = 80;
			// 60 flat armor
			Assert.That(loadout.Stats.Toughness, Is.EqualTo(expected).Within(0.01));
		}

		VLoadout GetLoadout()
		{
			// loadout with 1 WL, 
			// 19.5 armor,
			// 550 shields
			// 300 health
			var loadout = new Loadout();
			loadout.Units.Add(VUnit.New(UnitType.WarpLord, loadout));
			loadout.UseUnitStats = true;
			loadout.ShouldRestrict = false;
			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.Normal;
			loadout.Upgrades.HealthArmorUpgrade = 50;
			loadout.Upgrades.HealthUpgrade = 50;
			loadout.Upgrades.ShieldsArmorUpgrade = 50;
			loadout.Upgrades.ShieldsUpgrade = 50;

			var perks = loadout.Perks as PerkCollection;
			perks.MaximumPotiential.DesiredLevel = 8;
			perks.MaximumPotiential2.DesiredLevel = 10;
			perks.MaximumPotiental3.DesiredLevel = 10;
			perks.MaximumPotential4.DesiredLevel = 10;
			return loadout;
		}

		[TearDown]
		public void TearDown()
		{
			StatCalculationHelper.UnitCompOverride = null;
		}

		void SetBasicLingComposition()
		{
			StatCalculationHelper.UnitCompOverride = new List<(EnemyType, double)> { (EnemyType.Zergling, 1) };
		}
	}
}
