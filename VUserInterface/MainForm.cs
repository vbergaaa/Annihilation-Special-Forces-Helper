using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VEntityFramework.Data;

namespace VUserInterface
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			context = new VDataContext();
			RefreshLoadouts();
		}

		readonly VDataContext context;

		#region Loadout List Box

		private void DeleteLoadout_Click(object sender, EventArgs e)
		{
			var loadout = (Loadout)LoadoutsListBox.SelectedValue;
			if (loadout != null)
			{
				loadout.Delete();
				RefreshLoadouts();
			}
		}

		void OpenLoadout_Click(object sender, EventArgs e)
		{
			var loadout = new VDataContext().ReadFromXML<Loadout>((string)LoadoutsListBox.SelectedValue);
			if (loadout != null)
			{
				var form = new VLoadoutForm(loadout);
				form.OnSaved += LoadoutFormSaved;
				form.Show();
			}
		}

		void NewLoadout_Click(object sender, EventArgs e)
		{
			var loadout = new Loadout();
			var form = new VLoadoutForm(loadout);
			form.OnSaved += LoadoutFormSaved;
			form.Show();
		}

		void LoadoutFormSaved(object sender, EventArgs e)
		{
			RefreshLoadouts();
		}

		void RefreshLoadouts()
		{
			LoadoutsCollection.Clear();
			var loadouts = context.GetAllLoadoutNames().OrderBy(name => name).ToList();
			foreach (var loadout in loadouts)
			{
				LoadoutsCollection.Add(loadout);
			}
		}

		public BindingList<string> LoadoutsCollection => fLoadoutsCollection ?? (fLoadoutsCollection = new BindingList<string>());
		BindingList<string> fLoadoutsCollection;

		#endregion
	}
}
