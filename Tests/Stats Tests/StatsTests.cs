using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VBusiness.Ranks;
using VBusiness.Units;
using VEntityFramework.Model;

namespace Tests
{
	[TestFixture]
	public class StatsTests
	{
		[TestCase(10, 0, 0, 0, 10)]
		[TestCase(0, 20, 0, 0, 20)]
		[TestCase(0, 0, 15, 0, 15)]
		[TestCase(0, 0, 0, 40, 40)]
		[TestCase(10, 20, 15, 0, 38.8)]
		[TestCase(10, 20, 15, 40, 63.28)]
		public void TestDamageReduction(short specPerks, int statsDR, short rankDr, double otherDr, double expectedDR)
		{
			var loadout = new Loadout();
			loadout.ShouldRestrict = false;
			loadout.CurrentUnit = VUnit.New(UnitType.WarpLord, loadout);
			loadout.UnitSpec = UnitType.WarpLord;
			var perks = (PerkCollection)loadout.Perks;

			perks.UnitSpecialization.DesiredLevel = specPerks;
			perks.DamageReduction.DesiredLevel = (short)(statsDR > 10 ? 10 : statsDR);
			perks.DamageReduction2.DesiredLevel = (short)(statsDR < 10 ? 0 : statsDR - 10);
			loadout.CurrentUnit.UnitRank = (UnitRankType)rankDr;
			loadout.Stats.UpdateDamageReduction("OTHER", otherDr);

			Assert.That(loadout.Stats.DamageReductionForBinding, Is.EqualTo(expectedDR));
		}

		[TestCase(10, 0, 0, 0, 130)]
		[TestCase(0, 20, 0, 0, 120)]
		[TestCase(0, 0, 20, 0, 200)]
		[TestCase(0, 0, 0, 10, 200)]
		[TestCase(10, 20, 20, 10, 350)]
		public void TestAttack(short perks, short gems, int essence, int infuse, double expected)
		{
			var loadout = new Loadout();
			loadout.ShouldRestrict = false;
			loadout.UseUnitStats = false;
			loadout.CurrentUnit = VUnit.New(UnitType.Probe, loadout);
			var perkCollection = (PerkCollection)loadout.Perks;
			perkCollection.MaximumPotiential.DesiredLevel = 8;
			perkCollection.MaximumPotiential2.DesiredLevel = 10;
			perkCollection.MaximumPotiental3.DesiredLevel = 10;
			perkCollection.MaximumPotential4.DesiredLevel = 10;
			loadout.CurrentUnit.EssenceStacks = 0;
			loadout.CurrentUnit.CurrentInfusion = 0;

			perkCollection.Attack.DesiredLevel = perks;
			loadout.Gems.AttackGem.CurrentLevel = gems;
			loadout.CurrentUnit.EssenceStacks = essence;
			loadout.CurrentUnit.CurrentInfusion = infuse;

			Assert.That(loadout.Stats.AttackForBinding, Is.EqualTo(expected));
		}

		[TestCase(10, 0, 0, 0, 120)]
		[TestCase(0, 20, 0, 0, 120)]
		[TestCase(0, 0, 20, 0, 122.02)]
		[TestCase(0, 0, 0, 10, 200)]
		[TestCase(10, 20, 20, 10, 341.65)]
		public void TestAttackSpeed(short perks, short gems, int essence, int infuse, double expected)
		{
			var loadout = new Loadout();
			loadout.UseUnitStats = false;
			loadout.ShouldRestrict = false;
			loadout.CurrentUnit = VUnit.New(UnitType.Probe, loadout);
			var perkCollection = (PerkCollection)loadout.Perks;
			perkCollection.MaximumPotiential.DesiredLevel = 8;
			perkCollection.MaximumPotiential2.DesiredLevel = 10;
			perkCollection.MaximumPotiental3.DesiredLevel = 10;
			perkCollection.MaximumPotential4.DesiredLevel = 10;
			loadout.CurrentUnit.EssenceStacks = 0;
			loadout.CurrentUnit.CurrentInfusion = 0;

			perkCollection.AttackSpeed.DesiredLevel = perks;
			loadout.Gems.AttackSpeedGem.CurrentLevel = gems;
			loadout.CurrentUnit.EssenceStacks = essence;
			loadout.CurrentUnit.CurrentInfusion = infuse;

			Assert.That(loadout.Stats.AttackSpeedForBinding, Is.EqualTo(expected));
		}

