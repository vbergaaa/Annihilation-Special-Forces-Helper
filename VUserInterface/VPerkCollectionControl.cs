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
			SimplifyControl();
		}

		void SimplifyControl()
		{
			totalCurrentCostCaption.Visible = false;
			totalCurrentCostLabel.Visible = false;
			totalDesiredCostCaption.Visible = false;
			totalDesiredCostLabel.Visible = false;
			remainingCostCaption.Text = "Total Cost:";
		}

		public PerkCollection Perks { get; set; }

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			this.perksBindingSource.DataSource = Perks;
			SetButtonReadonlyStatus();
		}

		public override BindingContext BindingContext 
		{ 
			get => base.BindingContext; 
			set => base.BindingContext = value;
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
			nextPageButton.Enabled = Perks != null && Perks.Page != 11;
		}
	}
}
