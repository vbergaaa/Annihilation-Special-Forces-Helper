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
			this.SoloBonusCheckBox = new VCheckControl();
			this.AdrenalineRushCheckBox = new VCheckControl();
			this.DifficultyDropBox = new VDropBox();
			this.UnitSpecDropBox = new VDropBox();
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
			// SoloBonusCheckBox
			//
			this.SoloBonusCheckBox.Location = DPIScalingHelper.GetScaledPoint(125, 120);
			this.SoloBonusCheckBox.Caption = "Solo Bonus:";
			this.SoloBonusCheckBox.DataBindings.Add("Checked", BindingSource, "UnitConfiguration.HasSoloBonus");
			//
			// AdrenalineRushCheckBox
			//
			this.AdrenalineRushCheckBox.Location = DPIScalingHelper.GetScaledPoint(125, 150);
			this.AdrenalineRushCheckBox.Caption = "Adrenaline Rush:";
			this.AdrenalineRushCheckBox.DataBindings.Add("Checked", BindingSource, "UnitConfiguration.HasAdrenalineBuffActive");
			this.AdrenalineRushCheckBox.Visible = false;
			//
			// DifficutlyComboBox
			//
			this.DifficultyDropBox.DataBindings.Add("SelectedValue", BindingSource, "UnitConfiguration.DifficultyLevel");
			this.DifficultyDropBox.List = DifficultyList;
			this.DifficultyDropBox.Location = DPIScalingHelper.GetScaledPoint(125, 60);
			this.DifficultyDropBox.Caption = "Difficulty:";
			//
			// UnitSpecComboBox
			//
			this.UnitSpecDropBox.DataBindings.Add("SelectedValue", BindingSource, "UnitSpec");
			this.UnitSpecDropBox.List = UnitSpecList;
			this.UnitSpecDropBox.Location = DPIScalingHelper.GetScaledPoint(125, 90);
			this.UnitSpecDropBox.Caption = "UnitSpec:";
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
			// VLoadoutConfigurationControl
			//
			this.Controls.Add(UpgradeControl);
			this.Controls.Add(UpgradesLabel);
			this.Controls.Add(SoloBonusCheckBox);
			this.Controls.Add(AdrenalineRushCheckBox);
			this.Controls.Add(DifficultyDropBox);
			this.Controls.Add(UnitSpecDropBox);
			this.Controls.Add(SettingsLabel);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
		}

		#endregion

		VLabel UpgradesLabel;
		VLabel SettingsLabel;
		BindingSource BindingSource;
		UpgradeControl UpgradeControl;
		VCheckControl SoloBonusCheckBox;
		VCheckControl AdrenalineRushCheckBox;
		VDropBox DifficultyDropBox;
		VDropBox UnitSpecDropBox;
	}
}
