using System;
using System.Threading;
using System.Windows.Forms;
using VBusiness;
using VBusiness.Profile;
using VEntityFramework.Model;
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
			try
			{
				Log.ReportInfo("Begin Initialising files from bank file.");
				InitialiseFilesFromBank();
				Log.ReportInfo("Finished initialising files from bank.");
			}
			catch (Exception ex)
			{
				Log.ReportError("Failed to sync bank file", ex);
			}

			try
			{
				AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ReportError);
				Application.ThreadException += new ThreadExceptionEventHandler(ReportError);
				Application.SetHighDpiMode(HighDpiMode.SystemAware);
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
			catch (Exception ex)
			{
				Log.ReportError("A fatal error occured", ex);
			}
		}

		static void ReportError(object sender, UnhandledExceptionEventArgs args)
		{
			if (args.ExceptionObject is Exception ex)
			{
				Log.ReportError("A Global Unhandled Exception occured", ex);
			}
			else
			{
				var info = @$"A global unhandled exception occured
The exception object is: {args.ExceptionObject};
The termination status is: {args.IsTerminating};
The sender is {sender};
The stacktrace is:
{Environment.StackTrace}";

				Log.ReportError(info, null);
			}
		}

		static void ReportError(object sender, ThreadExceptionEventArgs args)
		{
			Log.ReportError("A Global Unhandled Exception occured", args.Exception);
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
