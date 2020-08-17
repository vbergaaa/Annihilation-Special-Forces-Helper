using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VLoadout : VBusinessObject
	{
		#region Properties

		#region BizoName

		public override string BizoName => "Loadout";

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

		#endregion

		protected internal override string GetSaveNameForXML()=> $"{Slot}-{Name}";

		[VXML(false)]
		public VStats Stats { get; set; }

		public virtual VPerkCollection Perks
		{
			get => fPerks;
			set
			{
				fPerks = value;
				RegisterChild(fPerks);
			}
		}
		VPerkCollection fPerks;

		public virtual VSoulCollection Souls
		{
			get => fSouls;
			set
			{
				fSouls = value;
				RegisterChild(fSouls);
			}
		}
		VSoulCollection fSouls;

		public virtual VGemCollection Gems
		{
			get => fGems;
			set
			{
				fGems = value;
				RegisterChild(fGems);
			}
		}
		VGemCollection fGems;

		public virtual VUnitConfiguration UnitConfiguration { get; set; }
	}
}
