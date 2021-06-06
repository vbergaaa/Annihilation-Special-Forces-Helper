using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class BrutaliskOverrideControl : VUserControl
	{
		public BrutaliskOverrideControl()
		{
			InitializeComponent();
		}

		#region Properties

		#region BrutaliskOverride

		public VBrutaliskOverride BrutaliskOverride
		{
			get => fBrutaliskOverride;
			set
			{
				if (value != fBrutaliskOverride)
				{
					fBrutaliskOverride = value;
					bindingSource.DataSource = value;
				}
			}
		}
		VBrutaliskOverride fBrutaliskOverride;

		#endregion

		#endregion
	}
}
