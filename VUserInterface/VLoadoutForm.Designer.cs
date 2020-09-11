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
			this.LoadoutNameLabel = new VLabel();
			this.LoadoutNameTextBox = new TextBox();
			this.SlotNumberLabel = new VLabel();
			this.SlotNumberTextBox = new TextBox();
			this.StatsControl = new VStatsControl();
			this.PerksButton = new Button();
			this.GemsButton = new Button();
			this.SoulsButton = new Button();
			this.ChallengePointCollectionButton = new Button();
			this.UnitButton = new Button();
			this.GemsControl = new VGemCollectionControl();
			this.SoulsControl = new VSoulCollectionControl();
			this.ChallengePointCollectionControl = new ChallengePointCollectionControl();
			this.UnitControl = new UnitConfigurationControl();
			((ISupportInitialize)this.LoadoutBindingSource).BeginInit();
			//
			// LoadoutBindingSource
			//
			this.LoadoutBindingSource.DataSource = typeof(Loadout);
			//
			// LoadoutNameLabel
			//
			this.LoadoutNameLabel.Location = new System.Drawing.Point(270, 20);
			this.LoadoutNameLabel.Size = new System.Drawing.Size(120, 20);
			this.LoadoutNameLabel.Text = "Loadout Name";
			//
			// LoadoutNameTextBox
			//
			this.LoadoutNameTextBox.DataBindings.Add("Text", this.LoadoutBindingSource, "Name");
			this.LoadoutNameTextBox.Location = new System.Drawing.Point(390, 20);
			this.LoadoutNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.LoadoutNameTextBox.TextAlign = HorizontalAlignment.Center;
			//
			// SlotNumberLabel
			//
			this.SlotNumberLabel.Location = new System.Drawing.Point(120, 20);
			this.SlotNumberLabel.Size = new System.Drawing.Size(70, 20);
			this.SlotNumberLabel.Text = "Save Slot";
			//
			// SlotNumberTextBox
			//
			this.SlotNumberTextBox.DataBindings.Add("Text", this.LoadoutBindingSource, "Slot");
			this.SlotNumberTextBox.Location = new System.Drawing.Point(191, 20);
			this.SlotNumberTextBox.Size = new System.Drawing.Size(30, 20);
			this.SlotNumberTextBox.TextAlign = HorizontalAlignment.Center;
			//
			// PerkPageControl
			//
			this.PerkPageControl.Location = new System.Drawing.Point(25, 90);
			this.PerkPageControl.DataBindings.Add("Perks", this.LoadoutBindingSource, "Perks");
			this.PerkPageControl.DataBindings.Add("Text", this.LoadoutBindingSource, "Perks.PageTitle");
			//
			// GemsControl
			//
			this.GemsControl.Location = new System.Drawing.Point(25, 90);
			this.GemsControl.DataBindings.Add("Gems", this.LoadoutBindingSource, "Gems");
			this.GemsControl.Text = "Gem";
			//
			// UnitControl
			//
			this.UnitControl.Location = new System.Drawing.Point(25, 90);
			this.UnitControl.DataBindings.Add("UnitConfiguration", this.LoadoutBindingSource, "UnitConfiguration");
			this.UnitControl.Text = "Gem";
			//
			// SoulsControl
			//
			this.SoulsControl.Location = new System.Drawing.Point(25, 90);
			this.SoulsControl.DataBindings.Add("Souls", this.LoadoutBindingSource, "Souls");
			this.SoulsControl.Text = "Soul";
			//
			// ChallengePointCollectionControl
			//
			this.ChallengePointCollectionControl.Location = new System.Drawing.Point(25, 90);
			this.ChallengePointCollectionControl.DataBindings.Add("ChallengePointCollection", this.LoadoutBindingSource, "ChallengePoints");
			this.ChallengePointCollectionControl.Text = "Challenge Points";
			this.ChallengePointCollectionControl.Visible = false;
			//
			// StatsControl
			//
			this.StatsControl.DataBindings.Add("Stats", this.LoadoutBindingSource, "Stats");
			this.StatsControl.Location = new System.Drawing.Point(620, 50);
			//
			// PerksButton
			//
			this.PerksButton.Location = new System.Drawing.Point(30, 55);
			this.PerksButton.Size = new System.Drawing.Size(100, 25);
			this.PerksButton.Text = "Perks";
			this.PerksButton.FlatStyle = FlatStyle.Flat;
			this.PerksButton.Click += ControlVisibilityToggled;
			//
			// GemsButton
			//
			this.GemsButton.Location = new System.Drawing.Point(140, 55);
			this.GemsButton.Size = new System.Drawing.Size(100, 25);
			this.GemsButton.Text = "Gems";
			this.GemsButton.FlatStyle = FlatStyle.Flat;
			this.GemsButton.Click += ControlVisibilityToggled;
			//
			// SoulsButton
			//
			this.SoulsButton.Location = new System.Drawing.Point(250, 55);
			this.SoulsButton.Size = new System.Drawing.Size(100, 25);
			this.SoulsButton.Text = "Souls";
			this.SoulsButton.FlatStyle = FlatStyle.Flat;
			this.SoulsButton.Click += ControlVisibilityToggled;
			//
			// ChallengePointCollectionButton
			//
			this.ChallengePointCollectionButton.Location = new System.Drawing.Point(360, 55);
			this.ChallengePointCollectionButton.Size = new System.Drawing.Size(100, 25);
			this.ChallengePointCollectionButton.Text = "CP";
			this.ChallengePointCollectionButton.FlatStyle = FlatStyle.Flat;
			this.ChallengePointCollectionButton.Click += ControlVisibilityToggled;
			//
			// UnitButton
			//
			this.UnitButton.Location = new System.Drawing.Point(470, 55);
			this.UnitButton.Size = new System.Drawing.Size(100, 25);
			this.UnitButton.Text = "Unit";
			this.UnitButton.FlatStyle = FlatStyle.Flat;
			this.UnitButton.Click += ControlVisibilityToggled;
			//
			// PerkPlanningForm
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(LoadoutNameLabel);
			this.Controls.Add(LoadoutNameTextBox);
			this.Controls.Add(PerkPageControl);
			this.Controls.Add(SlotNumberLabel);
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
			this.Text = "Create/Edit Loadout";
			((ISupportInitialize)this.LoadoutBindingSource).EndInit();
		}

		#endregion

		private System.Windows.Forms.Button PerksButton;
		private System.Windows.Forms.Button GemsButton;
		private System.Windows.Forms.Button SoulsButton;
		private System.Windows.Forms.Button ChallengePointCollectionButton;
		private System.Windows.Forms.Button UnitButton;
		private System.Windows.Forms.Label SlotNumberLabel;
		private System.Windows.Forms.Label LoadoutNameLabel;
		private System.Windows.Forms.TextBox SlotNumberTextBox;
		private System.Windows.Forms.TextBox LoadoutNameTextBox;
		private VUserInterface.VPerkCollectionControl PerkPageControl;
		private VUserInterface.VGemCollectionControl GemsControl;
		private VUserInterface.VSoulCollectionControl SoulsControl;
		private VUserInterface.ChallengePointCollectionControl ChallengePointCollectionControl;
		private VUserInterface.UnitConfigurationControl UnitControl;
		private System.Windows.Forms.BindingSource LoadoutBindingSource;
		private VStatsControl StatsControl;
	}
}