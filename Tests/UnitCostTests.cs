using EnumsNET;
using NUnit.Framework;
using System;
using VBusiness.Units;
using VEntityFramework.Model;

namespace Tests
{
	public class UnitCostTests
	{
		[TestCase(UnitType.WarpLord, 0, 2000, 0)]
		[TestCase(UnitType.WarpLord, 1, 4000, 200)]
		[TestCase(UnitType.WarpLord, 10, 62000, 11000)]
		[TestCase(UnitType.LightAdept, 10, 155000, 11000)]
		[TestCase(UnitType.DarkWarpLord, 0, 30000, 2200)]
		[TestCase(UnitType.DarkWarpLord, 1, 34000, 2600)]
		[TestCase(UnitType.DarkWarpLord, 10, 150000, 19200)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 202000, 17400)]
		[TestCase(UnitType.BerserkerWarpLord, 1, 208000, 18200)]
		[TestCase(UnitType.BerserkerWarpLord, 10, 382000, 46400)]
		[TestCase(UnitType.TerminatorWarpLord, 0, 382000, 46400)]
		[TestCase(UnitType.TerminatorWarpLord, 1, 392000, 47800)]
		[TestCase(UnitType.TerminatorWarpLord, 10, 682000, 93400)]
		[TestCase(UnitType.Prisoner, 5, 159250, 15400)]
		// The test cases below are for sanity and could possibly be wrong
		[TestCase(UnitType.Ascendant, 10, 3367500, 221364.28)]
		[TestCase(UnitType.CrimsonArchon, 10, 4403500, 784046.98)]
		[TestCase(UnitType.WingedArchon, 10, 6078750, 2085314.68)]
		[TestCase(UnitType.BladeMaster, 10, 2304250, 258862.13)]
		[TestCase(UnitType.OmniBlader, 10, 5062750, 1132375.20)]
		[TestCase(UnitType.PurificationWalker, 10, 3972000, 219593.39)]
		public void TestUnitEmptyLoadout(UnitType type, int infuse, double expectedMinerals, double expectedKills)
		{
			var loadout = TestHelper.GetEmptyLoadout();
			var cost = new UnitCostHelper(loadout).GetUnitCost(type, infuse, UnitRankType.None);

			Assert.That(cost.Minerals, Is.EqualTo(expectedMinerals));
			Assert.That(cost.Kills, Is.EqualTo(expectedKills).Within(0.01));
		}

		[TestCase(UnitType.BerserkerWarpLord, 0, 0, 202000)]
		[TestCase(UnitType.BerserkerWarpLord, 100, 0, 101000)]
		[TestCase(UnitType.BerserkerWarpLord, 10, 0, 183636.36)]
		[TestCase(UnitType.BerserkerWarpLord, 50, 20, 106315.789)]
		[TestCase(UnitType.BerserkerWarpLord, 100, 20, 84166.67)]
		public void TestUnitCostWithTWLoadout(UnitType type, int dw, int tw, double expected)
		{
			var loadout = TestHelper.GetEmptyLoadout()
				.AddDoubleWarp(dw)
				.AddTripleWarp(tw);
			var cost = new UnitCostHelper(loadout).GetUnitCost(type, 0, UnitRankType.None);

			Assert.That(cost.Minerals, Is.EqualTo(expected).Within(0.01));
		}

		[Test]
		public void TestAllUnitsHaveCost()
		{
			var loadout = TestHelper.GetEmptyLoadout();
			var helper = new UnitCostHelper(loadout);
			var units = Enums.GetValues<UnitType>();
			foreach (var unit in units)
			{
				if (unit == UnitType.None)
				{
					continue;
				}
				var cost = helper.GetUnitCost(unit, 5, UnitRankType.None);

				Assert.That(cost.Minerals, Is.GreaterThan(0));
				Assert.That(cost.Kills, Is.GreaterThan(0));
			}
		}

