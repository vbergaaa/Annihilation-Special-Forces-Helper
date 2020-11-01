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
			RefreshSouls();
		}

		readonly VDataContext context;

		#region Soul List Box

		private void DeleteSoul_Click(object sender, EventArgs e)
		{
			var SoulName = (string)SoulsListBox.SelectedItem;
			if (SoulName != null)
			{
				new VDataContext().Delete<Soul>(SoulName);
				RefreshSouls();
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
