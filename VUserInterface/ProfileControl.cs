using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Model;
using VBusiness.Profile;
using Microsoft.Win32;
using VEntityFramework.Data;
using System.Linq;

namespace VUserInterface
{
	public partial class ProfileControl : UserControl
	{
		public ProfileControl()
		{
			InitializeComponent();
		}

		public VProfile Profile
		{
			get => fProfile ?? (fProfile = GetProfile());
			set => fProfile = value;
		}

		VProfile GetProfile()
		{
			var context = new VDataContext();
			var profileName = context.GetAllFileNames<VProfile>().FirstOrDefault();
			if (profileName != null)
			{
				return context.ReadFromXML<Profile>(profileName);
			}
			return new Profile();
		}

		VProfile fProfile;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Profile != null)
			{
				this.BindingSource.DataSource = Profile;
			}
		}

		private void SaveEditButton_Click(object sender, EventArgs e)
		{
			var button = sender as Button;
			if (button.Text == "Edit")
			{
				ReadonlyPanel.Visible = false;
				EditPanel.Visible = true;
				button.Text = "Save";
			}
			else
			{
				EditPanel.Visible = false;
				ReadonlyPanel.Visible = true;
				button.Text = "Edit";
				Profile.Save();
			}
		}
	}
}
