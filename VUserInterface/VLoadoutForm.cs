using System;
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
			UpdateFormTitle();
		}

		void UpdateFormTitle()
		{
			if (Loadout.ExistsInXML)
			{
				this.Text = $"Edit Loadout: {Loadout.Name}";
			}
			else
			{
				this.Text = "Create new loadout";
			}
		}

		void AddNewBindings()
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
				fLoadout.BizoSaved += Loadout_BizoSaved;
			}
		}

		void Loadout_BizoSaved(object sender, EventArgs e)
		{
			UpdateFormTitle();
		}

		Loadout fLoadout;

		void RefreshPageLimits(object sender, EventArgs e)
		{
			var perksControl = this.Controls.Find("PerkPageControl", true)[0];
			if (perksControl is VPerkCollectionControl control)
			{
				control.RestrictPerkPageButtons();
			}
		}
	}
}
