using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VCheckControl : UserControl
	{
		public VCheckControl()
		{
			InitializeComponent();
		}

		#region Checked

		public bool Checked
		{
			get => fChecked;
			set
			{
				if (value != fChecked)
				{
					fChecked = value;
					CheckBox.Checked = value;
					OnCheckedChanged();
				}
			}
		}

		bool fChecked;

		#endregion

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
			this.CheckBox.Left += width;
		}

		string fCaption;

		#endregion

		#region Events

		#region CheckedChanged

		public event EventHandler CheckedChanged;

		void OnCheckedChanged()
		{
			CheckedChanged?.Invoke(this, new EventArgs());
		}

		#endregion

		#endregion
	}

	class VCheckBox : CheckBox
	{
		public VCheckBox()
		{
			this.FlatStyle = FlatStyle.Flat;
		}

		public override bool AutoSize
		{
			set { base.AutoSize = false; }
			get { return base.AutoSize; }
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.Clear(this.BackColor);

			// create the background
			var rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
			e.Graphics.FillRectangle(Brushes.White, rect);
			e.Graphics.DrawRectangle(Pens.Black, rect);

			// create the tick
			if (Checked)
			{
				var x1 = 2f * this.Width / 13;
				var y1 = 5.5f * this.Width / 13;
				var x2 = 5f * this.Width / 13;
				var y2 = 8.5f * this.Width / 13;
				var x3 = 10.5f * this.Width / 13;
				var y3 = 3f * this.Width / 13;

				var pen = new Pen(Color.Black, 2);
				e.Graphics.DrawLine(pen, x1, y1, x2, y2);
				e.Graphics.DrawLine(pen, x3, y3, x2, y2);
			}
		}
	}
}