		[TestCase(UnitType.WarpLord, 0, 0, 0)]
		[TestCase(UnitType.WarpLord, 1, 0, 200)]
		[TestCase(UnitType.WarpLord, 1, 100, 100)]
		[TestCase(UnitType.WarpLord, 1, 200, 0)]
		[TestCase(UnitType.WarpLord, 1, 300, 0)]
		[TestCase(UnitType.WarpLord, 2, 100, 500)]
		[TestCase(UnitType.WarpLord, 2, 300, 300)]
		[TestCase(UnitType.WarpLord, 5, 800, 2200)]
		[TestCase(UnitType.DarkWarpLord, 0, 0, 2200)]
		[TestCase(UnitType.DarkWarpLord, 0, 100, 1600)]
		[TestCase(UnitType.DarkWarpLord, 1, 100, 1900)]
		[TestCase(UnitType.DarkWarpLord, 0, 200, 1000)]
		[TestCase(UnitType.DarkWarpLord, 1, 200, 1200)]
		[TestCase(UnitType.DarkWarpLord, 1, 300, 1100)]
		[TestCase(UnitType.DarkWarpLord, 2, 300, 1500)]
		[TestCase(UnitType.DarkWarpLord, 0, 2000, 0)]
		[TestCase(UnitType.DarkWarpLord, 1, 2000, 0)]
		[TestCase(UnitType.DarkWarpLord, 2, 2000, 0)]
		[TestCase(UnitType.DarkWarpLord, 3, 2000, 400)]
		[TestCase(UnitType.Dragoon, 2, 400, 200 + 299)] // +299 is for ranks
														// The test cases below are for sanity and could possibly be wrong
		[TestCase(UnitType.ParadoxStriker, 10, 750, 41550)]
		[TestCase(UnitType.OmniBlader, 10, 750, 948175)]
		[TestCase(UnitType.PurificationWalker, 10, 750, 154443)]
		[TestCase(UnitType.WingedArchon, 10, 750, 1871214)]
		public void TestVeterancy(UnitType unit, int infuse, int vet, double expectedCost)
		{
			var loadout = TestHelper.GetEmptyLoadout()
				.AddVeterancy(vet);
			var helper = new UnitCostHelper(loadout);
			var cost = helper.GetUnitCost(unit, infuse, UnitRankType.None).Kills;

			Assert.That(cost, Is.EqualTo(expectedCost).Within(1));
		}

