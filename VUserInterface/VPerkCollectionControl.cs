using System;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VUserInterface.CommonControls;
using VUserInterface.Helpers;

namespace VUserInterface
{
	public partial class VPerkCollectionControl : DPIUserControl
	{
		public VPerkCollectionControl()
		{
			InitializeComponent();
		}

		public new string Text
		{
			get => MainGroupBox.Text;
			set => MainGroupBox.Text = value;
		}

		public PerkCollection Perks { get; set; }

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Perks != null)
			{
				perksBindingSource.DataSource = Perks;
				SetButtonReadonlyStatus();
				RestrictPerkPageButtons();
			}
		}

		internal void RefreshBindings()
		{
			perksBindingSource.ResetBindings(false);
		}


		void UpdatePage(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				if (int.TryParse(button.Text, out var page))
				{
					Perks.Page = page;
				}
				else if (button.Text == "<")
				{
					Perks.Page--;
				}
				else if (button.Text == ">")
				{
					Perks.Page++;
				}
			}

			SetButtonReadonlyStatus();
		}

		void SetButtonReadonlyStatus()
		{
			previousPageButton.Enabled = Perks != null && Perks.Page != 1;
			nextPageButton.Enabled = Perks != null && Perks.Page < Perks.MaxPage;
		}

		internal void RestrictPerkPageButtons()
		{
			if (Perks != null)
			{
				foreach (var control in MainGroupBox.Controls)
				{
					if (control is VButton button && int.TryParse(button.Text, out var pageNum))
					{
						button.Enabled = pageNum <= Perks.MaxPage;
					}
				}
			}
		}

		void OptimiseForDamageButton_Click(object sender, EventArgs e)
		{
			var loadout = Perks.Loadout as Loadout;

			if (loadout.CurrentUnit?.UnitData?.Type == VEntityFramework.Model.UnitType.None)
			{
				MessageBox.Show("Please select a unit to enable this functionality");
				return;
			}

			if (!loadout.ShouldRestrict)
			{
				MessageBox.Show(CaptionProvider.GetShouldRestrictCaption("perk", "damage"));
				return;
			}

			if (MessageBox.Show(CaptionProvider.GetOptimiseLoadoutCaption("perk points", "damage"), "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}

			loadout.OptimisePerksForDamage();
		}

		void OptimiseForToughnessButton_Click(object sender, EventArgs e)
		{
			var loadout = Perks.Loadout as Loadout;

			if (loadout.CurrentUnit?.UnitData?.Type == VEntityFramework.Model.UnitType.None)
			{
				MessageBox.Show("Please select a unit to enable this functionality");
				return;
			}

			if (!loadout.ShouldRestrict)
			{
				MessageBox.Show(CaptionProvider.GetShouldRestrictCaption("perk", "toughness"));
				return;
			}

			if (MessageBox.Show(CaptionProvider.GetOptimiseLoadoutCaption("perk points", "toughness"), "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}

			loadout.OptimisePerksForToughness();
		}
	}
}
