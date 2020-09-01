using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VUserControl : UserControl
	{
		public VUserControl()
		{
			InitializeComponent();
		}

		#region Caption

		public string Caption
		{
			get => fCaption;
			set
			{
				fCaption = value;
				CaptionLabel.Text = fCaption;
				CaptionLabel.Visible = !string.IsNullOrEmpty(fCaption);
				AdjustLabel();
			}
		}

		private void AdjustLabel()
		{
			var width = CaptionLabel.Width + 5;
			this.Width += width;
			this.Left -= width;
			this.CoreControl.Left += width;
		}

		string fCaption;

		#endregion
	}
}
