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
	}
}
