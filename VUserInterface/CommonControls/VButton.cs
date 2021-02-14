using System;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public class VButton : DPIButton
	{
		internal bool DisableStyleChanging { get; set; }

		protected override void OnEnabledChanged(EventArgs e)
		{
			base.OnEnabledChanged(e);

			if (!DisableStyleChanging)
			{
				FlatStyle = Enabled ? FlatStyle.Flat : FlatStyle.Standard;
			}
		}
	}
}
