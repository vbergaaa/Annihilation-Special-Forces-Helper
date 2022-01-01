using System;
using VBusiness.Loadouts;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class VGemCollectionControl : DPIUserControl
	{
		public VGemCollectionControl()
		{
			InitializeComponent();
		}

		public VGemCollection Gems { get; set; }

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Gems != null)
			{
				BindingSource.DataSource = Gems;
			}
		}

		void OptimiseForDamageButton_Click(object sender, System.EventArgs e)
		{
			var loadout = Gems.Loadout as Loadout;
			loadout.OptimiseGemsForDamage();
		}

		private void OptimiseForToughnessButton_Click(object sender, System.EventArgs e)
		{
			var loadout = Gems.Loadout as Loadout;
			loadout.OptimiseGemsForToughness();
		}
	}
}
