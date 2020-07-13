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
			this.perksBindingSource.DataSource = Perks;
		}

		protected override void OnParentBindingContextChanged(EventArgs e)
		{
			base.OnParentBindingContextChanged(e);
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


		private void UpdatePage(object sender, EventArgs e)
		{
			if (sender is Button button && int.TryParse(button.Text, out var page))
			{
				Perks.Page = page;
			}
		}
	}
}
