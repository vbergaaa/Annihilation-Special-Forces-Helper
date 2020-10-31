using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VUnitConfiguration : VBusinessObject
	{
		#region Constructor

		public VUnitConfiguration(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout;
		}

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout { get; private set; }

		#endregion

		#region Rank

		[VXML(false)]
		public VUnitRank Rank
		{
			get => fRank;
			protected set
			{
				DeactivateRank(fRank);
				fRank = value;
				ActivateRank(fRank);
				HasChanges = true;
			}
		}

		VUnitRank fRank;

		#endregion

		#region UnitRank

		[VXML(true)]
		public virtual UnitRank UnitRank
		{
			get => fUnitRank;
			set
			{
				if (fUnitRank != value)
				{
					fUnitRank = value;
					HasChanges = true;
				}
			}
		}
		UnitRank fUnitRank;

		#endregion

		#region CurrentInfuse

		[VXML(true)]
		public virtual int CurrentInfusion
		{
			get => fCurrentInfuse;
			set
			{
				if (value != fCurrentInfuse)
				{
					fCurrentInfuse = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentInfusion)));
				}
			}
		}
		int fCurrentInfuse;

		#endregion

		#region MaximumEssence

		public virtual int MaximumInfusion { get; }

		#endregion

		#region CurrentEssence

		[VXML(true)]
		public virtual int EssenceStacks
		{
			get => fCurrentEssence;
			set
			{
				if (value != fCurrentEssence)
				{
					fCurrentEssence = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(EssenceStacks)));
				}
			}
		}
		int fCurrentEssence;

		#endregion

		#region MaximumEssence

		public virtual int MaximumEssence { get; }

		#endregion

		#region MaximumKills

		public virtual int MaximumKills
		{
			get => fMaximumKills;
			set
			{
				fMaximumKills = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(MaximumKills)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(MaximumInfusion)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(MaximumEssence)));
			}
		}
		int fMaximumKills;

		#endregion

		#region HasSoloBonus

		[VXML(true)]
		public virtual bool HasSoloBonus
		{
			get => fHasSoloBonus;
			set
			{
				if (fHasSoloBonus != value)
				{
					fHasSoloBonus = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(HasSoloBonus)));
				}
			}
		}
		bool fHasSoloBonus;

		#endregion

		#region HasUnitSpec

		[VXML(true)]
		public virtual bool HasUnitSpec
		{
			get => fHasUnitSpec;
			set
			{
				if (fHasUnitSpec != value)
				{
					fHasUnitSpec = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(HasUnitSpec)));
				}
			}
		}
		bool fHasUnitSpec;

		#endregion

		#region HasAdrenalineBuffActive

		[VXML(true)]
		public virtual bool HasAdrenalineBuffActive
		{
			get => fHasAdrenalineBuffActive;
			set
			{
				if (fHasAdrenalineBuffActive != value)
				{
					fHasAdrenalineBuffActive = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(HasAdrenalineBuffActive)));
				}
			}
		}
		bool fHasAdrenalineBuffActive;

		#endregion

		#region DifficultyLevel

		[VXML(true)]
		public virtual DifficultyLevel DifficultyLevel
		{
			get => fDifficultyLevel;
			set
			{
				if (fDifficultyLevel != value)
				{
					fDifficultyLevel = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DifficultyLevel)));
				}
			}
		}
		DifficultyLevel fDifficultyLevel;

		#endregion

		#region Difficulty

		public virtual VDifficulty Difficulty
		{
			get => fDifficulty;
			set
			{
				if (fDifficulty != value)
				{
					fDifficulty = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Difficulty)));
				}
			}
		}
		VDifficulty fDifficulty;

		#endregion

		#endregion

		#region Methods

		#region ActivateRank

		void ActivateRank(VUnitRank rank)
		{
			if (rank != null && Loadout != null)
			{
				rank.ActivateRank();
			}
		}

		#endregion

		#region DeactivateRank

		void DeactivateRank(VUnitRank rank)
		{
			if (rank != null && Loadout != null)
			{
				rank.DeactivateRank();
			}
		}

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "UnitConfiguration";
		
		#endregion
	}
}
