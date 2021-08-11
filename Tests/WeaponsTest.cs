using NUnit.Framework;
using VEntityFramework.Model;

namespace Tests
{
	[TestFixture]
	public class WeaponsTest
	{
		[TestCase(UnitType.AnnihilationDreadnought, 15539)]
		[TestCase(UnitType.ArchDominator, 5552)]
		[TestCase(UnitType.Archon, 2154)]
		[TestCase(UnitType.Ascendant, 2308)]
		[TestCase(UnitType.BerserkerWarpLord, 4318)]
		[TestCase(UnitType.BladeDancer, 44906)]
		[TestCase(UnitType.BladeMaster, 102053)]
		[TestCase(UnitType.BloodAvenger, 6033)]
		[TestCase(UnitType.Colossus, 4799)]
		[TestCase(UnitType.CrimsonArchon, 117892)]
		[TestCase(UnitType.DarkArchon, 32724)]
		[TestCase(UnitType.DarkAvenger, 3726)]
		[TestCase(UnitType.DarkProbe, 424)]
		[TestCase(UnitType.DarkShadow, 1880)]
		[TestCase(UnitType.DarkShieldBattery, -1636)]
		[TestCase(UnitType.DarkStriker, 2820)]
		[TestCase(UnitType.DarkWarpLord, 1007)]
		[TestCase(UnitType.Disruptor, 37745)]
		[TestCase(UnitType.Dominator, 3381)]
		[TestCase(UnitType.Dragoon, 669)]
		[TestCase(UnitType.Dreadnought, 2105)]
		[TestCase(UnitType.EvolutionProbe, 1193)]
		[TestCase(UnitType.ForgedAdept, 2756)]
		[TestCase(UnitType.HighTemplar, 596)]
		[TestCase(UnitType.LightAdept, 1459)]
		[TestCase(UnitType.MirrorStriker, 8934)]
		[TestCase(UnitType.OmniBlader, 259251)]
		[TestCase(UnitType.ParadoxStriker, 20424)]
		[TestCase(UnitType.Prisoner, 3669)]
		[TestCase(UnitType.Probe, 107)]
		[TestCase(UnitType.PurificationWalker, 6545)]
		[TestCase(UnitType.Reaver, 18627)]
		[TestCase(UnitType.ShieldBattery, -1091)]
		[TestCase(UnitType.SplitterAdept, 2692)]
		[TestCase(UnitType.StonePrisoner, 2192)]
		[TestCase(UnitType.Striker, 1110)]
		[TestCase(UnitType.Templar, 596)]
		[TestCase(UnitType.TerminatorWarpLord, 24031)]
		[TestCase(UnitType.UnstableDreadnought, 5938)]
		[TestCase(UnitType.WarpLord, 397)]
		[TestCase(UnitType.WingedArchon, 323391)]
		[TestCase(UnitType.WrathWalker, 8691)]
		public void TestWeaponDamage(UnitType unit, double expectedDamage)
		{
			var loadout = TestHelper.GetTestLoadout();
			loadout.UnitConfiguration.DifficultyLevel = DifficultyLevel.Hell;
			loadout.Upgrades.AttackUpgrade = 100;
			loadout.Upgrades.AttackSpeedUpgrade = 15;
			loadout.Gems.AttackGem.CurrentLevel = 200;
			loadout.Gems.AttackSpeedGem.CurrentLevel = 100;
			loadout.Units.Add(VUnit.New(unit, loadout));
			loadout.CurrentUnit.CurrentInfusion = 5;
			loadout.CurrentUnit.EssenceStacks = 2500;
			loadout.CurrentUnit.UnitRank = UnitRankType.XX;

			Assert.That(loadout.Stats.Damage, Is.EqualTo(expectedDamage).Within(1));
		}
	}
}
