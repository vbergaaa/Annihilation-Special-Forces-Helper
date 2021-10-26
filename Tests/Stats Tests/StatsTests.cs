using NUnit.Framework;
using VBusiness.Loadouts;
using VBusiness.Perks;
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
			var loadout = TestHelper.GetTestLoadout();
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

		[Test]
		public void TestAttackOverall()
		{
			/// have tested these calculations in game and have them explained here
			/// Unit base atk: 11
			/// Unit armor increment: .6
			/// Upgrade level: 30
			/// Total Raw Armor: 29
			/// 200% player atk = +100%
			/// +10 infuse = +100%
			/// Z rank buff = +20%
			/// Super Omega buff = +100%
			/// Trifecta bonus buff = +30% (+15% without cache)
			/// +24 essence = +120%
			/// Adrenaline+super rush = +20%
			/// total = 29 + 490% 
			/// total = 171.1

			var loadout = GetTestLoadout();
			loadout.CurrentUnit = VUnit.New(UnitType.WarpLord, loadout);
			loadout.Upgrades.AttackUpgrade = 30;
			loadout.Gems.AttackGem.CurrentLevel = 100;
			loadout.CurrentUnit.CurrentInfusion = 10;
			loadout.CurrentUnit.UnitRank = UnitRankType.XDZ;
			((PerkCollection)loadout.Perks).TrifectaPower.DesiredLevel = 15;
			((PerkCollection)loadout.Perks).UpgradeCache.DesiredLevel = 1;
			((PerkCollection)loadout.Perks).AdrenalineRush.DesiredLevel = 15;
			((PerkCollection)loadout.Perks).SuperRush.DesiredLevel = 10;
			loadout.CurrentUnit.EssenceStacks = 24;

			Assert.That(loadout.Stats.UnitAttack, Is.EqualTo(171.1));
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

		[Test]
		public void TestAtkSpeedOverall()
		{
			/// have tested these calculations in game and have them explained here
			/// Unit base atk speed: 1.5
			/// Upgrade level: x0.96%^5
			/// Total Raw Armor: 1.223
			/// 120% player atk speed = / 1.2
			/// x10 infuse = / 2
			/// Z rank buff = / 1.15
			/// Super Omega buff = / 2
			/// Trifecta bonus buff = / 1.3
			/// x25 essence = / 1.01^25
			/// Adrenaline+super rush = /1.2
			/// Accel = / 1.2
			/// Void Buff = / 2
			/// total = 1.22305 / (26.5032)
			/// total = 0.04615

			var loadout = GetTestLoadout();
			loadout.CurrentUnit = VUnit.New(UnitType.WarpLord, loadout);
			loadout.Upgrades.AttackSpeedUpgrade = 5;
			loadout.Gems.AttackSpeedGem.CurrentLevel = 20;
			loadout.CurrentUnit.CurrentInfusion = 10;
			loadout.CurrentUnit.UnitRank = UnitRankType.XYZ;
			((PerkCollection)loadout.Perks).TrifectaPower.DesiredLevel = 15;
			((PerkCollection)loadout.Perks).UpgradeCache.DesiredLevel = 1;
			((PerkCollection)loadout.Perks).AdrenalineRush.DesiredLevel = 15;
			((PerkCollection)loadout.Perks).SuperRush.DesiredLevel = 10;
			((PerkCollection)loadout.Perks).Alacrity2.DesiredLevel = 20;
			loadout.CurrentUnit.EssenceStacks = 25;

			Assert.That(loadout.Stats.UnitAttackSpeed, Is.EqualTo(0.0462).Within(0.0001));
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

			Assert.That(loadout.Stats.HealthForBinding, Is.AtLeast(expected - 1) & Is.AtMost(expected + 1));
		}

		[Test]
		public void TestHealthAndShieldsOverall()
		{
			/// have tested these calculations in game and have them explained here
			/// Unit base armor: 100
			/// 200% player health = +100%
			/// +10 infuse = +100%
			/// SSA rank buff = +10%
			/// Super Omega buff = +100%
			/// Trifecta bonus buff = +30%
			/// +25 infuse = x 225%
			/// total = 100 + 340% * 2.25
			/// = 440 * 2.25
			/// = 990 health total
			/// BaseShields = 150 so 1485 total
			var loadout = GetTestLoadout();
			loadout.CurrentUnit = VUnit.New(UnitType.WarpLord, loadout);
			loadout.Gems.HealthGem.CurrentLevel = 100;
			loadout.Gems.ShieldsGem.CurrentLevel = 100;
			loadout.CurrentUnit.CurrentInfusion = 10;
			loadout.CurrentUnit.UnitRank = UnitRankType.XDZ;
			((PerkCollection)loadout.Perks).TrifectaPower.DesiredLevel = 15;
			((PerkCollection)loadout.Perks).UpgradeCache.DesiredLevel = 15;
			loadout.CurrentUnit.EssenceStacks = 25;

			Assert.That(loadout.Stats.UnitHealth, Is.EqualTo(990).Within(0.001));
			Assert.That(loadout.Stats.UnitShields, Is.EqualTo(1485).Within(0.001));
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
			var perks = (PerkCollection)loadout.Perks;
			perks.MaximumPotiential.DesiredLevel = 8;
			perks.MaximumPotiential2.DesiredLevel = 10;
			perks.MaximumPotiental3.DesiredLevel = 10;
			perks.MaximumPotential4.DesiredLevel = 10;

			return loadout;
		}
	}
}
