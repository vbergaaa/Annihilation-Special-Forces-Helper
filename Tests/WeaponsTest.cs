using NUnit.Framework;
using VEntityFramework.Model;

namespace Tests
{
	[TestFixture]
	public class WeaponsTest
	{
		[TestCase(UnitType.AnnihilationDreadnought, 46354)]
		[TestCase(UnitType.ArchDominator, 38330)]
		[TestCase(UnitType.Archon, 20102)]
		[TestCase(UnitType.Ascendant, 2409)]
		[TestCase(UnitType.BerserkerWarpLord, 15814)]
		[TestCase(UnitType.BladeDancer, 44906)]
		[TestCase(UnitType.BladeMaster, 102053)]
		[TestCase(UnitType.BloodAvenger, 6580)]
		[TestCase(UnitType.Colossus, 48352)]
		[TestCase(UnitType.CrimsonArchon, 218583)]
		[TestCase(UnitType.DarkArchon, 56477)]
		[TestCase(UnitType.DarkAvenger, 3726)]
		[TestCase(UnitType.DarkProbe, 424)]
		[TestCase(UnitType.DarkShadow, 1880)]
		[TestCase(UnitType.DarkShieldBattery, 1858)]
		[TestCase(UnitType.DarkStriker, 6521)]
		[TestCase(UnitType.DarkWarpLord, 9028)]
		[TestCase(UnitType.Disruptor, 42499)]
		[TestCase(UnitType.Dominator, 11533)]
		[TestCase(UnitType.Dragoon, 669)]
		[TestCase(UnitType.Dreadnought, 2105)]
		[TestCase(UnitType.EvolutionProbe, 1193)]
		[TestCase(UnitType.ForgedAdept, 3075)]
		[TestCase(UnitType.HighTemplar, 116391)]
		[TestCase(UnitType.LightAdept, 1459)]
		[TestCase(UnitType.MirrorStriker, 19654)]
		[TestCase(UnitType.OmniBlader, 259251)]
		[TestCase(UnitType.ParadoxStriker, 232786)]
		[TestCase(UnitType.Prisoner, 6034)]
		[TestCase(UnitType.Probe, 107)]
		[TestCase(UnitType.PurificationWalker, 108986)]
		[TestCase(UnitType.Reaver, 25848)]
		[TestCase(UnitType.ShieldBattery, 1869)]
		[TestCase(UnitType.SplitterAdept, 7741)]
		[TestCase(UnitType.StonePrisoner, 5129)]
		[TestCase(UnitType.Striker, 2859)]
		[TestCase(UnitType.Templar, 18544)]
		[TestCase(UnitType.TerminatorWarpLord, 44732)]
		[TestCase(UnitType.UnstableDreadnought, 29990)]
		[TestCase(UnitType.WarpLord, 5745)]
		[TestCase(UnitType.WingedArchon, 884780)]
		[TestCase(UnitType.WrathWalker, 15093)]
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
