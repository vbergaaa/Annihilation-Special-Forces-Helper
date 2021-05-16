using System;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace Tests
{
	public static class TestHelper
	{
		public static VLoadout GetEmptyLoadout()
		{
			var loadout = new Loadout()
			{
				UseUnitStats = true,
				ShouldRestrict = false,
			};
			loadout.Perks.MaximumPotiential.DesiredLevel = 8;
			loadout.Perks.MaximumPotiential2.DesiredLevel = 10;
			loadout.Perks.MaximumPotiental3.DesiredLevel = 10;
			loadout.Perks.MaximumPotential4.DesiredLevel = 10;

			return loadout;
		}

		public static VLoadout GetMaxDWLoadout()
		{
			var loadout = GetEmptyLoadout();
			loadout.Perks.DoubleWarp.DesiredLevel = loadout.Perks.DoubleWarp.MaxLevel;
			loadout.Perks.DoubleWarp4.DesiredLevel = loadout.Perks.DoubleWarp4.MaxLevel;
			loadout.Perks.DoubleWarp2.DesiredLevel = loadout.Perks.DoubleWarp2.MaxLevel;
			loadout.Perks.DoubleWarp3.DesiredLevel = loadout.Perks.DoubleWarp3.MaxLevel;
			return loadout;
		}

		public static VLoadout AddDoubleWarp(this VLoadout loadout, int dw)
		{
			loadout.IncomeManager.DoubleWarp += dw;
			return loadout;
		}

		public static VLoadout AddTripleWarp(this VLoadout loadout, int tw)
		{
			loadout.IncomeManager.TripleWarp += tw;
			return loadout;
		}

		public static VLoadout AddVeterancy(this VLoadout loadout, int vet)
		{
			loadout.IncomeManager.Veterancy += vet;
			return loadout;
		}
	}
}
