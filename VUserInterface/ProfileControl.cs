using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VEntityFramework.Model;
using VBusiness.HelperClasses;
using VUserInterface.CommonControls;
using EnumsNET;
using System.Linq;

namespace VUserInterface
{
	public partial class ProfileControl : DPIUserControl
	{
		public ProfileControl()
		{
			InitializeComponent();
		}

		public VProfile Profile
		{
			get => fProfile ??= VBusiness.Profile.Profile.GetProfile();
			set => fProfile = value;
		}

		VProfile fProfile;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Profile != null)
			{
				BindingSource.DataSource = Profile;
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
			else if (button.Text == "Save")
			{
				Profile.RunPreSaveValidation();
				if (!Profile.Notifications.HasErrors())
				{
					EditPanel.Visible = false;
					ReadonlyPanel.Visible = true;
					button.Text = "Edit";
					Profile.Save();
				}
				else
				{
					MessageBox.Show("Unable to save, Error: " + Profile.Notifications.Errors[0]);
				}
			}
		}

		List<object> PlayerRankList => fPlayerRankList ??= BindingHelper<PlayerRank>.ConvertForBinding(Enums.GetValues<PlayerRank>().ToList());
		List<object> fPlayerRankList;

		void PlayerRankChanged(object sender, EventArgs e)
		{
			if (Profile != null && RankDropBox.SelectedValue is PlayerRank rank)
			{
				Profile.Rank = rank;
			}
		}

		private void AchievementsButton_Click(object sender, System.EventArgs e)
		{
			var form = new AchievementsForm();
			form.Show();
		}

		private void ModsButton_Click(object sender, System.EventArgs e)
		{
			var form = new PlayerModsForm(Profile.PlayerMods);
			form.Show();
		}
	}
}
