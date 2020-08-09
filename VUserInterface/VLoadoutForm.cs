using System.Windows.Forms;
using VBusiness.Loadouts;

namespace VUserInterface
{
	public partial class VLoadoutForm : VForm
	{
		public VLoadoutForm(Loadout loadout) : base(loadout)
		{
			InitializeComponent();
			Loadout = loadout;
			AddNewBindings();
		}
		public VLoadoutForm()
			: this(null)
		{
		}

		private void AddNewBindings()
		{
			this.LoadoutBindingSource.DataSource = Loadout;
		}

		public Loadout Loadout { get; set; }

		#region Control Visibility

		void ControlVisibilityToggled(object sender, System.EventArgs e)
		{
			if (sender is Button button)
			{
				ChangeVisibility(button.Text);
			} 
		}

		void ChangeVisibility(string text)
		{
			ShowPerks(text == "Perks");
			ShowGems(text == "Gems");
			ShowSouls(text == "Souls");
			ShowUnit(text == "Unit");
		}

		void ShowPerks(bool visibility)
		{
			PerkPageControl.Visible = visibility;
		}

		void ShowUnit(bool visibility)
		{
			UnitControl.Visible = visibility;
		}

		void ShowGems(bool visibility)
		{
			GemsControl.Visible = visibility;
		}

		void ShowSouls(bool visibility)
		{
			SoulsControl.Visible = visibility;
		}

		#endregion
	}
}
