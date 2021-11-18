using System;
using System.Drawing;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VCheckControl : VUserControl
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
			FlatStyle = FlatStyle.Flat;
		}

		public override bool AutoSize
		{
			set { base.AutoSize = false; }
			get { return base.AutoSize; }
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.Clear(BackColor);

			// create the background
			var rect = new Rectangle(new Point(0, 0), new Size(Width - 1, Height - 1));
			e.Graphics.FillRectangle(Brushes.White, rect);
			e.Graphics.DrawRectangle(Pens.Black, rect);

			// create the tick
			if (Checked)
			{
				var x1 = 2f * Width / 13;
				var y1 = 5.5f * Width / 13;
				var x2 = 5f * Width / 13;
				var y2 = 8.5f * Width / 13;
				var x3 = 10.5f * Width / 13;
				var y3 = 3f * Width / 13;

				var pen = new Pen(Color.Black, 2);
				e.Graphics.DrawLine(pen, x1, y1, x2, y2);
				e.Graphics.DrawLine(pen, x3, y3, x2, y2);
			}
		}
	}
}
