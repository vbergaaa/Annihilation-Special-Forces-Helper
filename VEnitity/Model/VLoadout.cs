using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VLoadout : VBusinessObject
	{
		#region Properties

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

		public virtual VPerkCollection ChallengePoints
		{
			get => fChallengePoints;
			set
			{
				fChallengePoints = value;
			}
		}
		VPerkCollection fChallengePoints;

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
