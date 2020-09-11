using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VIncrementor : UserControl
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
			this.DecrementButton.Left += width;
			this.IncrementButton.Left += width;
			this.ValueLabel.Left += width;
		}

		string fCaption;

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
}
