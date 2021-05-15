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

		public static void AddDoubleWarp(this VLoadout loadout, int dw)
		{
			loadout.Perks.DoubleWarp.DesiredLevel = (short)Math.Max(0, dw);
			loadout.Perks.DoubleWarp2.DesiredLevel = (short)Math.Max(0, dw - 10);
			loadout.Perks.DoubleWarp3.DesiredLevel = (short)Math.Max(0, dw - 30);
			loadout.Perks.DoubleWarp4.DesiredLevel = (short)Math.Max(0, dw - 60);
		}

		public static void AddTripleWarp(this VLoadout loadout, int tw)
		{
			loadout.Perks.TripleWarp.DesiredLevel = (short)Math.Max(0, tw);
			loadout.Perks.TripleWarp2.DesiredLevel = (short)Math.Max(0, tw - 10);
			loadout.Gems.TripleWarpGem.CurrentLevel = (short)Math.Max(0, tw - 30);
		}
	}
}
