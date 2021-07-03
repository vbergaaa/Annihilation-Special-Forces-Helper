using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VPerkCollection : BusinessObject
	{
		#region Constructor

		public VPerkCollection(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout ?? throw new ArgumentException(nameof(loadout));
		}

		#endregion

		#region Properties

		#region Perks

		public virtual VPerk Attack { get; }
		public virtual VPerk AttackSpeed { get; }
		public virtual VPerk Health { get; }
		public virtual VPerk HealthArmor { get; }
		public virtual VPerk Shields { get; }
		public virtual VPerk ShieldsArmor { get; }
		public virtual VPerk KillEfficiency { get; }
		public virtual VPerk KillRecycle { get; }
		public virtual VPerk MaximumPotiential { get; }
		public virtual VPerk Veterancy { get; }
		public virtual VPerk Rank { get; }
		public virtual VPerk InfusionRecycle { get; }
		public virtual VPerk DoubleWarp { get; }
		public virtual VPerk StartingMinerals { get; }
		public virtual VPerk MasterTrainer { get; }
		public virtual VPerk ExtraSupply { get; }
		public virtual VPerk MineralJackpot { get; }
		public virtual VPerk AutomaticRefinery { get; }
		public virtual VPerk AdrenalineRush { get; }
		public virtual VPerk CriticalChance { get; }
		public virtual VPerk CriticalDamage { get; }
		public virtual VPerk DamageReduction { get; }
		public virtual VPerk OverSpeed { get; }
		public virtual VPerk UnitSpecialization { get; }
		public virtual VPerk KillEfficiency2 { get; }
		public virtual VPerk MaximumGather { get; }
		public virtual VPerk MaximumPotiential2 { get; }
		public virtual VPerk QuickStart { get; }
		public virtual VPerk RankRevision { get; }
		public virtual VPerk Veterancy2 { get; }
		public virtual VPerk BuildingRecycle { get; }
		public virtual VPerk CriticalCollection { get; }
		public virtual VPerk CriticalHarvest { get; }
		public virtual VPerk DoubleWarp2 { get; }
		public virtual VPerk ExpertMiner { get; }
		public virtual VPerk MineralJackpot2 { get; }
		public virtual VPerk AcceleratedFusion { get; }
		public virtual VPerk FastLearner { get; }
		public virtual VPerk MiningExpertise { get; }
		public virtual VPerk TrainingCenter { get; }
		public virtual VPerk TrifectaPower { get; }
		public virtual VPerk UnitStorage { get; }
		public virtual VPerk Alacrity { get; }
		public virtual VPerk BalancedTraining { get; }
		public virtual VPerk CooldownSpeed { get; }
		public virtual VPerk CriticalChance2 { get; }
		public virtual VPerk CriticalDamage2 { get; }
		public virtual VPerk RedCrits { get; }
		public virtual VPerk InfusionRecycle2 { get; }
		public virtual VPerk KillHarvest { get; }
		public virtual VPerk MaximumGather2 { get; }
		public virtual VPerk MaximumPotiental3 { get; }
		public virtual VPerk RankRevision2 { get; }
		public virtual VPerk Veterancy3 { get; }
		public virtual VPerk AutomaticRefinery2 { get; }
		public virtual VPerk CriticalHarvest2 { get; }
		public virtual VPerk DoubleWarp3 { get; }
		public virtual VPerk MineralJackpot3 { get; }
		public virtual VPerk SuperJackpot { get; }
		public virtual VPerk TripleWarp { get; }
		public virtual VPerk Alacrity2 { get; }
		public virtual VPerk BalancedTraining2 { get; }
		public virtual VPerk CriticalChance3 { get; }
		public virtual VPerk CriticalDamage3 { get; }
		public virtual VPerk DamageReduction2 { get; }
		public virtual VPerk SuperRush { get; }
		public virtual VPerk InfusionRecycle3 { get; }
		public virtual VPerk MaximumPotential4 { get; }
		public virtual VPerk Veterancy4 { get; }
		public virtual VPerk KillRecycle2 { get; }
		public virtual VPerk DNAStart { get; }
		public virtual VPerk RankRevision3 { get; }
		public virtual VPerk DoubleWarp4 { get; }
		public virtual VPerk TripleWarp2 { get; }
		public virtual VPerk SuperJackpot2 { get; }
		public virtual VPerk StartingMinerals2 { get; }
		public virtual VPerk MasterTrainer2 { get; }
		public virtual VPerk ExtraSupply2 { get; }
		public virtual VPerk BlackCrits { get; }
		public virtual VPerk BlackMarket { get; }
		public virtual VPerk DominatorDamage { get; }
		public virtual VPerk DominatorSpeed { get; }
		public virtual VPerk Fearless { get; }
		public virtual VPerk UpgradeCache { get; }
		public virtual VPerk DestroyerVitals { get; }
		public virtual VPerk DestroyerArmor { get; }
		public virtual VPerk LimitlessEssence { get; }
		public virtual VPerk OverInfuse { get; }
		public virtual VPerk DestroyerWarp { get; }
		public virtual VPerk DestroyerRankRevision { get; }

		#endregion

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout
		{
			get => fLoadout;
			private set
			{
				fLoadout = value;
			}
		}
		VLoadout fLoadout;

		#endregion

		public abstract int MaxPage { get; }
		public abstract int RemainingCost { get; }
		public abstract int CurrentCost { get; }
		public abstract int TotalCost { get; }

		#region Page

		public virtual int Page
		{
			get
			{
				return fPage;
			}
			set
			{
				if (fPage != value)
				{
					fPage = value;
					OnPropertyChanged(nameof(Perk1));
					OnPropertyChanged(nameof(Perk2));
					OnPropertyChanged(nameof(Perk3));
					OnPropertyChanged(nameof(Perk4));
					OnPropertyChanged(nameof(Perk5));
					OnPropertyChanged(nameof(Perk6));
					OnPropertyChanged(nameof(PageTitle));
				}
			}
		}

		internal void RefreshMaxLevelBindings()
		{
			Perk1.RefreshPropertyBinding(nameof(Perk1.MaxLevel));
			Perk2.RefreshPropertyBinding(nameof(Perk2.MaxLevel));
			Perk3.RefreshPropertyBinding(nameof(Perk3.MaxLevel));
			Perk4.RefreshPropertyBinding(nameof(Perk4.MaxLevel));
			Perk5.RefreshPropertyBinding(nameof(Perk5.MaxLevel));
			Perk6.RefreshPropertyBinding(nameof(Perk6.MaxLevel));
		}

		int fPage;

		#endregion

		[VXML(false)]
		public abstract VPerk Perk1 { get; }
		[VXML(false)]
		public abstract VPerk Perk2 { get; }
		[VXML(false)]
		public abstract VPerk Perk3 { get; }
		[VXML(false)]
		public abstract VPerk Perk4 { get; }
		[VXML(false)]
		public abstract VPerk Perk5 { get; }
		[VXML(false)]
		public abstract VPerk Perk6 { get; }
		public abstract string PageTitle { get; }

		public override string BizoName => "PerkCollection";

		#endregion

		#region PerkLevelChanged

		protected void OnPerkLevelChanged(object sender, StatsEventArgs e)
		{
			PerkLevelChanged?.Invoke(sender, e);
		}

		public event EventHandler<StatsEventArgs> PerkLevelChanged;

		#endregion
	}
}
		
	

