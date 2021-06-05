using VBusiness;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class IncomeControl
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
			this.DoubleWarpLabel = new VLabel();
			this.TripleWarpLabel = new VLabel();
			this.LoadoutMineralCostLabel = new VLabel();
			this.LoadoutKillCostLabel = new VLabel();
			this.VeterancyLabel = new VLabel();
			this.InfuseRecycleLabel = new VLabel();
			this.KillRecycleLabel = new VLabel();
			this.RankRevisionLabel = new VLabel();
			this.MineralsPerWaveLabel = new VLabel();
			this.KillsPerWaveLabel = new VLabel();
			this.bindingSource = new System.Windows.Forms.BindingSource();
			this.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// statsBindingSource
			//
			this.bindingSource.DataSource = typeof(IncomeManager);
			//
			// LoadoutMineralCostLabel
			//
			this.LoadoutMineralCostLabel.Caption = "Mineral Cost:";
			this.LoadoutMineralCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LoadoutMineralCost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.LoadoutMineralCostLabel.Location = DPIScalingHelper.GetScaledPoint(120, 20);
			this.LoadoutMineralCostLabel.Name = "LoadoutMineralCostLabel";
			this.LoadoutMineralCostLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.LoadoutMineralCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LoadoutMineralCostLabel.UseNumberSuffixes = true;
			//
			// LoadoutKillCostLabel
			//
			this.LoadoutKillCostLabel.Caption = "Kill Cost:";
			this.LoadoutKillCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "LoadoutKillCost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.LoadoutKillCostLabel.Location = DPIScalingHelper.GetScaledPoint(120, 40);
			this.LoadoutKillCostLabel.Name = "LoadoutKillCostLabel";
			this.LoadoutKillCostLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.LoadoutKillCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LoadoutKillCostLabel.UseNumberSuffixes = true;
			//
			// DoubleWarpLabel
			//
			this.DoubleWarpLabel.Caption = "Double Warp:";
			this.DoubleWarpLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DoubleWarp"));
			this.DoubleWarpLabel.Location = DPIScalingHelper.GetScaledPoint(120, 60);
			this.DoubleWarpLabel.Name = "DoubleWarpLabel";
			this.DoubleWarpLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.DoubleWarpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// TripleWarpLabel
			//
			this.TripleWarpLabel.Caption = "Triple Warp:";
			this.TripleWarpLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TripleWarp"));
			this.TripleWarpLabel.Location = DPIScalingHelper.GetScaledPoint(120, 80);
			this.TripleWarpLabel.Name = "TripleWarpLabel";
			this.TripleWarpLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.TripleWarpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// VeterencyLabel
			//
			this.VeterancyLabel.Caption = "Veterancy:";
			this.VeterancyLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Veterancy"));
			this.VeterancyLabel.Location = DPIScalingHelper.GetScaledPoint(120, 100);
			this.VeterancyLabel.Name = "VeterancyLabel";
			this.VeterancyLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.VeterancyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// InfuseRecycleLabel
			//
			this.InfuseRecycleLabel.Caption = "Infusion Recycle:";
			this.InfuseRecycleLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InfuseRecycle"));
			this.InfuseRecycleLabel.Location = DPIScalingHelper.GetScaledPoint(120, 120);
			this.InfuseRecycleLabel.Name = "InfuseRecycleLabel";
			this.InfuseRecycleLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.InfuseRecycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// KillRecycleLabel
			//
			this.KillRecycleLabel.Caption = "Kill Recycle:";
			this.KillRecycleLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "KillRecycle"));
			this.KillRecycleLabel.Location = DPIScalingHelper.GetScaledPoint(120, 140);
			this.KillRecycleLabel.Name = "KillRecycleLabel";
			this.KillRecycleLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.KillRecycleLabel.Suffix = "%";
			this.KillRecycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// VeterencyLabel
			//
			this.RankRevisionLabel.Caption = "Rank Revision:";
			this.RankRevisionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "RankRevision"));
			this.RankRevisionLabel.Location = DPIScalingHelper.GetScaledPoint(120, 160);
			this.RankRevisionLabel.Name = "RankRevisionLabel";
			this.RankRevisionLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.RankRevisionLabel.Suffix = "%";
			this.RankRevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// MineralsPerWaveLabel
			//
			this.MineralsPerWaveLabel.Caption = "Minerals Per Wave:";
			this.MineralsPerWaveLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MineralsPerWave"));
			this.MineralsPerWaveLabel.Location = DPIScalingHelper.GetScaledPoint(120, 180);
			this.MineralsPerWaveLabel.Name = "MineralsPerWaveLabel";
			this.MineralsPerWaveLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.MineralsPerWaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// KillsPerWaveLabel
			//
			this.KillsPerWaveLabel.Caption = "Kills Per Wave:";
			this.KillsPerWaveLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "KillsPerWave"));
			this.KillsPerWaveLabel.Location = DPIScalingHelper.GetScaledPoint(120, 200);
			this.KillsPerWaveLabel.Name = "KillsPerWaveLabel";
			this.KillsPerWaveLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.KillsPerWaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// StatsControl
			//
			this.Controls.Add(DoubleWarpLabel);
			this.Controls.Add(TripleWarpLabel);
			this.Controls.Add(LoadoutMineralCostLabel);
			this.Controls.Add(LoadoutKillCostLabel);
			this.Controls.Add(VeterancyLabel);
			this.Controls.Add(InfuseRecycleLabel);
			this.Controls.Add(KillRecycleLabel);
			this.Controls.Add(RankRevisionLabel);
			this.Controls.Add(MineralsPerWaveLabel);
			this.Controls.Add(KillsPerWaveLabel);
			this.Size = DPIScalingHelper.GetScaledSize(175, 310);
			this.Text = "Income";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private VLabel DoubleWarpLabel;
		private VLabel TripleWarpLabel;
		private VLabel VeterancyLabel;
		private VLabel InfuseRecycleLabel;
		private VLabel KillRecycleLabel;
		private VLabel RankRevisionLabel;
		private VLabel MineralsPerWaveLabel;
		private VLabel KillsPerWaveLabel;
		private System.Windows.Forms.BindingSource bindingSource;
		private VLabel LoadoutMineralCostLabel;
		private VLabel LoadoutKillCostLabel;
	}
}
