using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VEntityFramework;

namespace VUserInterface
{
	public partial class VPerkCollectionControl : GroupBox
	{
		public VPerkCollectionControl()
		{
			InitializeComponent();
		}

		public PerkCollection Perks { get; set; }

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Perks != null)
			{
				this.perksBindingSource.DataSource = Perks;
				SetButtonReadonlyStatus();
				RestrictPagePageButtons();
			}
		}

		internal void RefreshBindings()
		{
			this.perksBindingSource.ResetBindings(false);
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

		void RestrictPagePageButtons()
		{
			if (Perks != null)
			{
				foreach (var control in Controls)
				{
					if (control is Button button && int.TryParse(button.Text, out var pageNum))
					{
						button.Enabled = pageNum <= Perks.MaxPage;
					}
				}
			}
		}
	}
}
