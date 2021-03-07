using System;
using System.Windows.Forms;
using VBusiness.Loadouts;

namespace VUserInterface
{
	public partial class VLoadoutForm : VForm
	{
		public VLoadoutForm(Loadout loadout) : base(loadout)
		{
			InitializeComponent();
			Loadout = loadout;
			AddNewBindings();
		}
		public VLoadoutForm()
			: this(null)
		{
		}

		private void AddNewBindings()
		{
			this.LoadoutBindingSource.DataSource = Loadout;
		}

		public Loadout Loadout
		{
			get => fLoadout;
			set
			{
				fLoadout = value;
				fLoadout.ShouldRestrictChanged += RefreshPageLimits;
			}
		}
		Loadout fLoadout;

		#region Control Visibility

		void ControlVisibilityToggled(object sender, System.EventArgs e)
		{
			if (sender is Button button)
			{
				ChangeVisibility(button.Text);
			} 
		}

		void ChangeVisibility(string text)
		{
			ShowPerks(text == "Perks");
			ShowGems(text == "Gems");
			ShowSouls(text == "Souls");
			ShowCP(text == "CP");
			ShowUnit(text == "Unit");
			ShowUpgrades(text == "Config");
		}

		void ShowUpgrades(bool visibility)
		{
			LoadoutConfigurationControl.Visible = visibility;
		}

		void ShowPerks(bool visibility)
		{
			PerkPageControl.Visible = visibility;
		}

		void ShowUnit(bool visibility)
		{
			UnitControl.Visible = visibility;
		}

		void ShowGems(bool visibility)
		{
			GemsControl.Visible = visibility;
		}

		void ShowCP(bool visibility)
		{
			ChallengePointCollectionControl.Visible = visibility;
		}

		void ShowSouls(bool visibility)
		{
			SoulsControl.Visible = visibility;
		}

		#endregion

		#region RestrictCheckBox_CheckChanged

		void RestrictCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (RestrictCheckBox.Checked)
			{
				if (Loadout.CanAffordCurrentLoadout)
				{
					UpdateCostLabelsToAvailable();
				}
				else
				{
					ShowCantAffordError();
				}
			}
			else
			{
				UpdateCostLabelsToTotal();
			}
		}

		void RefreshPageLimits(object sender, EventArgs e)
		{
			var perksControl = this.Controls.Find("PerkPageControl", false)[0];
			if (perksControl is VPerkCollectionControl control)
			{
				control.RestrictPerkPageButtons();
			}
		}

		void ShowCantAffordError()
		{
			var message = GetErrorMessage();
			MessageBox.Show(message);
		}

		string GetErrorMessage()
		{
			var excessRP = Loadout.RemainingPerkPoints < 0 ? -Loadout.RemainingPerkPoints : 0;
			var excessGems = Loadout.Gems.RemainingGems < 0 ? -Loadout.Gems.RemainingGems : 0;
			var excessCP = Loadout.ChallengePoints.RemainingCP < 0 ? -Loadout.ChallengePoints.RemainingCP : 0;

			var ret = "You cannot afford this loadout.\r\n\r\nYou need:\r\n";
			ret += excessRP != 0 ? $"{excessRP} more perk points\r\n" : "";
			ret += excessGems != 0 ? $"{excessGems} more gems\r\n" : "";
			ret += excessCP != 0 ? $"{excessCP} more challenge points\r\n" : "";
			return ret;
		}

		void UpdateCostLabelsToTotal()
		{
			ClearLabelBindings();
			AvailablePPLabel.DataBindings.Add("Text", LoadoutBindingSource, "PerkPointsCost");
			AvailableGemsLabel.DataBindings.Add("Text", LoadoutBindingSource, "Gems.TotalCost");
			AvailableCPLabel.DataBindings.Add("Text", LoadoutBindingSource, "ChallengePoints.TotalCost");
			AvailablePPLabel.Caption = "Total PP:";
			AvailableGemsLabel.Caption = "Total Gems:";
			AvailableCPLabel.Caption = "Total CP:";
		}

		void UpdateCostLabelsToAvailable()
		{
			ClearLabelBindings();
			AvailablePPLabel.DataBindings.Add("Text", LoadoutBindingSource, "RemainingPerkPoints");
			AvailableGemsLabel.DataBindings.Add("Text", LoadoutBindingSource, "Gems.RemainingGems");
			AvailableCPLabel.DataBindings.Add("Text", LoadoutBindingSource, "ChallengePoints.RemainingCP");
			AvailablePPLabel.Caption = "Available PP:";
			AvailableGemsLabel.Caption = "Available Gems:";
			AvailableCPLabel.Caption = "Available CP:";
		}

		void ClearLabelBindings()
		{
			AvailableCPLabel.DataBindings.Clear();
			AvailableGemsLabel.DataBindings.Clear();
			AvailablePPLabel.DataBindings.Clear();
		}

		#endregion
	}
}
