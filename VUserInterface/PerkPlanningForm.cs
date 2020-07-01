using System;
using System.Linq;
using System.Windows.Forms;
using VBusiness.Loadouts;

namespace ASF_Planner
{
	public partial class PerkPlanningForm : Form
	{
		public PerkPlanningForm()
		{
			InitializeComponent();
			Loadout = new Loadout();
			AddNewBindings();
		}

		private void AddNewBindings()
		{
			this.perkPageBindingSource.DataSource = Loadout;
		}

		public Loadout Loadout { get; set; }
	}
}
