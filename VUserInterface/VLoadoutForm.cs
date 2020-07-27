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
			Loadout.CascadeHasChanges();
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
		}

		void ShowPerks(bool visibility)
		{
			PerkPageControl.Visible = visibility;
		}

		void ShowGems(bool visibility)
		{
			//GemsControl.Visible = visibility;
		}

		#endregion
	}
}
