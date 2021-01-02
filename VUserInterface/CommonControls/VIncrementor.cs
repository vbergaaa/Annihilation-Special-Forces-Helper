using System;
using System.ComponentModel;
using System.Drawing;
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

		#region Value

		public int Value
		{
			get => fValue;
			set
			{
				this.ValueLabel.Text = value.ToString();
				fValue = value;
				OnValueChanged();
				RefreshButtons();
			}
		}
		int fValue;

		#endregion

		#region DisableShiftClick

		public bool DisableShiftClick { get; set; }

		#endregion

		#region IncrementorStyle

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

		#endregion

		#region MaxValue

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

		#endregion

		#region MinValue

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

		#endregion

		#region Increment Amount

		public int IncrementAmount
		{
			get => fIncrementAmount;
			set => fIncrementAmount = value;
		}
		int fIncrementAmount = 1;

		#endregion

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
				ValueLabel.Left -= 5;
				IncrementButton.Left -= 30;
				this.Left += 30;
			}
			if (value == IncrementorStyle.Normal)
			{
				ValueLabel.Size = DPIScalingHelper.GetScaledSize(43, 23);
				ValueLabel.Left += 5;
				IncrementButton.Left += 30;
				this.Left -= 30;
			}
		}

		#endregion

		#region Event Handling

		#region IncrementButton_Click

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

		#endregion

		#region DecrementButton_Click

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
