using System;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VEntityFramework.Model;
using VUserInterface.CommonControls;
using VUserInterface.Helpers;

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

			if (loadout.CurrentUnit?.UnitData?.Type == VEntityFramework.Model.UnitType.None)
			{
				MessageBox.Show("Please select a unit to enable this functionality");
				return;
			}

			if (MessageBox.Show(CaptionProvider.GetOptimiseLoadoutCaption("gems", "damage"), "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}

			loadout.OptimiseGemsForDamage();
		}

		private void OptimiseForToughnessButton_Click(object sender, System.EventArgs e)
		{
			var loadout = Gems.Loadout as Loadout;

			if (loadout.CurrentUnit?.UnitData?.Type == VEntityFramework.Model.UnitType.None)
			{
				MessageBox.Show("Please select a unit to enable this functionality");
				return;
			}

			if (MessageBox.Show(CaptionProvider.GetOptimiseLoadoutCaption("gems", "toughness"), "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}

			loadout.OptimiseGemsForToughness();
		}
	}
}
