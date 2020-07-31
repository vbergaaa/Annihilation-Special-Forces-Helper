using System;
using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class VGemCollectionControl : GroupBox
	{
		public VGemCollectionControl()
		{
			InitializeComponent();
		}

		public VGemCollection Gems { get; set; }

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			this.gemsBindingSource.DataSource = Gems;
		}

		internal void RefreshBindings()
		{
			this.gemsBindingSource.ResetBindings(false);
		}
	}
}
