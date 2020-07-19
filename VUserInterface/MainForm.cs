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
			PopulateLoadouts();
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
			var loadout = (Loadout)LoadoutsListBox.SelectedValue;
			if (loadout != null)
			{
				var form = new VLoadoutForm(loadout);
				form.Disposed += LoadoutFormSaved;
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

		void PopulateLoadouts()
		{
			var loadouts = context.GetAllLoadoutNames().OrderBy(name => name);
			foreach (var loadout in loadouts)
			{
				LoadoutsCollection.Add(new KeyValuePair<string, Loadout>(loadout, context.ReadFromXML<Loadout>(loadout)));
			}
		}

		void RefreshLoadouts()
		{
			ClearRemovedOrRenamedLoadouts();
			AddNewOrRenamedLoadouts();
		}

		void AddNewOrRenamedLoadouts()
		{
			var loadoutNames = context.GetAllLoadoutNames().OrderBy(name => name).ToArray();
			for (var i = 0; i < loadoutNames.Count(); i++)
			{
				var loadout = loadoutNames[i];
				if (!LoadoutsCollection.Select(k => k.Key).Contains(loadout))
				{
					LoadoutsCollection.Insert(i, new KeyValuePair<string, Loadout>(loadout, context.ReadFromXML<Loadout>(loadout)));
				}
			}
		}

		void ClearRemovedOrRenamedLoadouts()
		{
			var loadoutsToRemove = new List<KeyValuePair<string, Loadout>>();
			var loadoutNames = context.GetAllLoadoutNames();

			foreach (var loadout in LoadoutsCollection)
			{
				if (!loadoutNames.Contains(loadout.Key))
				{
					loadoutsToRemove.Add(loadout);
				}
			}

			foreach (var loadout in loadoutsToRemove)
			{
				LoadoutsCollection.Remove(loadout);
			}
		}

		public BindingList<KeyValuePair<string, Loadout>> LoadoutsCollection => fLoadoutsCollection ?? (fLoadoutsCollection = new BindingList<KeyValuePair<string, Loadout>>());
		BindingList<KeyValuePair<string, Loadout>> fLoadoutsCollection;

		#endregion
	}
}
