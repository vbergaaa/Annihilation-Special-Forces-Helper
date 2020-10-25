using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VBusiness.HelperClasses;
using VBusiness.Loadouts;
using VBusiness.Souls;
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
			RefreshSouls();
		}

		readonly VDataContext context;

		#region Loadout List Box

		private void DeleteLoadout_Click(object sender, EventArgs e)
		{
			var loadoutName = (string)LoadoutsListBox.SelectedItem;
			if (loadoutName != null)
			{
				var loadout = new VDataContext().ReadFromXML<Loadout>(loadoutName);
				if (loadout != null)
				{
					loadout.Delete();
					RefreshLoadouts();
				}
			}
		}

		void OpenLoadout_Click(object sender, EventArgs e)
		{
			var loadoutName = (string)LoadoutsListBox.SelectedItem;
			if (loadoutName != null)
			{
				var loadout = new VDataContext().ReadFromXML<Loadout>(loadoutName);
				bool test = loadout.HasChanges;
				if (loadout != null)
				{
					var form = new VLoadoutForm(loadout);
					form.OnSaved += LoadoutFormSaved;
					form.Show();
				}
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
			var loadouts = context.GetAllFileNames<Loadout>();
			loadouts = OrderHelper.OrderNamesByKey(loadouts);
			foreach (var loadout in loadouts)
			{
				LoadoutsCollection.Add(loadout);
			}
		}

		public BindingList<string> LoadoutsCollection => fLoadoutsCollection ?? (fLoadoutsCollection = new BindingList<string>());
		BindingList<string> fLoadoutsCollection;

		#endregion

		#region Soul List Box

		private void DeleteSoul_Click(object sender, EventArgs e)
		{
			var SoulName = (string)SoulsListBox.SelectedItem;
			if (SoulName != null)
			{
				var Soul = new VDataContext().ReadFromXML<Soul>(SoulName);
				if (Soul != null)
				{
					Soul.Delete();
					RefreshSouls();
				}
			}
		}

		void OpenSoul_Click(object sender, EventArgs e)
		{
			var SoulName = (string)SoulsListBox.SelectedItem;
			if (SoulName != null)
			{
				var Soul = new VDataContext().ReadFromXML<Soul>(SoulName);
				if (Soul != null)
				{
					var form = new SoulForm(Soul);
					form.OnSaved += SoulFormSaved;
					form.Show();
				}
			}
		}

		void NewSoul_Click(object sender, EventArgs e)
		{
			var form = new SoulForm(null);
			form.OnSaved += SoulFormSaved;
			form.Show();
		}

		void SoulFormSaved(object sender, EventArgs e)
		{
			RefreshSouls();
		}

		void RefreshSouls()
		{
			SoulsCollection.Clear();
			var souls = context.GetAllFileNames<Soul>();
			souls = OrderHelper.OrderNamesByKey(souls);
			foreach (var Soul in souls)
			{
				SoulsCollection.Add(Soul);
			}
		}

		public BindingList<string> SoulsCollection => fSoulsCollection ?? (fSoulsCollection = new BindingList<string>());
		BindingList<string> fSoulsCollection;

		#endregion
	}
}
