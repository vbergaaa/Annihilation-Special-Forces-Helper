﻿using VBusiness.Rooms;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VIncomeManager : BusinessObject
	{
		public VIncomeManager(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout;
		}
		public override string BizoName => "IncomeManager";

		#region Double Warp

		public virtual int DoubleWarp
		{
			get => fDoubleWarp;
			set
			{
				if (fDoubleWarp != value)
				{
					fDoubleWarp = value;
					RefreshPropertyBinding(nameof(DoubleWarp));
					RefreshPropertyBinding(nameof(LoadoutMineralCost));
				}
			}
		}
		int fDoubleWarp;

		#endregion

		#region Triple Warp

		public virtual int TripleWarp
		{
			get => fTripleWarp;
			set
			{
				if (fTripleWarp != value)
				{
					fTripleWarp = value;
					RefreshPropertyBinding(nameof(TripleWarp));
					RefreshPropertyBinding(nameof(LoadoutMineralCost));
				}
			}
		}
		int fTripleWarp;

		#endregion

		#region Rank Revision

		public virtual int RankRevision
		{
			get => fRankRevision;
			set
			{
				if (fRankRevision != value)
				{
					fRankRevision = value;
					RefreshPropertyBinding(nameof(RankRevision));
					RefreshPropertyBinding(nameof(LoadoutKillCost));
				}
			}
		}
		int fRankRevision;

		#endregion

		#region HasRefundSoul

		public bool HasRefundSoul
		{
			get => fHasRefundSoul;
			set
			{
				if (fHasRefundSoul != value)
				{
					fHasRefundSoul = value;
					RefreshPropertyBinding(nameof(LoadoutKillCost));
				}
			}
		}
		bool fHasRefundSoul;

		#endregion

		#region Veterency

		public int Veterancy
		{
			get => fVeterency;
			set
			{
				if (fVeterency != value)
				{
					fVeterency = value;
					RefreshPropertyBinding(nameof(Veterancy));
					RefreshPropertyBinding(nameof(LoadoutKillCost));
				}
			}
		}
		int fVeterency;

		#endregion

		#region InfuseRecycle

		public int InfuseRecycle
		{
			get => fInfuseRecycle;
			set
			{
				if (fInfuseRecycle != value)
				{
					fInfuseRecycle = value;
					RefreshPropertyBinding(nameof(InfuseRecycle));
					RefreshPropertyBinding(nameof(LoadoutKillCost));
				}
			}
		}
		int fInfuseRecycle;

		#endregion

		#region KillRecycle

		public int KillRecycle
		{
			get => fKillRecycle;
			set
			{
				if (fKillRecycle != value)
				{
					fKillRecycle = value;
					RefreshPropertyBinding(nameof(KillRecycle));
					RefreshPropertyBinding(nameof(LoadoutKillCost));
				}
			}
		}
		int fKillRecycle;

		#endregion

		#region MineralJackpot

		public int MineralJackpot
		{
			get => fMineralJackpot;
			set
			{
				if (fMineralJackpot != value)
				{
					fMineralJackpot = value;
					RefreshPropertyBinding(nameof(MineralJackpot));
					RefreshPropertyBinding(nameof(MineralsPerMinute));
					RefreshPropertyBinding(nameof(KillsPerMinute));
				}
			}
		}
		int fMineralJackpot;

		#endregion

		#region SuperJackpot

		public int SuperJackpot
		{
			get => fSuperJackpot;
			set
			{
				if (fSuperJackpot != value)
				{
					fSuperJackpot = value;
					RefreshPropertyBinding(nameof(SuperJackpot));
					RefreshPropertyBinding(nameof(MineralsPerMinute));
					RefreshPropertyBinding(nameof(KillsPerMinute));
				}
			}
		}
		int fSuperJackpot;

		#endregion

		public virtual double LoadoutMineralCost { get; }
		public virtual double LoadoutKillCost { get; }
		public virtual double UnitMineralCost { get; }
		public virtual double UnitKillCost { get; }
		public virtual double MineralsPerMinute { get; }
		public virtual double KillsPerMinute { get; }

		#region Persistent Properties

		#region FarmRoom

		[VXML(true)]
		public virtual RoomNumber FarmRoom
		{
			get => fFarmRoom;
			set
			{
				if (value != fFarmRoom)
				{
					fFarmRoom = value;
					HasChanges = true;
					OnPropertyChanged(nameof(FarmRoom));
				}
			}
		}
		RoomNumber fFarmRoom;

		#endregion

		#region BrutaliskOverride

		public virtual VBrutaliskOverride BrutaliskOverride { get; }

		#endregion

		#endregion

		[VXML(false)]
		public VLoadout Loadout { get; }
	}
}
