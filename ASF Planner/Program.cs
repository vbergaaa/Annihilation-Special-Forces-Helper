using System;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VEntityFramework.Data;
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
			var existingLoadout = new VDataContext().ReadFromXML<Loadout>("Loadout1.xml");

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PerkPlanningForm(existingLoadout ?? new Loadout()));
		}
	}
}
