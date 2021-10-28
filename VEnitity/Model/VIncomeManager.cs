using VBusiness.Rooms;
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

		#region MaximumGather

		public double MaximumGather
		{
			get => fMaximumGather;
			set
			{
				if (fMaximumGather != value)
				{
					fMaximumGather = value;
					RefreshPropertyBinding(nameof(MaximumGather));
					RefreshPropertyBinding(nameof(KillsPerMinute));
				}
			}
		}
		double fMaximumGather;

		#endregion

		#region HasUrusy

		public bool HasUrusy
		{
			get => fHasUrusy;
			set
			{
				if (fHasUrusy != value)
				{
					fHasUrusy = value;
					RefreshPropertyBinding(nameof(HasUrusy));
					RefreshPropertyBinding(nameof(MineralsPerMinute));
				}
			}
		}
		bool fHasUrusy;

		#endregion

		#region HasGreed

		public bool HasGreed
		{
			get => fHasGreed;
			set
			{
				if (fHasGreed != value)
				{
					fHasGreed = value;
					RefreshPropertyBinding(nameof(HasGreed));
					RefreshPropertyBinding(nameof(KillsPerMinute));
				}
			}
		}
		bool fHasGreed;

		#endregion

		#region HasSales

		public bool HasSales
		{
			get => fHasSales;
			set
			{
				if (fHasSales != value)
				{
					fHasSales = value;
					RefreshPropertyBinding(nameof(HasSales));
					RefreshPropertyBinding(nameof(UnitMineralCost));
				}
			}
		}
		bool fHasSales;

		#endregion

		#region HasRSS

		public bool HasRSS
		{
			get => fHasRSS;
			set
			{
				if (fHasRSS != value)
				{
					fHasRSS = value;
					RefreshPropertyBinding(nameof(HasRSS));
					RefreshPropertyBinding(nameof(UnitKillCost));
				}
			}
		}
		bool fHasRSS;

		#endregion

		#region HasRSS

		public bool HasRSSS
		{
			get => fHasRSSS;
			set
			{
				if (fHasRSSS != value)
				{
					fHasRSSS = value;
					RefreshPropertyBinding(nameof(HasRSSS));
					RefreshPropertyBinding(nameof(UnitKillCost));
				}
			}
		}
		bool fHasRSSS;

		#endregion

		#region HasInfinitySpawner

		[VXML(true)]
		public bool HasInfinitySpawner
		{
			get => fHasInfinitySpawner;
			set
			{
				if (fHasInfinitySpawner != value)
				{
					fHasInfinitySpawner = value;
					RefreshPropertyBinding(nameof(HasInfinitySpawner));
					RefreshPropertyBinding(nameof(MineralsPerMinute));
					RefreshPropertyBinding(nameof(KillsPerMinute));
				}
			}
		}
		bool fHasInfinitySpawner;

		#endregion

		public virtual double LoadoutMineralCost { get; }
		public virtual double LoadoutKillCost { get; }
		public virtual double UnitMineralCost { get; }
		public virtual double UnitKillCost { get; }
		public virtual double MineralsPerMinute { get; }
		public virtual double KillsPerMinute { get; }

		#region Persistent Properties

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

		[VXML(true)]
		public virtual RoomNumber AdditionalFarmRoom
		{
			get => fAdditionalFarmRoom;
			set
			{
				if (value != fAdditionalFarmRoom)
				{
					fAdditionalFarmRoom = value;
					HasChanges = true;
					OnPropertyChanged(nameof(AdditionalFarmRoom));
				}
			}
		}
		RoomNumber fAdditionalFarmRoom;

		#region BrutaliskOverride

		public virtual VBrutaliskOverride BrutaliskOverride { get; }

		#endregion

		#endregion

		[VXML(false)]
		public VLoadout Loadout { get; }
	}
}
