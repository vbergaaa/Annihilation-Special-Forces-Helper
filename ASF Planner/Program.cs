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
			//this is to test the xmlwriter works
			var loadout = new Loadout();
			loadout.Perks.Attack.DesiredLevel = 4;
			new VDataContext().SaveAsXML(loadout);

			// this is to test the xmlreader works
			var bizo = new VDataContext().ReadFromXML<Loadout>("Loadout1.xml");
#endif
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PerkPlanningForm(bizo));
		}
	}
}
