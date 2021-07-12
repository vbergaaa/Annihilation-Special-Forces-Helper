using System;
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
				this.BindingSource.DataSource = Gems;
			}
		}
	}
}
