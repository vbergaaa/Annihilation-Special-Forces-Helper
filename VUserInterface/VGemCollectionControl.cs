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
			if (Gems != null)
			{
				this.gemsBindingSource.DataSource = Gems;
			}
		}
	}
}
