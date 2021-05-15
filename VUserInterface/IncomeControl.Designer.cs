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
			this.UnitMineralCostLabel = new VLabel();
			this.UnitKillCostLabel = new VLabel();
			this.bindingSource = new System.Windows.Forms.BindingSource();
			this.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// statsBindingSource
			//
			this.bindingSource.DataSource = typeof(IncomeManager);
			//
			// UnitMineralCostLabel
			//
			this.UnitMineralCostLabel.Caption = "Mineral Cost:";
			this.UnitMineralCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "UnitMineralCost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.UnitMineralCostLabel.Location = DPIScalingHelper.GetScaledPoint(120, 20);
			this.UnitMineralCostLabel.Name = "UnitMineralCostLabel";
			this.UnitMineralCostLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.UnitMineralCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UnitMineralCostLabel.UseNumberSuffixes = true;
			//
			// UnitKillCostLabel
			//
			this.UnitKillCostLabel.Caption = "Kill Cost:";
			this.UnitKillCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "UnitKillCost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.UnitKillCostLabel.Location = DPIScalingHelper.GetScaledPoint(120, 40);
			this.UnitKillCostLabel.Name = "UnitKillCostLabel";
			this.UnitKillCostLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.UnitKillCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UnitKillCostLabel.UseNumberSuffixes = true;
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
			// StatsControl
			//
			this.Controls.Add(DoubleWarpLabel);
			this.Controls.Add(TripleWarpLabel);
			this.Controls.Add(UnitMineralCostLabel);
			this.Controls.Add(UnitKillCostLabel);
			this.Size = DPIScalingHelper.GetScaledSize(175, 310);
			this.Text = "Income";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private VLabel DoubleWarpLabel;
		private VLabel TripleWarpLabel;
		private System.Windows.Forms.BindingSource bindingSource;
		private VLabel UnitMineralCostLabel;
		private VLabel UnitKillCostLabel;
	}
}
