using System;
using System.Linq;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VModel.Loadouts;

namespace ASF_Planner
{
	public partial class PerkPlanningForm : Form
	{
		public PerkPlanningForm(Loadout loadout)
		{
			InitializeComponent();
			Loadout = loadout ?? new Loadout();
			AddNewBindings();
		}
		public PerkPlanningForm()
			: this(null)
		{
		}

		private void AddNewBindings()
		{
			this.perkPageBindingSource.DataSource = Loadout;
		}

		public Loadout Loadout { get; set; }
	}
}
