using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VBusiness.Units;
using VEntityFramework.Model;

namespace VBusiness
{
	public class IncomeManager : VIncomeManager
	{
		public IncomeManager(VLoadout loadout) : base(loadout)
		{
		}

		#region Double Warp

		public override int DoubleWarp
		{
			get => Math.Min(base.DoubleWarp, 100);
			set
			{
				if (base.DoubleWarp < 100)
				{
					base.DoubleWarp = value;
				}
				else
				{
					var difference = value - 100;
					base.DoubleWarp += difference;
				}
			}
		}

		#endregion

		#region Triple Warp

		public override int TripleWarp
		{
			get => Math.Min(base.TripleWarp, 100);
			set
			{
				if (base.TripleWarp < 100)
				{
					base.TripleWarp = value;
				}
				else
				{
					var difference = value - 100;
					base.TripleWarp += difference;
				}
			}
		}

		#endregion

		public override RoomNumber FarmRoom
		{
			get => base.FarmRoom;
			set
			{
				var difficulty = Loadout.UnitConfiguration.Difficulty;
				base.FarmRoom = difficulty.Difficulty != DifficultyLevel.None
					? (RoomNumber)Math.Min((int)value, (int)difficulty.RoomToClear)
					: value;

				RefreshPropertyBinding(nameof(MineralsPerMinute));
				RefreshPropertyBinding(nameof(KillsPerMinute));
				RefreshPropertyBinding(nameof(AdditionalFarmRoom_Visible));
				RefreshPropertyBinding(nameof(AdditionalRoomsLookup));
				BrutaliskOverride.RefreshAllBrutas();
			}
		}

		public override RoomNumber AdditionalFarmRoom
		{
			get
			{
				if (AdditionalRoomsLookup.Contains(base.AdditionalFarmRoom))
				{
					return base.AdditionalFarmRoom;
				}
				return RoomNumber.None;
			}
			set
			{
				if (AdditionalRoomsLookup.Contains(value))
				{
					base.AdditionalFarmRoom = value;
				}

				RefreshPropertyBinding(nameof(MineralsPerMinute));
				RefreshPropertyBinding(nameof(KillsPerMinute));
			}
		}

		public override List<object> AdditionalRoomsLookup
		{
			get
			{
				var list = new List<object>() { RoomNumber.None };

				if (FarmRoom == RoomNumber.Room1 || FarmRoom == RoomNumber.Room2)
				{
					list.Add(RoomNumber.Room3);
					list.Add(RoomNumber.Room4);
				}

				if (FarmRoom == RoomNumber.Room7)
				{
					list.Add(RoomNumber.Room8);
				}

				return list;
			}
		}

		public override bool AdditionalFarmRoom_Visible => FarmRoom == RoomNumber.Room1 || FarmRoom == RoomNumber.Room2 || FarmRoom == RoomNumber.Room7;

		#region UnitCost

		public override double LoadoutKillCost => Loadout.UseUnitCosts ? UnitKillCost : GetFullLoadoutCost().Kills;
		public override double LoadoutMineralCost => Loadout.UseUnitCosts ? UnitMineralCost : GetFullLoadoutCost().Minerals;

		UnitCost GetFullLoadoutCost()
		{
			var unitCosts = new UnitCostHelper(Loadout).GetUnitCost(Loadout.Units);
			if (Loadout.Upgrades.IncludeUpgradesInLoadoutCost)
			{
				unitCosts.Minerals += Loadout.Upgrades.UpgradesCost;
			}
			return unitCosts;
		}

		public override double UnitMineralCost => new UnitCostHelper(Loadout).GetUnitCost(Loadout.CurrentUnit).Minerals;
		public override double UnitKillCost => new UnitCostHelper(Loadout).GetUnitCost(Loadout.CurrentUnit).Kills;

		#endregion

		#region IncomePerWave

		public override double MineralsPerMinute => FarmRoom != RoomNumber.None ? Math.Round(new IncomeCalculator(Loadout).GetMineralsPerMinute(), 1) : 0;
		public override double KillsPerMinute => FarmRoom != RoomNumber.None ? Math.Round(new IncomeCalculator(Loadout).GetKillsPerMinute(), 1) : 0;

		#endregion

		#region BrutaliskOverride

		public override VBrutaliskOverride BrutaliskOverride => fBrutaliskOverride ??= new BrutaliskOverride(this);
		VBrutaliskOverride fBrutaliskOverride;

		#endregion
	}
}
