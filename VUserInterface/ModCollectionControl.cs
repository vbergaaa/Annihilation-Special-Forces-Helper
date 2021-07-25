using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class ModCollectionControl : DPIUserControl
	{
		public ModCollectionControl()
		{
			InitializeComponent();
		}

		public VModsCollection Mods
		{
			get => fMods;
			set
			{
				if (fMods != value && value != null)
				{
					fMods = value;
					BindingSource.DataSource = fMods;
				}
			}
		}
		VModsCollection fMods;
	}
}
