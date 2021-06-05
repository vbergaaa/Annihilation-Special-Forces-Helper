﻿using System;
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

		#region FarmRoom

		public override RoomNumber FarmRoom
		{
			get => base.FarmRoom;
			set
			{
				base.FarmRoom = value;
				RefreshPropertyBinding(nameof(MineralsPerWave));
				RefreshPropertyBinding(nameof(KillsPerWave));
			}
		}

		#endregion

		#region UnitCost

		public override double LoadoutKillCost => Loadout.UseSingleUnitEco ? UnitKillCost : GetFullLoadoutCost().Kills;
		public override double LoadoutMineralCost => Loadout.UseSingleUnitEco ? UnitMineralCost : GetFullLoadoutCost().Minerals;

		UnitCost GetFullLoadoutCost()
		{
			var unitCosts = new UnitCostHelper(Loadout).GetUnitCost(Loadout.Units);
			unitCosts.Minerals += Loadout.Upgrades.UpgradesCost;
			return unitCosts;
		}

		public override double UnitMineralCost => new UnitCostHelper(Loadout).GetUnitCost(Loadout.CurrentUnit).Minerals;
		public override double UnitKillCost => new UnitCostHelper(Loadout).GetUnitCost(Loadout.CurrentUnit).Kills;

		#endregion

		#region IncomePerWave

		public override double MineralsPerWave => FarmRoom != RoomNumber.None ? new IncomeCalculator(Loadout).GetMineralsPerWave() : 0;
		public override double KillsPerWave => FarmRoom != RoomNumber.None ? new IncomeCalculator(Loadout).GetKillsPerWave() : 0;

		#endregion
	}
}