		[TestCase(0, 0, 0, 100)]
		[TestCase(0, 9, 0, 145)]
		[TestCase(5, 0, 0, 150)]
		[TestCase(5, 9, 0, 217)]
		[TestCase(0, 0, 50, 150)]
		[TestCase(0, 9, 50, 217)]
		[TestCase(5, 0, 50, 200)]
		[TestCase(5, 9, 50, 290)]
		public void TestHealth(int infuse, int essence, int stats, double expected)
		{
			// ALl the expected values for this test were generated in game
			var loadout = GetTestLoadout();
			var unit = VUnit.New(UnitType.WarpLord, loadout);
			unit.CurrentInfusion = infuse;
			unit.EssenceStacks = essence;
			loadout.Gems.HealthGem.CurrentLevel = (short)stats;

			Assert.That(loadout.Stats.HealthForBinding, Is.AtLeast(expected-1) & Is.AtMost(expected + 1));
		}

		[TestCase(0, 0, 0, 150)]
		[TestCase(0, 9, 0, 217)]
		[TestCase(5, 0, 0, 225)]
		[TestCase(5, 9, 0, 326)]
		[TestCase(0, 0, 50, 225)]
		[TestCase(0, 9, 50, 326)]
		[TestCase(5, 0, 50, 300)]
		[TestCase(5, 9, 50, 435)]
		public void TestShields(int infuse, int essence, int stats, double expected)
		{
			// All the expected values for this test were generated in game
			var loadout = GetTestLoadout();
			var unit = VUnit.New(UnitType.WarpLord, loadout);
			unit.CurrentInfusion = infuse;
			unit.EssenceStacks = essence;
			loadout.Gems.ShieldsGem.CurrentLevel = (short)stats;

			Assert.That(loadout.Stats.ShieldsForBinding, Is.AtLeast(expected - 1) & Is.AtMost(expected + 1));
		}

		[Test]
		public void TestArmorOverall()
		{
			/// have tested these calculations in game and have them explained here
			/// Unit base armor: 2
			/// Unit armor increment: .35
			/// Upgrade level: 20
			/// Total Raw Armor: 9
			/// 200% player armor = x2
			/// +10 infuse = x2
			/// SSA rank buff = x1.1
			/// Super Omega buff = x1.2 (tooltip says 100% but is only 20% in test
			/// Trifecta bonus buff = x1.1
			/// +25 infuse = +25
			/// total = 9 * 2 * 2 * 1.1 * 1.1 * 1.2 + 25
			/// 77.272 armor total
			var loadout = GetTestLoadout();
			loadout.CurrentUnit = VUnit.New(UnitType.WarpLord, loadout);
			loadout.Upgrades.HealthArmorUpgrade = 20;
			loadout.Upgrades.ShieldsArmorUpgrade = 20;
			loadout.Gems.HealthArmorGem.CurrentLevel = 100;
			loadout.Gems.ShieldsArmorGem.CurrentLevel = 100;
			loadout.CurrentUnit.CurrentInfusion = 10;
			loadout.CurrentUnit.UnitRank = UnitRankType.XDZ;
			((PerkCollection)loadout.Perks).TrifectaPower.DesiredLevel = 15;
			loadout.CurrentUnit.EssenceStacks = 25;

			Assert.That(loadout.Stats.UnitHealthArmor, Is.EqualTo(77.272));
			Assert.That(loadout.Stats.UnitShieldsArmor, Is.EqualTo(77.272));
		}

		VLoadout GetTestLoadout()
		{
			var loadout = new Loadout();
			loadout.ShouldRestrict = false;
			loadout.UseUnitStats = true;
			var perks = (PerkCollection)loadout.Perks;
			perks.MaximumPotiential.DesiredLevel = 8;
			perks.MaximumPotiential2.DesiredLevel = 10;
			perks.MaximumPotiental3.DesiredLevel = 10;
			perks.MaximumPotential4.DesiredLevel = 10;

			return loadout;
		}
	}
}
