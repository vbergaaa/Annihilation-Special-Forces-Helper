using System.Collections.Generic;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class LoadoutConfigurationControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			this.BindingSource = new BindingSource();
			this.UpgradeControl = new UpgradeControl();
			this.UpgradesLabel = new VLabel();
			this.SettingsLabel = new VLabel();
			this.FarmRoomDropBox = new VDropBox();
			this.IncomeLabel = new VLabel();
			this.BrutaliskOverrideControl = new BrutaliskOverrideControl();
			this.BrutaliskOverrideCheckBox = new VCheckControl();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(Loadout);
			//
			// UpgradeControl
			//
			this.UpgradeControl.DataBindings.Add("Upgrades", BindingSource, "Upgrades");
			this.UpgradeControl.Location = DPIScalingHelper.GetScaledPoint(300, 60);
			this.UpgradeControl.Name = "UpgradeControl";
			//
			// FarmRoomComboBox
			//
			this.FarmRoomDropBox.DataBindings.Add("SelectedValue", BindingSource, "IncomeManager.FarmRoom");
			this.FarmRoomDropBox.List = FarmRoomList;
			this.FarmRoomDropBox.Location = DPIScalingHelper.GetScaledPoint(125, 180);
			this.FarmRoomDropBox.Caption = "Farming Room:";
			//
			// BrutaliskOverrideControl
			//
			this.BrutaliskOverrideControl.Caption = "Brutalisks";
			this.BrutaliskOverrideControl.DataBindings.Add("BrutaliskOverride", BindingSource, "IncomeManager.BrutaliskOverride");
			this.BrutaliskOverrideControl.Enabled = false;
			this.BrutaliskOverrideControl.Location = DPIScalingHelper.GetScaledPoint(125, 235);
			this.BrutaliskOverrideControl.Name = "BrutaliskOverrideControl";
			//
			// BrutaliskOverrideCheckBox
			//
			this.BrutaliskOverrideCheckBox.DataBindings.Add("Checked", BindingSource, "IncomeManager.BrutaliskOverride.ShouldOverrideBrutalisks");
			this.BrutaliskOverrideCheckBox.Location = DPIScalingHelper.GetScaledPoint(125, 210);
			this.BrutaliskOverrideCheckBox.Caption = "Override Brutalisks";
			this.BrutaliskOverrideCheckBox.Name = "BrutaliskOverrideCheckBox";
			this.BrutaliskOverrideCheckBox.CheckedChanged += BrutaliskOverrideCheckBox_CheckedChanged;
			//
			// UpgradesLabel
			//
			this.UpgradesLabel.Location = DPIScalingHelper.GetScaledPoint(300, 30);
			this.UpgradesLabel.Name = "UpgradesLabel";
			this.UpgradesLabel.Text = "Upgrades";
			//
			// SettingsLabel
			//
			this.SettingsLabel.Location = DPIScalingHelper.GetScaledPoint(50, 30);
			this.SettingsLabel.Name = "SettingsLabel";
			this.SettingsLabel.Text = "Settings";
			//
			// IncomeLabel
			//
			this.IncomeLabel.Location = DPIScalingHelper.GetScaledPoint(50, 160);
			this.IncomeLabel.Name = "IncomeLabel";
			this.IncomeLabel.Text = "Income";
			//
			// VLoadoutConfigurationControl
			//
			this.Controls.Add(UpgradeControl);
			this.Controls.Add(UpgradesLabel);
			this.Controls.Add(FarmRoomDropBox);
			this.Controls.Add(SettingsLabel);
			this.Controls.Add(IncomeLabel);
			this.Controls.Add(BrutaliskOverrideControl);
			this.Controls.Add(BrutaliskOverrideCheckBox);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
		}

		#endregion

		VLabel UpgradesLabel;
		VLabel SettingsLabel;
		VLabel IncomeLabel;
		BindingSource BindingSource;
		UpgradeControl UpgradeControl;
		VDropBox FarmRoomDropBox;
		BrutaliskOverrideControl BrutaliskOverrideControl;
		VCheckControl BrutaliskOverrideCheckBox;
	}
}
