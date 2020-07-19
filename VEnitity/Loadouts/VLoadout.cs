using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VLoadout : VBusinessObject
	{
		public override string BizoName => "Loadout";

		[VXML(true)]
		public string Name { get; set; }

		[VXML(true)]
		public int Slot { get; set; }

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
	}
}
