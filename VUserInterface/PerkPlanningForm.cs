using System.Windows.Forms;
using VBusiness.Loadouts;
using VUserInterface;

namespace VUserInterface
{
	public partial class PerkPlanningForm : VForm
	{
		public PerkPlanningForm(Loadout loadout) : base(loadout)
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
