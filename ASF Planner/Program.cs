using System;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VData;

namespace ASF_Planner
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
#if DEBUG
			// this is to test the xmlwriter works
			var perk = new Loadout();
			var xmlWriter = new VXMLWriter();
			xmlWriter.Write(perk);
#endif
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PerkPlanningForm());
		}
	}
}
