using System;
using System.Windows.Forms;
using VBusiness;
using VBusiness.Profile;
using VUserInterface;

namespace ASFLauncher
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			InitialiseFilesFromBank();
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		static void InitialiseFilesFromBank()
		{
			if (Registry.Instance.SyncProfileWithBank)
			{
				BankFileSyncroniser.UpdateProfile(Profile.GetProfile());
			}

			if (Registry.Instance.SyncLoadoutsWithBank)
			{
				BankFileSyncroniser.UpdateAllLoadouts();
			}

			if (Registry.Instance.SyncSoulsWithBank)
			{
				BankFileSyncroniser.UpdateAllSouls();
			}
		}
	}
}
