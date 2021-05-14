using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class IncomeControl : DPIGroupBox
	{
		public IncomeControl()
		{
			InitializeComponent();
		}

		public object IncomeManager { get; set; }
	}
}