using System;
using System.Windows.Forms;
using VBusiness;

namespace VUserInterface
{
	public partial class RegistryControl : UserControl
	{
		public RegistryControl()
		{
			InitializeComponent();
		}

		public Registry Registry
		{
			get => fRegistry ??= Registry.Instance;
			set => fRegistry = value;
		}

		Registry fRegistry;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Registry != null)
			{
				BindingSource.DataSource = Registry;
			}
		}

		void SaveEditButton_Click(object sender, EventArgs e)
		{
			Registry.Save();
		}

		void BankBackupFrequencyInfoButton_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Setting this will cause the application to create backups of your bank file to:\r\n\r\n\t%AppData%/AnnihilationSpecialForcesHelper/Backups/  \r\n\r\nThis will happen every time the application opens. Set this to zero to disable bank backup functionality.\r\nRequires the Profile Syncing setting to be enabled.", "Automatic bank back-up");
		}
	}
}
