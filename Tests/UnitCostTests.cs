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
			var loadout = TestHelper.GetEmptyLoadout();
			loadout.AddDoubleWarp(dw);
			loadout.AddTripleWarp(tw);
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
	}
}
