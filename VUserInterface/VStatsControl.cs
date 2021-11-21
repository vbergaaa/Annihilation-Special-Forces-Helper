using System;
using System.Windows.Forms;
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
				this.statsBindingSource.DataSource = Stats;
			}
		}

		public VStats Stats { get; set; }
	}
}
