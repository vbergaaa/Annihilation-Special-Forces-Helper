using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class SingleSoulControl : DPIButton
	{
		public SingleSoulControl()
		{
			InitializeComponent();
		}

		#region Selected

		public bool Selected { get; set; }

		public event EventHandler SelectedChanged;

		void OnSelectedChanged()
		{
			SelectedChanged?.Invoke(this, new EventArgs());
		}

		#endregion

		#region OnClick

		public void OnClick(object sender, EventArgs e)
		{
			Selected = !Selected;
			Update();
		}

		#endregion

		#region OnPaint

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// add the border
			var rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));

			if (Selected)
			{
				e.Graphics.DrawRectangle(Pens.LightGray, rect);
			}
			else
			{
				using (var pen = new Pen(Color.Black, DPIScalingHelper.GetScaledX(2)))
				{
					e.Graphics.DrawRectangle(Pens.Black, rect);
				}
			}
		}

		#endregion
	}
}
