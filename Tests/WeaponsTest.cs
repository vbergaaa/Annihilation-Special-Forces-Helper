using NUnit.Framework;
using VEntityFramework.Model;

namespace Tests
{
	[TestFixture]
	public class WeaponsTest
	{
		[TestCase(UnitType.AnnihilationDreadnought, 45132)]
		[TestCase(UnitType.ArchDominator, 37972)]
		[TestCase(UnitType.Archon, 19578)]
		[TestCase(UnitType.Ascendant, 2356)]
		[TestCase(UnitType.BerserkerWarpLord, 14834)]
		[TestCase(UnitType.BladeDancer, 149149)]
		[TestCase(UnitType.BladeMaster, 723123)]
		[TestCase(UnitType.BloodAvenger, 6450)]
		[TestCase(UnitType.Colossus, 47734)]
		[TestCase(UnitType.CrimsonArchon, 216305)]
		[TestCase(UnitType.DarkArchon, 55597)]
		[TestCase(UnitType.DarkAvenger, 3645)]
		[TestCase(UnitType.DarkProbe, 368)]
		[TestCase(UnitType.DarkShadow, 1808)]
		[TestCase(UnitType.DarkShieldBattery, 1577)]
		[TestCase(UnitType.DarkStriker, 6161)]
		[TestCase(UnitType.DarkWarpLord, 8713)]
		[TestCase(UnitType.Disruptor, 41576)]
		[TestCase(UnitType.Dominator, 11368)]
		[TestCase(UnitType.Dragoon, 610)]
		[TestCase(UnitType.Dreadnought, 1924)]
		[TestCase(UnitType.DuplicatorAdept, 87814)]
		[TestCase(UnitType.EvolutionProbe, 1120)]
		[TestCase(UnitType.ForgedAdept, 2995)]
		[TestCase(UnitType.GalacticOrbiter, 6271660)]
		[TestCase(UnitType.HighTemplar, 114927)]
		[TestCase(UnitType.LightAdept, 1383)]
		[TestCase(UnitType.MirrorStriker, 19040)]
		[TestCase(UnitType.OmniBlader, 3446132)]
		[TestCase(UnitType.OrbDancer, 59147)]
		[TestCase(UnitType.OrbOrbiter, 486901)]
		[TestCase(UnitType.ParadoxStriker, 227961)]
		[TestCase(UnitType.Prisoner, 5329)]
		[TestCase(UnitType.Probe, 78)]
		[TestCase(UnitType.PurificationWalker, 105506)]
		[TestCase(UnitType.Reaver, 25148)]
		[TestCase(UnitType.ShieldBattery, 1588)]
		[TestCase(UnitType.SplitterAdept, 6956)]
		[TestCase(UnitType.StonePrisoner, 4542)]
		[TestCase(UnitType.Striker, 2610)]
		[TestCase(UnitType.Templar, 18226)]
		[TestCase(UnitType.TerminatorWarpLord, 43790)]
		[TestCase(UnitType.UnstableDreadnought, 29118)]
		[TestCase(UnitType.WarpLord, 5521)]
		[TestCase(UnitType.WingedArchon, 877348)]
		[TestCase(UnitType.WrathWalker, 14857)]
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
