using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VUserInterface;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class VLoadoutForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PerkPageControl = new VPerkCollectionControl();
			this.LoadoutBindingSource = new System.Windows.Forms.BindingSource();
			this.LoadoutNameTextBox = new VTextBox();
			this.SlotNumberTextBox = new VTextBox();
			this.StatsControl = new VStatsControl();
			this.PerksButton = new DPIButton();
			this.GemsButton = new DPIButton();
			this.SoulsButton = new DPIButton();
			this.ChallengePointCollectionButton = new DPIButton();
			this.UnitButton = new DPIButton();
			this.GemsControl = new VGemCollectionControl();
			this.SoulsControl = new VLoadoutSoulsControl();
			this.ChallengePointCollectionControl = new ChallengePointCollectionControl();
			this.UnitControl = new UnitConfigurationControl();
			this.AvailablePPLabel = new VLabel();
			this.AvailableGemsLabel = new VLabel();
			this.AvailableCPLabel = new VLabel();
			this.RestrictCheckBox = new VCheckControl();
			((ISupportInitialize)this.LoadoutBindingSource).BeginInit();
			this.SuspendLayout();
			//
			// LoadoutBindingSource
			//
			this.LoadoutBindingSource.DataSource = typeof(Loadout);
			//
			// LoadoutNameTextBox
			//
			this.LoadoutNameTextBox.DataBindings.Add("Text", this.LoadoutBindingSource, "Name", true);
			this.LoadoutNameTextBox.Location = DPIScalingHelper.GetScaledPoint(390, 20);
			this.LoadoutNameTextBox.Name = "LoadoutNameTextBox";
			this.LoadoutNameTextBox.Caption = "LoadoutName";
			this.LoadoutNameTextBox.Width = 100;
			//
			// SlotNumberTextBox
			//
			this.SlotNumberTextBox.DataBindings.Add("Text", this.LoadoutBindingSource, "Slot", true);
			this.SlotNumberTextBox.Location = DPIScalingHelper.GetScaledPoint(141, 20);
			this.SlotNumberTextBox.Name = "SlotNumberTextBox";
			this.SlotNumberTextBox.Width = 30;
			this.SlotNumberTextBox.Caption = "Save Slot";
			//
			// RestrictCheckBox
			//
			this.RestrictCheckBox.Name = "RestrictCheckBox";
			this.RestrictCheckBox.Caption = "Use Profile Limits";
			this.RestrictCheckBox.CheckedChanged += RestrictCheckBox_CheckedChanged;
			this.RestrictCheckBox.DataBindings.Add("Checked", LoadoutBindingSource, "ShouldRestrict");
			this.RestrictCheckBox.Location = DPIScalingHelper.GetScaledPoint(720, 20);
			//
			// AvailablePPLabel
			//
			this.AvailablePPLabel.AutoSize = true;
			this.AvailablePPLabel.DataBindings.Add("Text", LoadoutBindingSource, "RemainingPerkPoints");
			this.AvailablePPLabel.Location = DPIScalingHelper.GetScaledPoint(120, 90);
			this.AvailablePPLabel.Name = "AvailablePPLabel";
			this.AvailablePPLabel.Caption = "Available PP:";
			this.AvailablePPLabel.MaximumSize = DPIScalingHelper.GetScaledSize(150, 100);
			//
			// AvailableCPLabel
			//
			this.AvailableCPLabel.AutoSize = true;
			this.AvailableCPLabel.DataBindings.Add("Text", LoadoutBindingSource, "ChallengePoints.RemainingCP");
			this.AvailableCPLabel.Location = DPIScalingHelper.GetScaledPoint(500, 90);
			this.AvailableCPLabel.Name = "AvailableCPLabel";
			this.AvailableCPLabel.Caption = "Available CP:";
			this.AvailableCPLabel.MaximumSize = DPIScalingHelper.GetScaledSize(150, 100);
			//
			// AvailableGemsLabel
			//
			this.AvailableGemsLabel.AutoSize = true;
			this.AvailableGemsLabel.DataBindings.Add("Text", LoadoutBindingSource, "Gems.RemainingGems");
			this.AvailableGemsLabel.Location = DPIScalingHelper.GetScaledPoint(320, 90);
			this.AvailableGemsLabel.Name = "AvailableGemsLabel";
			this.AvailableGemsLabel.Caption = "Available Gems:";
			this.AvailableGemsLabel.MaximumSize = DPIScalingHelper.GetScaledSize(150, 100);
			//
			// PerkPageControl
			//
			this.PerkPageControl.Location = DPIScalingHelper.GetScaledPoint(25, 120);
			this.PerkPageControl.DataBindings.Add("Perks", this.LoadoutBindingSource, "Perks");
			this.PerkPageControl.DataBindings.Add("Text", this.LoadoutBindingSource, "Perks.PageTitle");
			this.PerkPageControl.Name = "PerkPageControl";
			//
			// GemsControl
			//
			this.GemsControl.Location = DPIScalingHelper.GetScaledPoint(25, 120);
			this.GemsControl.DataBindings.Add("Gems", this.LoadoutBindingSource, "Gems");
			this.GemsControl.Text = "Gem";
			//
			// UnitControl
			//
			this.UnitControl.Location = DPIScalingHelper.GetScaledPoint(25, 120);
			this.UnitControl.DataBindings.Add("UnitConfiguration", this.LoadoutBindingSource, "UnitConfiguration");
			this.UnitControl.Text = "Gem";
			//
			// SoulsControl
			//
			this.SoulsControl.Location = DPIScalingHelper.GetScaledPoint(25, 120);
			this.SoulsControl.DataBindings.Add("Souls", this.LoadoutBindingSource, "Souls");
			this.SoulsControl.Text = "Soul";
			//
			// ChallengePointCollectionControl
			//
			this.ChallengePointCollectionControl.Location = DPIScalingHelper.GetScaledPoint(25, 120);
			this.ChallengePointCollectionControl.DataBindings.Add("ChallengePointCollection", this.LoadoutBindingSource, "ChallengePoints");
			this.ChallengePointCollectionControl.Text = "Challenge Points";
			this.ChallengePointCollectionControl.Visible = false;
			//
			// StatsControl
			//
			this.StatsControl.DataBindings.Add("Stats", this.LoadoutBindingSource, "Stats");
			this.StatsControl.Location = DPIScalingHelper.GetScaledPoint(620, 50);
			//
			// PerksButton
			//
			this.PerksButton.Location = DPIScalingHelper.GetScaledPoint(30, 55);
			this.PerksButton.Size = DPIScalingHelper.GetScaledSize(100, 28);
			this.PerksButton.Text = "Perks";
			this.PerksButton.FlatStyle = FlatStyle.Flat;
			this.PerksButton.Click += ControlVisibilityToggled;
			//
			// GemsButton
			//
			this.GemsButton.Location = DPIScalingHelper.GetScaledPoint(140, 55);
			this.GemsButton.Size = DPIScalingHelper.GetScaledSize(100, 28);
			this.GemsButton.Text = "Gems";
			this.GemsButton.FlatStyle = FlatStyle.Flat;
			this.GemsButton.Click += ControlVisibilityToggled;
			//
			// SoulsButton
			//
			this.SoulsButton.Location = DPIScalingHelper.GetScaledPoint(250, 55);
			this.SoulsButton.Size = DPIScalingHelper.GetScaledSize(100, 28);
			this.SoulsButton.Text = "Souls";
			this.SoulsButton.FlatStyle = FlatStyle.Flat;
			this.SoulsButton.Click += ControlVisibilityToggled;
			//
			// ChallengePointCollectionButton
			//
			this.ChallengePointCollectionButton.Location = DPIScalingHelper.GetScaledPoint(360, 55);
			this.ChallengePointCollectionButton.Size = DPIScalingHelper.GetScaledSize(100, 28);
			this.ChallengePointCollectionButton.Text = "CP";
			this.ChallengePointCollectionButton.FlatStyle = FlatStyle.Flat;
			this.ChallengePointCollectionButton.Click += ControlVisibilityToggled;
			//
			// UnitButton
			//
			this.UnitButton.Location = DPIScalingHelper.GetScaledPoint(470, 55);
			this.UnitButton.Size = DPIScalingHelper.GetScaledSize(100, 28);
			this.UnitButton.Text = "Unit";
			this.UnitButton.FlatStyle = FlatStyle.Flat;
			this.UnitButton.Click += ControlVisibilityToggled;
			//
			// PerkPlanningForm
			//
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = DPIScalingHelper.GetScaledSize(800, 450);
			this.Controls.Add(LoadoutNameTextBox);
			this.Controls.Add(PerkPageControl);
			this.Controls.Add(SlotNumberTextBox);
			this.Controls.Add(StatsControl);
			this.Controls.Add(PerksButton);
			this.Controls.Add(GemsButton);
			this.Controls.Add(SoulsButton);
			this.Controls.Add(ChallengePointCollectionButton);
			this.Controls.Add(UnitButton);
			this.Controls.Add(GemsControl);
			this.Controls.Add(SoulsControl);
			this.Controls.Add(ChallengePointCollectionControl);
			this.Controls.Add(UnitControl);
			this.Controls.Add(AvailablePPLabel);
			this.Controls.Add(AvailableGemsLabel);
			this.Controls.Add(AvailableCPLabel);
			this.Controls.Add(RestrictCheckBox);
			this.Name = "LoadoutForm";
			this.Text = "Create/Edit Loadout";
			((ISupportInitialize)this.LoadoutBindingSource).EndInit();
			this.ResumeLayout();
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button PerksButton;
		private System.Windows.Forms.Button GemsButton;
		private System.Windows.Forms.Button SoulsButton;
		private System.Windows.Forms.Button ChallengePointCollectionButton;
		private System.Windows.Forms.Button UnitButton;
		private VLabel AvailablePPLabel;
		private VLabel AvailableGemsLabel;
		private VLabel AvailableCPLabel;
		private VTextBox SlotNumberTextBox;
		private VTextBox LoadoutNameTextBox;
		private VUserInterface.VPerkCollectionControl PerkPageControl;
		private VUserInterface.VGemCollectionControl GemsControl;
		private VUserInterface.VLoadoutSoulsControl SoulsControl;
		private VUserInterface.ChallengePointCollectionControl ChallengePointCollectionControl;
		private VUserInterface.UnitConfigurationControl UnitControl;
		private System.Windows.Forms.BindingSource LoadoutBindingSource;
		private VStatsControl StatsControl;
		private VCheckControl RestrictCheckBox;
	}
}