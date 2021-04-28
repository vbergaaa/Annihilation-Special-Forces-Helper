using System;

namespace VUserInterface
{
	public partial class PowerSoulForm : SoulCollectionForm
	{
		public PowerSoulForm() : base(null)
		{
			InitializeComponent();
		}

		void InitializeComponent()
		{
			SaveButton.Visible = false;
		}

		protected override void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void UpdateCancelButton()
		{
		}
	}
}
