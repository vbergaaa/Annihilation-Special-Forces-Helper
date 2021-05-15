using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class IncomeControl : DPIGroupBox
	{
		public IncomeControl()
		{
			InitializeComponent();
		}

		public VIncomeManager IncomeManager
		{
			get => fIncomeManager;
			set
			{
				if (value != null && value != fIncomeManager)
				{
					fIncomeManager = value;
					bindingSource.DataSource = fIncomeManager;
				}
			}
		}
		VIncomeManager fIncomeManager;
	}
}