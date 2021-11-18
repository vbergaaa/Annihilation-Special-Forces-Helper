using System;
using System.Drawing;

namespace VUserInterface.CommonControls
{
	public partial class VUserControl : DPIUserControl
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
				if (fCaption != value)
				{
					fOldCaptionWidth = CaptionLabel.Width;
					fCaption = value;
					CaptionLabel.Text = fCaption;
					CaptionLabel.Visible = !string.IsNullOrEmpty(fCaption);
					AdjustLabel();
				}
			}
		}
		string fCaption;
		int fOldCaptionWidth;
		bool isSettingCaption;

		void AdjustLabel()
		{
			isSettingCaption = true;
			var widthChanged = CaptionLabel.Width - fOldCaptionWidth;
			widthChanged += fOldCaptionWidth == 0 ? 5 : 0;
			Width += widthChanged;
			Left -= widthChanged;
			CoreControl.Left += widthChanged;
			isSettingCaption = false;
		}


		#endregion

		#region CoreControl_SizeChanged

		void CoreControl_SizeChanged(object sender, System.EventArgs e)
		{
			if (CoreControl.Controls.Count == 1)
			{
				CoreControl.Controls[0].Size = CoreControl.Size;
			}
		}

		protected virtual bool ShouldResizeOnParentSizeChanged => true;

		#endregion

		#region OnSizeChanged

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);

			if (!isResizing && !isSettingCaption)
			{
				isResizing = true;
				var captionWidth = Caption != null ? CaptionLabel.Width + 5 : 0;
				Width += captionWidth;
				CoreControl.Size = new Size(Size.Width - captionWidth, Size.Height);
				isResizing = false;
			}
		}
		bool isResizing;

		#endregion

		#region OnLocationChanged

		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);
			if (!isRelocating && !isSettingCaption)
			{
				isRelocating = true;
				var captionWidth = Caption != null ? CaptionLabel.Width + 5 : 0;
				Left -= captionWidth;
				isRelocating = false;
			}
		}
		bool isRelocating;

		#endregion
	}
}
