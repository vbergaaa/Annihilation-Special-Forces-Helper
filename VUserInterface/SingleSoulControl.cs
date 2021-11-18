using System;
using System.Drawing;
using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class SingleSoulControl : DPIButton
	{
		public SingleSoulControl()
		{
			InitializeComponent();
		}

		#region SoulType

		public SoulType SoulType { get; set; }

		#endregion

		#region Selected

		public bool Selected
		{
			get => fSelected;
			set
			{
				if (fSelected != value)
				{
					fSelected = value;
					OnSelectedChanged();
				}
			}
		}
		bool fSelected;

		public event EventHandler SelectedChanged;

		public void OnSelectedChanged()
		{
			SelectedChanged?.Invoke(this, new SoulTypeEventArgs(SoulType));
			Refresh();
		}

		#endregion

		#region OnClick

		public void OnClick(object sender, EventArgs e)
		{
			Selected = !Selected;
		}

		#endregion

		#region OnPaint

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// add the border
			var rect = new Rectangle(new Point(0, 0), new Size(Width - 1, Height - 1));

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

	#region Event Args

	class SoulTypeEventArgs : EventArgs
	{
		public SoulTypeEventArgs(SoulType type)
		{
			SoulType = type;
		}

		public SoulType SoulType { get; set; }
	}

	#endregion
}
