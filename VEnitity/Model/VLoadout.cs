using System;
using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Loadouts")]
	public abstract class VLoadout : VBusinessObject
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
				var types = souls.Select(s => s.Type);
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

		#region Units

		public virtual BusinessObjectList<VUnit> Units { get; }

		public virtual void AddUnit(VUnit unit) { }
		public virtual void RemoveUnit(VUnit unit) { }

		[VXML(false)]
		public virtual VUnit CurrentUnit
		{
			get
			{
				if (fCurrentUnit == null)
				{
					if (Units.Count > 0)
					{
						return Units[0];
					}
					else
					{
						return VUnit.New(UnitType.None, this);
					}
				}
				return fCurrentUnit;
			}
			set
			{
				if (fCurrentUnit != value)
				{
					fCurrentUnit = value;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentUnit)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Units)));
				}
			}
		}
		VUnit fCurrentUnit;

		public void SetCurrentUnit(string unitName)
		{
			VUnit currentUnit = null;
			foreach(var unit in Units)
			{
				if (unit.ToString() == unitName)
				{
					currentUnit = unit;
				}
			}

			CurrentUnit = currentUnit
#if DEBUG
				?? throw new Exception("Where are you getting this setstring from?");
#endif
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
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(ShouldRestrict)));
					OnShouldRestrictChanged();
				}
			}
		}

		void OnShouldRestrictChanged()
		{
			ShouldRestrictChanged?.Invoke(this, new EventArgs());
		}
		public event EventHandler ShouldRestrictChanged;

		bool fShouldRestrict = true;

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
