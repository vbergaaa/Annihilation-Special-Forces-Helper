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

		#region Profile

		[VXML(false)]
		public abstract VProfile Profile { get; }

		#endregion

		#region Name

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

		#endregion

		#region Slot

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

		#endregion

		#region Stats

		[VXML(false)]
		public VStats Stats { get; set; }

		#endregion

		#region Perks

		public virtual VPerkCollection Perks
		{
			get => fPerks;
			set
			{
				fPerks = value;
			}
		}
		VPerkCollection fPerks;

		#endregion

		#region Souls

		public virtual VLoadoutSouls Souls
		{
			get => fSouls;
			set
			{
				fSouls = value;
			}
		}
		VLoadoutSouls fSouls;

		#endregion

		#region Active SoulTypes

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

		#endregion

		#region Gems

		public virtual VGemCollection Gems
		{
			get => fGems;
			set
			{
				fGems = value;
			}
		}
		VGemCollection fGems;

		#endregion

		#region ChallengePoints

		public virtual VChallengePointCollection ChallengePoints
		{
			get => fChallengePoints;
			set
			{
				fChallengePoints = value;
			}
		}
		VChallengePointCollection fChallengePoints;

		#endregion

		#region UnitConfiguration

		public virtual VUnitConfiguration UnitConfiguration
		{
			get => fUnitConfiguration;
			set
			{
				fUnitConfiguration = value;
			}
		}
		VUnitConfiguration fUnitConfiguration;

		#endregion

		#region Upgrades

		[VXML(true)]
		public virtual VUpgradeManager Upgrades { get; }

		#endregion

		#region Income

		[VXML(true)]
		public virtual VIncomeManager IncomeManager { get; }

		#endregion

		#region Units

		public virtual BusinessObjectList<VUnit> Units { get; }

		public virtual void AddUnit(VUnit unit) { }
		public virtual void RemoveUnit(VUnit unit) { }

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
				}
			}
		}
		VUnit fCurrentUnit;

		public void SetCurrentUnit(string unitName)
		{
			VUnit currentUnit = null;
			foreach (var unit in Units)
			{
				if (unit.ToString() == unitName)
				{
					currentUnit = unit;
				}
			}
			ErrorReporter.ReportDebug(currentUnit == null, "Where are you getting this setstring from?");

			CurrentUnit = currentUnit;
		}

		#endregion

		#region PerkPointCost

		public virtual long PerkPointsCost { get; }

		#endregion

		#region RemainingPerkPoints

		public virtual long RemainingPerkPoints { get; }

		#endregion

		#region CanAffordCurrentLoadout

		public virtual bool CanAffordCurrentLoadout { get; }

		#endregion

		#region ShouldRestrict

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

		void OnShouldRestrictChanged()
		{
			ShouldRestrictChanged?.Invoke(this, new EventArgs());
		}
		public event EventHandler ShouldRestrictChanged;

		bool fShouldRestrict;

		#endregion

		#region UseUnitStats

		[VXML(true)]
		public bool UseUnitStats
		{
			get => fUseUnitStats;
			set
			{
				if (value != fUseUnitStats)
				{
					fUseUnitStats = value;
					HasChanges = true;
					Stats.RefreshAllBindings();
					OnPropertyChanged(nameof(UseUnitStats));
				}
			}
		}
		bool fUseUnitStats;

		#endregion

		#region UseSingleUnitEco

		[VXML(true)]
		public bool UseSingleUnitEco
		{
			get => fUseSingleUnitEco;
			set
			{
				if (value != fUseSingleUnitEco)
				{
					fUseSingleUnitEco = value;
					HasChanges = true;
					IncomeManager.RefreshPropertyBinding(nameof(IncomeManager.LoadoutKillCost));
					IncomeManager.RefreshPropertyBinding(nameof(IncomeManager.LoadoutMineralCost));
					OnPropertyChanged(nameof(UseSingleUnitEco));
				}
			}
		}
		bool fUseSingleUnitEco;

		#endregion

		#region UnitSpec

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

		#endregion

#endregion

		#region Implementation

		#region GetSaveNameForXML

		protected internal override string GetSaveNameForXML() => $"{Slot}-{Name}";

		#endregion

		#region BizoName

		public override string BizoName => "Loadout";

		#endregion

		#endregion
	}
}
