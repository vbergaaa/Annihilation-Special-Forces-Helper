using System;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Loadouts")]
	public abstract class VLoadout : VBusinessObject
	{
		#region Properties

		#region Profile

		public abstract VProfile Profile { get; }

		#endregion

		#region Name

		[VXML(true)]
		public string Name
		{
			get => fName ?? (fName = "");
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

		public virtual VSoulCollection Souls
		{
			get => fSouls;
			set
			{
				fSouls = value;
			}
		}
		VSoulCollection fSouls;

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
			get => fShouldRestrict;
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
				}
			}
		}
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
