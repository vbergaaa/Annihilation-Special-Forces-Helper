using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VEntityFramework.Model;
using VBusiness.Profile;
using VEntityFramework.Data;
using VBusiness.HelperClasses;
using VBusiness.PlayerRanks;
using VUserInterface.CommonControls;

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
			get => fProfile ??= VDataContext.Instance.Get<Profile>();
			set => fProfile = value;
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

		List<object> PlayerRankList
		{
			get => fPlayerRankList ??= BindingHelper<PlayerRank>.ConvertForBinding(new PlayerRankLookups().GetPlayerRanks());
		}
		List<object> fPlayerRankList;

		void PlayerRankChanged(object sender, EventArgs e)
		{
			if (Profile != null && RankDropBox.SelectedValue is PlayerRank rank)
			{
				Profile.Rank = rank;
			}
		}
	}
}
