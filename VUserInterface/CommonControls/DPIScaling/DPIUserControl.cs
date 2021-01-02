using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class DPIUserControl : UserControl
	{
		public DPIUserControl()
		{
			InitializeComponent();
		}

		protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
		{
			// DPI Scaling is handled externally by the class DPIScalingHelper.cs
		}

		protected override bool ScaleChildren => false;
	}
}
