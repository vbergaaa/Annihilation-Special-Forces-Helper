using System;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class VStatsControl : DPIGroupBox
	{
		public VStatsControl()
		{
			InitializeComponent();
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Stats != null)
			{
				statsBindingSource.DataSource = Stats;
			}
		}

		public VStats Stats { get; set; }
	}
}
