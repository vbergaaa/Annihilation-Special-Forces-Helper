using System;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public class VButton : Button
	{
		protected override void OnEnabledChanged(EventArgs e)
		{
			base.OnEnabledChanged(e);
			FlatStyle = Enabled ? FlatStyle.Flat : FlatStyle.Standard;
		}
	}
}
