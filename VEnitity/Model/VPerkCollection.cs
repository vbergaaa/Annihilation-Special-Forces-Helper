using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VPerkCollection : VBusinessObject
	{
		#region Perks

		public abstract VPerk Attack { get; }
		public abstract VPerk AttackSpeed { get; }
		public abstract VPerk Health { get; }
		public abstract VPerk HealthArmor { get; }
		public abstract VPerk Shields { get; }
		public abstract VPerk ShieldsArmor { get; }
		public abstract VPerk KillEfficiency { get; }
		public abstract VPerk KillRecycle { get; }
		public abstract VPerk MaximumPotiential { get; }
		public abstract VPerk Veterancy { get; }
		public abstract VPerk Rank { get; }
		public abstract VPerk InfusionRecycle { get; }
		public abstract VPerk DoubleWarp { get; }
		public abstract VPerk StartingMinerals { get; }
		public abstract VPerk MasterTrainer { get; }
		public abstract VPerk ExtraSupply { get; }
		public abstract VPerk MineralJackpot { get; }
		public abstract VPerk AutomaticRefinery { get; }
		public abstract VPerk AdrenalineRush { get; }
		public abstract VPerk CriticalChance { get; }
		public abstract VPerk CriticalDamage { get; }
		public abstract VPerk DamageReduction { get; }
		public abstract VPerk OverSpeed { get; }
		public abstract VPerk UnitSpecialization { get; }
		public abstract VPerk KillEfficiency2 { get; }
		public abstract VPerk MaximumGather { get; }
		public abstract VPerk MaximumPotiential2 { get; }
		public abstract VPerk QuickStart { get; }
		public abstract VPerk RankRevision { get; }
		public abstract VPerk Veterancy2 { get; }
		public abstract VPerk BuildingRecycle { get; }
		public abstract VPerk CriticalCollection { get; }
		public abstract VPerk CriticalHarvest { get; }
		public abstract VPerk DoubleWarp2 { get; }
		public abstract VPerk ExpertMiner { get; }
		public abstract VPerk MineralJackpot2 { get; }
		public abstract VPerk AcceleratedFusion { get; }
		public abstract VPerk FastLearner { get; }
		public abstract VPerk MiningExpertise { get; }
		public abstract VPerk TrainingCenter { get; }
		public abstract VPerk TrifectaPower { get; }
		public abstract VPerk UnitStorage { get; }
		public abstract VPerk Alacrity { get; }
		public abstract VPerk BalancedTraining { get; }
		public abstract VPerk CooldownSpeed { get; }
		public abstract VPerk CriticalChance2 { get; }
		public abstract VPerk CriticalDamage2 { get; }
		public abstract VPerk RedCrits { get; }
		public abstract VPerk InfusionRecycle2 { get; }
		public abstract VPerk KillHarvest { get; }
		public abstract VPerk MaximumGather2 { get; }
		public abstract VPerk MaximumPotiental3 { get; }
		public abstract VPerk RankRevision2 { get; }
		public abstract VPerk Veterancy3 { get; }
		public abstract VPerk AutomaticRefinery2 { get; }
		public abstract VPerk CriticalHarvest2 { get; }
		public abstract VPerk DoubleWarp3 { get; }
		public abstract VPerk MineralJackpot3 { get; }
		public abstract VPerk SuperJackpot { get; }
		public abstract VPerk TripleWarp { get; }
		public abstract VPerk BalancedTraining2 { get; }
		public abstract VPerk CriticalChance3 { get; }
		public abstract VPerk CriticalDamage3 { get; }
		public abstract VPerk DamageReduction2 { get; }
		public abstract VPerk SuperRush { get; }
		public abstract VPerk Alacrity2 { get; }

		#endregion

		public abstract int RemainingCost { get; }
		public abstract int CurrentCost { get; }
		public abstract int TotalCost { get; }

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
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk1)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk2)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk3)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk4)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk5)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk6)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(PageTitle)));
				}
			}
		}
		int fPage;


		[VXML(include: false)]
		public abstract VPerk Perk1 { get; }
		[VXML(include: false)]
		public abstract VPerk Perk2 { get; }
		[VXML(include: false)]
		public abstract VPerk Perk3 { get; }
		[VXML(include: false)]
		public abstract VPerk Perk4 { get; }
		[VXML(include: false)]
		public abstract VPerk Perk5 { get; }
		[VXML(include: false)]
		public abstract VPerk Perk6 { get; }
		public abstract string PageTitle { get; }

		public override string BizoName => "PerkCollection";

		#region PerkLevelChanged

		protected void OnPerkLevelChanged(object sender, StatsEventArgs e)
		{
			PerkLevelChanged?.Invoke(sender, e);
		}

		public event EventHandler<StatsEventArgs> PerkLevelChanged;

		#endregion
	}
}
		
	

