﻿using VBusiness.Loadouts;
using VBusiness.Rooms;
using VEntityFramework;
using VEntityFramework.Model;

namespace Tests
{
	public static class TestHelper
	{
		public static VLoadout GetTestLoadout()
		{
			var loadout = GetEmptyLoadout();
			loadout.Perks.MaximumPotiential.DesiredLevel = 8;
			loadout.Perks.MaximumPotiential2.DesiredLevel = 10;
			loadout.Perks.MaximumPotiental3.DesiredLevel = 10;
			loadout.Perks.MaximumPotential4.DesiredLevel = 10;

			return loadout;
		}

		public static VLoadout GetEmptyLoadout()
		{
			var loadout = new Loadout()
			{
				ShouldRestrict = false,
			};

			return loadout;
		}

		public static VLoadout GetMaxDWLoadout()
		{
			var loadout = GetTestLoadout();
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

		public static VLoadout AddInfuseRecycle(this VLoadout loadout, int infuseRec)
		{
			loadout.IncomeManager.InfuseRecycle += infuseRec;
			return loadout;
		}

		public static VLoadout AddKillRecycle(this VLoadout loadout, int kr)
		{
			loadout.Perks.KillRecycle.DesiredLevel = (byte)(kr / 5);
			return loadout;
		}

		public static VLoadout AddQuickStartCharges(this VLoadout loadout, int charges)
		{
			loadout.Perks.QuickStart.DesiredLevel += (byte)charges;
			return loadout;
		}

		public static VLoadout AddDNAStartLevel(this VLoadout loadout, int level)
		{
			loadout.Perks.DNAStart.DesiredLevel += (byte)level;
			return loadout;
		}

		public static VLoadout AddBlackMarket(this VLoadout loadout, bool addBM = true)
		{
			loadout.Perks.BlackMarket.DesiredLevel = (short)(addBM ? 1 : 0);
			return loadout;
		}

		public static VLoadout SetSpec(this VLoadout loadout, UnitType spec, int specLevel = 10, bool hasAllSpec = false)
		{
			loadout.UnitSpec = spec;
			loadout.Perks.UnitSpecialization.DesiredLevel = (short)specLevel;

			if (hasAllSpec)
			{
				ErrorReporter.ReportDebug("spec level must be 10 if you want all spec", () => specLevel != 10);
				loadout.Perks.UpgradeCache.DesiredLevel = 1;
			}
			return loadout;
		}

		public static VLoadout AddUpgradeCache(this VLoadout loadout, bool cache = true)
		{
			loadout.Perks.UpgradeCache.DesiredLevel = (short)(cache ? 1 : 0);
			return loadout;
		}

		public static VLoadout SetDifficulty(this VLoadout loadout, DifficultyLevel level)
		{
			loadout.UnitConfiguration.DifficultyLevel = level;
			return loadout;
		}

		public static VLoadout SetFarmRoom(this VLoadout loadout, RoomNumber room)
		{
			loadout.IncomeManager.FarmRoom = room;

			if (room == RoomNumber.Room7)
			{
				loadout.IncomeManager.AdditionalFarmRoom = RoomNumber.Room8;
			}
			return loadout;
		}
	}
}
