using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Loadouts;
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
			this.MainTabControl = new DPITabControl();
			this.DetailsTabPage = new DPITabPage();
			this.PerksTabPage = new DPITabPage();
			this.GemsTabPage = new DPITabPage();
			this.SoulsTabPage = new DPITabPage();
			this.CPTabPage = new DPITabPage();
			this.ConfigTabPage = new DPITabPage();
			this.UnitTabPage = new DPITabPage();
			this.InfoTabControl = new DPITabControl();
			this.StatsTabPage = new DPITabPage();
			this.IncomeTabPage = new DPITabPage();
			this.PerkPageControl = new VPerkCollectionControl();
			this.LoadoutBindingSource = new System.Windows.Forms.BindingSource();
			this.StatsControl = new VStatsControl();
			this.IncomeControl = new IncomeControl();
			this.GemsControl = new VGemCollectionControl();
			this.SoulsControl = new VLoadoutSoulsControl();
			this.ChallengePointCollectionControl = new ChallengePointCollectionControl();
			this.UnitControl = new UnitConfigurationControl();
			this.LoadoutConfigurationControl = new LoadoutConfigurationControl();
			this.UseUnitStatsCheckBox = new VCheckControl();
			this.UseSingleUnitEcoCheckBox = new VCheckControl();
			this.DetailsControl = new LoadoutDetailsControl();
			((ISupportInitialize)this.LoadoutBindingSource).BeginInit();
			this.SuspendLayout();
			//
			// LoadoutBindingSource
			//
			this.LoadoutBindingSource.DataSource = typeof(Loadout);
			//
			// MainTabControl
			//
			this.MainTabControl.Anchor |= AnchorStyles.Right | AnchorStyles.Bottom;
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.Location = DPIScalingHelper.GetScaledPoint(5, 5);
			this.MainTabControl.Size = DPIScalingHelper.GetScaledSize(600, 410);
			this.MainTabControl.TabPages.Add(DetailsTabPage);
			this.MainTabControl.TabPages.Add(PerksTabPage);
			this.MainTabControl.TabPages.Add(GemsTabPage);
			this.MainTabControl.TabPages.Add(SoulsTabPage);
			this.MainTabControl.TabPages.Add(CPTabPage);
			this.MainTabControl.TabPages.Add(ConfigTabPage);
			this.MainTabControl.TabPages.Add(UnitTabPage);
			//
			// DetailsTabPage
			//
			this.DetailsTabPage.Name = "DetailsTabPage";
			this.DetailsTabPage.Text = "Details";
			this.DetailsTabPage.Controls.Add(DetailsControl);
			//
			// PerksTabPage
			//
			this.PerksTabPage.Name = "PerksTabPage";
			this.PerksTabPage.Text = "Perks";
			this.PerksTabPage.Controls.Add(PerkPageControl);
			//
			// GemsTabPage
			//
			this.GemsTabPage.Name = "GemsTabPage";
			this.GemsTabPage.Text = "Gems";
			this.GemsTabPage.Controls.Add(GemsControl);
			//
			// SoulsTabPage
			//
			this.SoulsTabPage.Name = "SoulsTabPage";
			this.SoulsTabPage.Text = "Souls";
			this.SoulsTabPage.Controls.Add(SoulsControl);
			//
			// CPTabPage
			//
			this.CPTabPage.Name = "CPTabPage";
			this.CPTabPage.Text = "Challenge Points";
			this.CPTabPage.Controls.Add(ChallengePointCollectionControl);
			//
			// ConfigTabPage
			//
			this.ConfigTabPage.Name = "ConfigTabPage";
			this.ConfigTabPage.Text = "Configuration";
			this.ConfigTabPage.Controls.Add(LoadoutConfigurationControl);
			//
			// UnitTabPage
			//
			this.UnitTabPage.Name = "UnitTabPage";
			this.UnitTabPage.Text = "Units";
			this.UnitTabPage.Controls.Add(UnitControl);
			//
			// InfoTabControl
			//
			this.InfoTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
			this.InfoTabControl.Name = "InfoTabControl";
			//this.InfoTabControl.Dock = DockStyle.Fill;
			this.InfoTabControl.Location = DPIScalingHelper.GetScaledPoint(605, 5);
			this.InfoTabControl.Size = DPIScalingHelper.GetScaledSize(190, 410);
			this.InfoTabControl.TabPages.Add(StatsTabPage);
			this.InfoTabControl.TabPages.Add(IncomeTabPage);
			//
			// StatsTabPage
			//
			this.StatsTabPage.Name = "StatsTabPage";
			this.StatsTabPage.Text = "Stats";
			this.StatsTabPage.Controls.Add(UseUnitStatsCheckBox);
			this.StatsTabPage.Controls.Add(StatsControl);
			//
			// IncomeTabPage
			//
			this.IncomeTabPage.Name = "IncomeTabPage";
			this.IncomeTabPage.Text = "Income";
			this.IncomeTabPage.Controls.Add(UseSingleUnitEcoCheckBox);
			this.IncomeTabPage.Controls.Add(IncomeControl);
			//
			// UseUnitStatsCheckBox
			//
			this.UseUnitStatsCheckBox.Name = "UseUnitStatsCheckBox";
			this.UseUnitStatsCheckBox.Caption = "Use Unit Statistics";
			this.UseUnitStatsCheckBox.DataBindings.Add("Checked", LoadoutBindingSource, "UseUnitStats");
			this.UseUnitStatsCheckBox.Location = DPIScalingHelper.GetScaledPoint(140, 10);
			//
			// UseSingleUnitEcoCheckBox
			//
			this.UseSingleUnitEcoCheckBox.Name = "UseSingleUnitEcoCheckBox";
			this.UseSingleUnitEcoCheckBox.Caption = "Current Unit Cost Only";
			this.UseSingleUnitEcoCheckBox.DataBindings.Add("Checked", LoadoutBindingSource, "UseSingleUnitEco");
			this.UseSingleUnitEcoCheckBox.Location = DPIScalingHelper.GetScaledPoint(140, 10);
			//
			// PerkPageControl
			//
			this.PerkPageControl.Location = DPIScalingHelper.GetScaledPoint(5, 10);
			this.PerkPageControl.DataBindings.Add("Perks", this.LoadoutBindingSource, "Perks");
			this.PerkPageControl.DataBindings.Add("Text", this.LoadoutBindingSource, "Perks.PageTitle");
			this.PerkPageControl.Name = "PerkPageControl";
			//
			// DetailsControl
			//
			this.DetailsControl.Dock = DockStyle.Fill;
			this.DetailsControl.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.DetailsControl.DataBindings.Add("Loadout", this.LoadoutBindingSource, ".");
			this.DetailsControl.Name = "PerkPageControl";
			//
			// GemsControl
			//
			this.GemsControl.Location = DPIScalingHelper.GetScaledPoint(5, 40);
			this.GemsControl.DataBindings.Add("Gems", this.LoadoutBindingSource, "Gems");
			this.GemsControl.Text = "Gem";
			//
			// UnitControl
			//
			this.UnitControl.Location = DPIScalingHelper.GetScaledPoint(5, 40);
			this.UnitControl.DataBindings.Add("UnitConfiguration", this.LoadoutBindingSource, "UnitConfiguration");
			this.UnitControl.Text = "Gem";
			//
			// SoulsControl
			//
			this.SoulsControl.Location = DPIScalingHelper.GetScaledPoint(5, 40);
			this.SoulsControl.DataBindings.Add("Souls", this.LoadoutBindingSource, "Souls");
			this.SoulsControl.Text = "Soul";
			//
			// ChallengePointCollectionControl
			//
			this.ChallengePointCollectionControl.Location = DPIScalingHelper.GetScaledPoint(5, 40);
			this.ChallengePointCollectionControl.DataBindings.Add("ChallengePointCollection", this.LoadoutBindingSource, "ChallengePoints");
			this.ChallengePointCollectionControl.Text = "Challenge Points";
			//
			// UpgradeControl
			//
			this.LoadoutConfigurationControl.Location = DPIScalingHelper.GetScaledPoint(5, 40);
			this.LoadoutConfigurationControl.DataBindings.Add("Loadout", this.LoadoutBindingSource, ".");
			this.LoadoutConfigurationControl.Name= "LoadoutConfigurationControl";
			//
			// StatsControl
			//
			this.StatsControl.DataBindings.Add("Stats", this.LoadoutBindingSource, "Stats");
			this.StatsControl.Name = "StatsControl";
			this.StatsControl.Location = DPIScalingHelper.GetScaledPoint(0, 30);
			//
			// IncomeControl
			//
			this.IncomeControl.DataBindings.Add("IncomeManager", this.LoadoutBindingSource, "IncomeManager");
			this.IncomeControl.Name = "IncomeControl";
			this.IncomeControl.Location = DPIScalingHelper.GetScaledPoint(0, 30);
			//
			// PerkPlanningForm
			//
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = DPIScalingHelper.GetScaledSize(800, 450);
			this.Controls.Add(MainTabControl);
			this.Controls.Add(InfoTabControl);
			this.Name = "LoadoutForm";
			this.Text = "Create/Edit Loadout";
			((ISupportInitialize)this.LoadoutBindingSource).EndInit();
			this.ResumeLayout();
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage DetailsTabPage;
		private System.Windows.Forms.TabPage PerksTabPage;
		private System.Windows.Forms.TabPage GemsTabPage;
		private System.Windows.Forms.TabPage SoulsTabPage;
		private System.Windows.Forms.TabPage CPTabPage;
		private System.Windows.Forms.TabPage ConfigTabPage;
		private System.Windows.Forms.TabPage UnitTabPage;
		private System.Windows.Forms.TabControl InfoTabControl;
		private System.Windows.Forms.TabPage StatsTabPage;
		private System.Windows.Forms.TabPage IncomeTabPage;
		private VUserInterface.VPerkCollectionControl PerkPageControl;
		private VUserInterface.VGemCollectionControl GemsControl;
		private VUserInterface.VLoadoutSoulsControl SoulsControl;
		private VUserInterface.ChallengePointCollectionControl ChallengePointCollectionControl;
		private VUserInterface.UnitConfigurationControl UnitControl;
		private VUserInterface.LoadoutConfigurationControl LoadoutConfigurationControl;
		private System.Windows.Forms.BindingSource LoadoutBindingSource;
		private VStatsControl StatsControl;
		private VCheckControl UseUnitStatsCheckBox;
		private VCheckControl UseSingleUnitEcoCheckBox;
		private IncomeControl IncomeControl;
		private LoadoutDetailsControl DetailsControl;
	}
}