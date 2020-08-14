using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VLoadout : VBusinessObject
	{
		public override string BizoName => "Loadout";

		[VXML(true)]
		public string Name
		{
			get => fName ?? (fName = "");
			set
			{
				if (value != fName)
				{
					HasChanges = true;
				}
				fName = value;
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
				}
				fSlot = value;
			}
		}
		int fSlot;

		protected internal override string GetSaveNameForXML()=> $"{Slot}-{Name}";

		[VXML(false)]
		public VStats Stats { get; set; }

		public virtual VPerkCollection Perks { get; set; }

		public virtual VGemCollection Gems { get; set; }

		public virtual VSoulCollection Souls { get; set; }

		public virtual VUnitConfiguration UnitConfiguration { get; set; }
	}
}
