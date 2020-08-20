using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
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
			}
		}
		int fValue;

		#endregion

		#region MaxValue

		public int? MaxValue { get; set; }

		#endregion

		#region MinValue

		public int MinValue { get; set; }

		#endregion

		#endregion

		#region Update Buttons

		void RefreshButtons()
		{
			IncrementButton.Enabled = MaxValue.HasValue ? Value < MaxValue : true;
			DecrementButton.Enabled = Value > MinValue;
		}

		#endregion

		#region Event Handling

		#region IncrementButton_Click

		public void IncrementButton_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				Value += 10;
			}
			else
			{
				Value += 1;
			}
			RefreshButtons();
		}

		#endregion

		#region DecrementButton_Click

		public void DecrementButton_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				Value -= 10;
			}
			else
			{
				Value -= 1;
			}
			RefreshButtons();
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
