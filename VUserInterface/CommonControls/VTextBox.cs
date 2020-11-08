using System;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class VTextBox : VUserControl
	{
		public VTextBox()
		{
			InitializeComponent();
		}

		#region Value

		public string Value
		{
			get => fValue;
			set
			{
				this.TextBox.Text = value;
				fValue = value;
				OnValueChanged();
			}
		}
		string fValue;

		void OnValueChanged()
		{
			ValueChanged?.Invoke(this, new EventArgs());
		}

		public event EventHandler ValueChanged;

		#endregion
	}
}
