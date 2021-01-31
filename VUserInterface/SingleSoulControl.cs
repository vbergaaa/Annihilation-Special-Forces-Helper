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

		public bool Selected
		{
			get => fSelected;
			set
			{
				fSelected = value;
				OnSelectedChanged();
			}
		}
		bool fSelected;

		public event EventHandler SelectedChanged;

		public void OnSelectedChanged()
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
				using (var pen = new Pen(Color.Black, DPIScalingHelper.GetScaledX(5)))
				{
					e.Graphics.DrawRectangle(Pens.Black, rect);
				}
			}
			else
			{
				e.Graphics.DrawRectangle(Pens.LightGray, rect);
			}
		}

		#endregion

		public override void NotifyDefault(bool value)
		{
			base.NotifyDefault(false);
		}
	}
}
