using VBusiness;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class UpgradeControl : DPIUserControl
	{
		public UpgradeControl()
		{
			InitializeComponent();
		}

		public UpgradeManager Upgrades
		{
			get => fUpgradeManager;
			set
			{
				if (value != fUpgradeManager && value != null)
				{
					fUpgradeManager = value;
					BindingSource.DataSource = value;
				}
			}
		}
		UpgradeManager fUpgradeManager;
	}
}
