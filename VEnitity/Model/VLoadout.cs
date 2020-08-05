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

		public override void OnLoadedFromXML(OnLoadedEventArgs e)
		{
			base.OnLoadedFromXML(e);
			existingXMLFileName = e.FileName;
		}

		protected override void UpdateExistingXMLName()
		{
			existingXMLFileName = $"{Slot}-{Name}";
		}
		protected override string GetExistingXMLFileName => existingXMLFileName;
		string existingXMLFileName;

		[VXML(false)]
		public VStats Stats { get; set; }

		public virtual VPerkCollection Perks { get; set; }

		public virtual VGemCollection Gems { get; set; }

		public virtual VSoulCollection Souls { get; set; }
	}
}