		[TestCase(UnitType.WarpLord, 0, 0, 0, 0)]
		[TestCase(UnitType.WarpLord, 1, 0, 0, 200)]
		[TestCase(UnitType.WarpLord, 1, 0, 50, 150)]
		[TestCase(UnitType.WarpLord, 1, 100, 50, 50)]
		[TestCase(UnitType.WarpLord, 1, 200, 50, -50)]
		[TestCase(UnitType.WarpLord, 1, 600, 50, -50)]
		[TestCase(UnitType.WarpLord, 1, 100, 150, -50)]
		[TestCase(UnitType.WarpLord, 2, 100, 150, 200)]
		[TestCase(UnitType.WarpLord, 2, 600, 150, -300)]
		[TestCase(UnitType.WarpLord, 3, 600, 150, 150)]
		[TestCase(UnitType.DarkWarpLord, 0, 200, 50, 600)]
		[TestCase(UnitType.DarkWarpLord, 0, 400, 100, 0)]
		[TestCase(UnitType.DarkWarpLord, 1, 400, 100, 0)]
		[TestCase(UnitType.DarkWarpLord, 2, 400, 100, 200)]
		[TestCase(UnitType.DarkWarpLord, 0, 600, 200, -1000)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 600, 200, -5600)]
		// The test cases below are for sanity and could possibly be wrong
		[TestCase(UnitType.ParadoxStriker, 10, 600, 200, 400)]
		[TestCase(UnitType.OmniBlader, 10, 600, 200, 772575)]
		[TestCase(UnitType.PurificationWalker, 10, 600, 200, 100193)]
		[TestCase(UnitType.WingedArchon, 10, 600, 200, 1675314)]
		public void TestInfuseRecycle(UnitType unit, int infuse, int vet, int infuseRecycle, double expectedCost)
		{
			var loadout = TestHelper.GetEmptyLoadout()
				.AddVeterancy(vet)
				.AddInfuseRecycle(infuseRecycle);
			var helper = new UnitCostHelper(loadout);
			var cost = helper.GetUnitCost(unit, infuse, UnitRankType.None).Kills;

			Assert.That(cost, Is.EqualTo(expectedCost).Within(1));
		}

		[TestCase(UnitType.WarpLord, 1, 0, 0, 200)]
		[TestCase(UnitType.WarpLord, 1, 100, 0, 100)]
		[TestCase(UnitType.WarpLord, 1, 0, 25, 200)]
		[TestCase(UnitType.WarpLord, 1, 100, 25, 75)]
		[TestCase(UnitType.WarpLord, 1, 200, 25, -50)]
		[TestCase(UnitType.WarpLord, 1, 200, 5, -10)]
		[TestCase(UnitType.WarpLord, 1, 600, 25, -150)]
		[TestCase(UnitType.WarpLord, 2, 600, 25, -300)]
		[TestCase(UnitType.WarpLord, 3, 600, 25, 150)]
		[TestCase(UnitType.DarkWarpLord, 0, 1600, 25, -3650)]
		[TestCase(UnitType.DarkWarpLord, 0, 600, 25, -700)]
		[TestCase(UnitType.DarkWarpLord, 1, 600, 25, -750)]
		[TestCase(UnitType.DarkWarpLord, 2, 600, 25, -600)]
		[TestCase(UnitType.DarkWarpLord, 3, 600, 25, -400)]
		[TestCase(UnitType.DarkWarpLord, 4, 600, 25, 0)]
		[TestCase(UnitType.DarkWarpLord, 5, 600, 25, 450)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 600, 25, -2550)]
		// The test cases below are for sanity and could possibly be wrong
		[TestCase(UnitType.ParadoxStriker, 10, 600, 25, 14950)]
		[TestCase(UnitType.OmniBlader, 10, 600, 25, 831175)]
		[TestCase(UnitType.PurificationWalker, 10, 600, 25, 101043)]
		[TestCase(UnitType.WingedArchon, 10, 600, 25, 1741114)]
		public void TestKillRecycle(UnitType unit, int infuse, int vet, int killRecycle, double expectedCost)
		{
			var loadout = TestHelper.GetEmptyLoadout()
				.AddVeterancy(vet)
				.AddKillRecycle(killRecycle);
			var helper = new UnitCostHelper(loadout);
			var cost = helper.GetUnitCost(unit, infuse, UnitRankType.None).Kills;

			Assert.That(cost, Is.EqualTo(expectedCost).Within(1));
		}

		[TestCase(UnitType.WarpLord, 0, 0, 0, 2000, 0)]
		[TestCase(UnitType.WarpLord, 0, 1, 0, 2000, 0)]
		[TestCase(UnitType.WarpLord, 2, 0, 0, 6000, 600)]
		[TestCase(UnitType.WarpLord, 2, 1, 0, 6000, 600)]
		[TestCase(UnitType.WarpLord, 3, 0, 0, 10000, 1200)]
		[TestCase(UnitType.WarpLord, 3, 1, 0, 2000, 0)]
		[TestCase(UnitType.WarpLord, 4, 0, 0, 14000, 2000)]
		[TestCase(UnitType.WarpLord, 4, 1, 0, 6000, 800)]
		[TestCase(UnitType.WarpLord, 4, 2, 0, 6000, 800)]
		[TestCase(UnitType.WarpLord, 4, 1, 200, 6000, 600)]
		[TestCase(UnitType.DarkWarpLord, 0, 0, 200, 30000, 1000)]
		[TestCase(UnitType.DarkWarpLord, 0, 1, 200, 22000, 0)]
		[TestCase(UnitType.DarkWarpLord, 1, 1, 200, 26000, 0)]
		[TestCase(UnitType.DarkWarpLord, 2, 1, 200, 30000, 400)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 0, 200, 202000, 8800)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 1, 200, 194000, 7600)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 2, 200, 186000, 6400)]
		[TestCase(UnitType.BerserkerWarpLord, 0, 3, 200, 178000, 5200)]
		public void TestQuickStart(UnitType unit, int infuse, int qsCharges, int vet, double expectedMins, double expectedKills)
		{
			var loadout = TestHelper.GetEmptyLoadout()
				.AddVeterancy(vet)
				.AddQuickStartCharges(qsCharges);
			var helper = new UnitCostHelper(loadout);
			var cost = helper.GetUnitCost(unit, infuse, UnitRankType.None);

			Assert.That(cost.Minerals, Is.EqualTo(expectedMins).Within(1));
			Assert.That(cost.Kills, Is.EqualTo(expectedKills).Within(1));
		}

		[TestCase(UnitType.WarpLord, 4, 1, 200, 50, 0, 6000, 550)]
		[TestCase(UnitType.WarpLord, 4, 1, 200, 0, 25, 6000, 550)]
		public void TestQuickStartIntegration(UnitType unit, int infuse, int qsCharges, int vet, int infuseRecycle, int killRecycle, double expectedMins, double expectedKills)
		{
			var loadout = TestHelper.GetEmptyLoadout()
				.AddVeterancy(vet)
				.AddInfuseRecycle(infuseRecycle)
				.AddKillRecycle(killRecycle)
				.AddQuickStartCharges(qsCharges);
			var helper = new UnitCostHelper(loadout);
			var cost = helper.GetUnitCost(unit, infuse, UnitRankType.None);

			Assert.That(cost.Minerals, Is.EqualTo(expectedMins).Within(1));
			Assert.That(cost.Kills, Is.EqualTo(expectedKills).Within(1));
		}
	}
}
