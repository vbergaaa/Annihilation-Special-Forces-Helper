using System;
using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Loadouts")]
	public abstract class VLoadout : BusinessObject
	{
		#region Properties

		[VXML(false)]
		public abstract VProfile Profile { get; }

		[VXML(true)]
		public string Name
		{
			get => fName ??= "";
			set
			{
				if (value != fName)
				{
					HasChanges = true;
					fName = value;
				}
			}
		}
		string fName;

		[VXML(true)]
		public int Slot
		{
			get => fSlot;
			set
			{
				if (value != fSlot)
				{
					HasChanges = true;
					fSlot = value;
				}
			}
		}
		int fSlot;

		[VXML(false)]
		public VStats Stats { get; set; }

		public virtual VPerkCollection Perks
		{
			get => fPerks;
			set => fPerks = value;
		}
		VPerkCollection fPerks;

		public virtual VLoadoutSouls Souls
		{
			get => fSouls;
			set => fSouls = value;
		}
		VLoadoutSouls fSouls;

		public IEnumerable<SoulType> ActiveSoulTypes
		{
			get
			{
				var souls = new List<VSoul>() { Souls.Soul1, Souls.Soul2, Souls.Soul3 };
				var types = souls.Select(s => s.Type).ToList();
				types.AddRange(Souls.SoulPowers.ActiveSouls);
				return types;
			}
		}

		public virtual VGemCollection Gems
		{
			get => fGems;
			set => fGems = value;
		}
		VGemCollection fGems;

		public virtual VChallengePointCollection ChallengePoints
		{
			get => fChallengePoints;
			set => fChallengePoints = value;
		}
		VChallengePointCollection fChallengePoints;

		public virtual VUnitConfiguration UnitConfiguration
		{
			get => fUnitConfiguration;
			set => fUnitConfiguration = value;
		}
		VUnitConfiguration fUnitConfiguration;

		[VXML(true)]
		public virtual VUpgradeManager Upgrades { get; }

		[VXML(true)]
		public virtual VIncomeManager IncomeManager { get; }

		public virtual VModsCollection Mods { get; }

		public virtual BusinessObjectList<VUnit> Units { get; }

		[VXML(false)]
		public virtual VUnit CurrentUnit
		{
			get => fCurrentUnit;
			set
			{
				if (fCurrentUnit != value)
				{
					fCurrentUnit = value;
					OnPropertyChanged(nameof(CurrentUnit));
					OnPropertyChanged(nameof(Units));
					IncomeManager.RefreshPropertyBinding(nameof(IncomeManager.LoadoutMineralCost));
					IncomeManager.RefreshPropertyBinding(nameof(IncomeManager.LoadoutKillCost));
					OnUnitsUpdated();
				}
			}
		}
		VUnit fCurrentUnit;

		public void SetCurrentUnit(VUnit unit)
		{
			if (unit != CurrentUnit)
			{
				ErrorReporter.ReportDebug(!Units.Contains(unit), "Where are you getting this unit from?");
				CurrentUnit = unit;
			}
		}

		public void OnUnitsUpdated()
		{
			UnitsUpdated?.Invoke(this, new EventArgs());
		}
		public event EventHandler UnitsUpdated;

		public virtual long PerkPointsCost { get; }

		public virtual long RemainingPerkPoints { get; }

		public virtual bool CanAffordCurrentLoadout { get; }

		[VXML(true)]
		public bool ShouldRestrict
		{
			get => !IsLoading && fShouldRestrict;
			set
			{
				if (value != fShouldRestrict)
				{
					if (!value || CanAffordCurrentLoadout)
					{
						fShouldRestrict = value;
						HasChanges = true;
						Gems.RefreshMaxLevelBindings();
						Perks.RefreshMaxLevelBindings();
						ChallengePoints.RefreshMaxLevelBindings();
					}
					OnPropertyChanged(nameof(ShouldRestrict));
					OnShouldRestrictChanged();
				}
			}
		}

		public bool RemoveProfileLimits
		{
			get => !ShouldRestrict;
			set => ShouldRestrict = !value;
		}

		void OnShouldRestrictChanged()
		{
			ShouldRestrictChanged?.Invoke(this, new EventArgs());
		}
		public event EventHandler ShouldRestrictChanged;

		bool fShouldRestrict;

		public bool UseUnitStats => CurrentUnit != null && CurrentUnit.UnitData.Type != UnitType.None;
		public bool UseUnitCosts => CurrentUnit != null && CurrentUnit.UnitData.Type != UnitType.None;

		[VXML(true)]
		public virtual UnitType UnitSpec
		{
			get => fUnitSpec;
			set
			{
				if (value != fUnitSpec)
				{
					fUnitSpec = value;
					HasChanges = true;
					Stats.RefreshAllBindings();
					OnPropertyChanged(nameof(UnitSpec));
					CurrentUnit.RefreshPropertyBinding(nameof(CurrentUnit.HasUnitSpec));
				}
			}
		}
		UnitType fUnitSpec;

		public virtual bool UnitSpec_Readonly { get; }

		[VXML(true)]
		public bool SyncWithBank
		{
			get => fSyncWithBank;
			set
			{
				if (value != fSyncWithBank)
				{
					fSyncWithBank = value;
					HasChanges = true;
					OnPropertyChanged(nameof(SyncWithBank));
				}
			}
		}
		bool fSyncWithBank;

		protected DisposableAction BeginOptimisingStatistics()
		{
			fIsOptimisingCounter += 1;
			return new DisposableAction(() => { fIsOptimisingCounter -= 1; });
		}

		public bool IsOptimisingStatistics => fIsOptimisingCounter > 0;
		int fIsOptimisingCounter;

		#endregion

		#region Implementation

		protected internal override string GetSaveNameForXML()
		{
			return $"{Slot}-{Name}";
		}

		public override string BizoName => "Loadout";

		#endregion
	}
}
