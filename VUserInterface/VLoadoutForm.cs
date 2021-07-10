using System;
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

		private void AddNewBindings()
		{
			this.LoadoutBindingSource.DataSource = Loadout;
		}

		public Loadout Loadout
		{
			get => fLoadout;
			set
			{
				fLoadout = value;
				fLoadout.ShouldRestrictChanged += RefreshPageLimits;
			}
		}
		Loadout fLoadout;

		void RefreshPageLimits(object sender, EventArgs e)
		{
			var perksControl = this.Controls.Find("PerkPageControl", false)[0];
			if (perksControl is VPerkCollectionControl control)
			{
				control.RestrictPerkPageButtons();
			}
		}
	}
}
