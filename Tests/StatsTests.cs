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
			loadout.CurrentUnit.UnitRank = (VEntityFramework.Model.UnitRank)rankDr;
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
