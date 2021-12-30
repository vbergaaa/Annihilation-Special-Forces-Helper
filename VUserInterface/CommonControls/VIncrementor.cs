using System;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VIncrementor : VUserControl
	{
		public VIncrementor()
		{
			InitializeComponent();
		}

		#region Properties

		public int Value
		{
			get => fValue;
			set
			{
				ValueLabel.Text = value.ToString();
				fValue = value;
				OnValueChanged();
				RefreshButtons();
			}
		}
		int fValue;

		public bool DisableShiftClick { get; set; }

		public IncrementorStyle IncrementorStyle
		{
			get => fIncrementorStyle ?? IncrementorStyle.Normal;
			set
			{
				if (fIncrementorStyle != value)
				{
					fIncrementorStyle = value;
					ResizeControl(value);
				}
			}
		}
		IncrementorStyle? fIncrementorStyle;

		public int MaxValue
		{
			get => fMaxValue;
			set
			{
				fMaxValue = value;
				RefreshButtons();
			}
		}
		int fMaxValue = int.MaxValue;

		public int MinValue
		{
			get => fMinValue;
			set
			{
				fMinValue = value;
				RefreshButtons();
			}
		}
		int fMinValue;

		public int IncrementAmount
		{
			get => fIncrementAmount;
			set => fIncrementAmount = value;
		}
		int fIncrementAmount = 1;

		// as ugly as this design pattern is, it allows for lazy loading, and as generating the tooltip is often expensive and will rarely be used, lazy loading is a requirement.
		public Func<string> IncrementHint
		{
			get; set;
		}

		public Func<string> DecrementHint
		{
			get; set;
		}

		#endregion

		#region Update Buttons

		void RefreshButtons()
		{
			IncrementButton.Enabled = Value < MaxValue;
			DecrementButton.Enabled = Value > MinValue;
		}

		#endregion

		#region ResizeControl

		void ResizeControl(IncrementorStyle value)
		{
			if (value == IncrementorStyle.Compact)
			{
				ValueLabel.Size = DPIScalingHelper.GetScaledSize(23, 23);
				ValueLabel.Left -= DPIScalingHelper.GetScaledX(5);
				IncrementButton.Left -= DPIScalingHelper.GetScaledX(30);
				CoreControl.Width -= DPIScalingHelper.GetScaledX(30);
				Width -= DPIScalingHelper.GetScaledX(30);
				Left += DPIScalingHelper.GetScaledX(30);
			}
			if (value == IncrementorStyle.Normal)
			{
				ValueLabel.Size = DPIScalingHelper.GetScaledSize(43, 23);
				ValueLabel.Left += DPIScalingHelper.GetScaledX(5);
				IncrementButton.Left += DPIScalingHelper.GetScaledX(30);
				CoreControl.Width += DPIScalingHelper.GetScaledX(30);
				Width += DPIScalingHelper.GetScaledX(30);
				Left -= DPIScalingHelper.GetScaledX(30);
			}
		}

		#endregion

		#region Event Handling

		public void IncrementButton_Click(object sender, EventArgs e)
		{
			if (!DisableShiftClick && Control.ModifierKeys == Keys.Control)
			{
				Value += 100 * IncrementAmount;
			}
			else if (!DisableShiftClick && Control.ModifierKeys == Keys.Shift)
			{
				Value += 10 * IncrementAmount;
			}
			else
			{
				Value += 1 * IncrementAmount;
			}
		}

		private void IncrementToolTip_Popup(object sender, PopupEventArgs e)
		{
			if (!isSettingToolTip)
			{
				isSettingToolTip = true;
				var info = sender as ToolTip;

				if (IncrementHint != null)
				{
					var hint = IncrementHint();
					info.SetToolTip(e.AssociatedControl, hint);
				}
				else
				{
					info.SetToolTip(e.AssociatedControl, string.Empty);
				}
				isSettingToolTip = false;
			}
		}

		private void DecrementToolTip_Popup(object sender, PopupEventArgs e)
		{
			if (!isSettingToolTip)
			{
				isSettingToolTip = true;
				var info = sender as ToolTip;

				if (DecrementHint != null)
				{
					var hint = DecrementHint();
					info.SetToolTip(e.AssociatedControl, hint);
				}
				else
				{
					info.SetToolTip(e.AssociatedControl, string.Empty);
				}
				isSettingToolTip = false;
			}
		}
		bool isSettingToolTip;

		public void DecrementButton_Click(object sender, EventArgs e)
		{
			if (!DisableShiftClick && Control.ModifierKeys == Keys.Control)
			{
				Value -= 100 * IncrementAmount;
			}
			else if (!DisableShiftClick && Control.ModifierKeys == Keys.Shift)
			{
				Value -= 10 * IncrementAmount;
			}
			else
			{
				Value -= 1 * IncrementAmount;
			}
		}

		#endregion

		#region Implementation

		void OnValueChanged()
		{
			ValueChanged?.Invoke(this, new EventArgs());
		}

		public event EventHandler ValueChanged;

		#endregion
	}

	public enum IncrementorStyle
	{
		Compact,
		Normal 
	}

}
