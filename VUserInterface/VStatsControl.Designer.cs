using System.Windows.Forms;
using VBusiness;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class VStatsControl
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
			this.DamageLabel = new VLabel();
			this.ToughnessLabel = new VLabel();
			this.RecoveryLabel = new VLabel();
			this.AttackLabel = new VLabel();
			this.AttackSpeedLabel = new VLabel();
			this.CriticalDamageLabel = new VLabel();
			this.CriticalChanceLabel = new VLabel();
			this.HealthLabel = new VLabel();
			this.HealthArmorLabel = new VLabel();
			this.ShieldsLabel = new VLabel();
			this.ShieldsArmorLabel = new VLabel();
			this.DamageReductionLabel = new VLabel();
			this.DamageIncreaseLabel = new VLabel();
			this.AccelLabel = new VLabel();
			this.statsBindingSource = new VBindingSource();
			this.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).BeginInit();
			//
			// statsBindingSource
			//
			this.statsBindingSource.DataSource = typeof(Stats);
			// 
			// DamageLabel
			// 
			this.DamageLabel.Caption = "Damage Score:";
			this.DamageLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Damage"));
			this.DamageLabel.Location = DPIScalingHelper.GetScaledPoint(120,20);
			this.DamageLabel.Name = "DamageLabel";
			this.DamageLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.DamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DamageLabel.UseNumberSuffixes = true;
			// 
			// ToughnessLabel
			// 
			this.ToughnessLabel.Caption = "Toughness Score:";
			this.ToughnessLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Toughness"));
			this.ToughnessLabel.Location = DPIScalingHelper.GetScaledPoint(120,40);
			this.ToughnessLabel.Name = "ToughnessLabel";
			this.ToughnessLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.ToughnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ToughnessLabel.UseNumberSuffixes = true;
			// 
			// RecoveryLabel
			// 
			this.RecoveryLabel.Caption = "Recovery:";
			this.RecoveryLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Recovery"));
			this.RecoveryLabel.Location = DPIScalingHelper.GetScaledPoint(120,60);
			this.RecoveryLabel.Name = "RecoveryLabel";
			this.RecoveryLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.RecoveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DamageIncreaseLabel
			// 
			this.DamageIncreaseLabel.Caption = "Dmg Increase:";
			this.DamageIncreaseLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "DamageIncreaseForBinding"));
			this.DamageIncreaseLabel.Location = DPIScalingHelper.GetScaledPoint(120,260);
			this.DamageIncreaseLabel.Name = "DamageIncreaseLabel";
			this.DamageIncreaseLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.DamageIncreaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AttackLabel
			// 
			this.AttackLabel.Caption = "Attack";
			this.AttackLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "AttackForBinding"));
			this.AttackLabel.Location = DPIScalingHelper.GetScaledPoint(120,80);
			this.AttackLabel.Name = "AttackLabel";
			this.AttackLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.AttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AttackSpeedLabel
			// 
			this.AttackSpeedLabel.Caption = "Attack Speed:";
			this.AttackSpeedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "AttackSpeedForBinding"));
			this.AttackSpeedLabel.Location = DPIScalingHelper.GetScaledPoint(120,100);
			this.AttackSpeedLabel.Name = "AttackSpeedLabel";
			this.AttackSpeedLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.AttackSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CriticalChanceLabel
			// 
			this.CriticalChanceLabel.Caption = "Crit Chance:";
			this.CriticalChanceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "CriticalChanceForBinding"));
			this.CriticalChanceLabel.Location = DPIScalingHelper.GetScaledPoint(120,120);
			this.CriticalChanceLabel.Name = "CriticalChanceLabel";
			this.CriticalChanceLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.CriticalChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CriticalDamageLabel
			// 
			this.CriticalDamageLabel.Caption = "Crit Damage:";
			this.CriticalDamageLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "CriticalDamageForBinding"));
			this.CriticalDamageLabel.Location = DPIScalingHelper.GetScaledPoint(120,140);
			this.CriticalDamageLabel.Name = "CriticalDamageLabel";
			this.CriticalDamageLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.CriticalDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HealthLabel
			// 
			this.HealthLabel.Caption = "Health:";
			this.HealthLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "HealthForBinding"));
			this.HealthLabel.Location = DPIScalingHelper.GetScaledPoint(120,160);
			this.HealthLabel.Name = "HealthLabel";
			this.HealthLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.HealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HealthArmorLabel
			// 
			this.HealthArmorLabel.Caption = "Health Armor:";
			this.HealthArmorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "HealthArmorForBinding"));
			this.HealthArmorLabel.Location = DPIScalingHelper.GetScaledPoint(120,180);
			this.HealthArmorLabel.Name = "HealthArmorLabel";
			this.HealthArmorLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.HealthArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ShieldsLabel
			// 
			this.ShieldsLabel.Caption = "Shields:";
			this.ShieldsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "ShieldsForBinding"));
			this.ShieldsLabel.Location = DPIScalingHelper.GetScaledPoint(120,200);
			this.ShieldsLabel.Name = "ShieldsLabel";
			this.ShieldsLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.ShieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ShieldsArmorLabel
			// 
			this.ShieldsArmorLabel.Caption = "Shields Armor:";
			this.ShieldsArmorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "ShieldsArmorForBinding"));
			this.ShieldsArmorLabel.Location = DPIScalingHelper.GetScaledPoint(120,220);
			this.ShieldsArmorLabel.Name = "ShieldsArmorLabel";
			this.ShieldsArmorLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.ShieldsArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DamageReductionLabel
			// 
			this.DamageReductionLabel.Caption = "Dmg Rdct:";
			this.DamageReductionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "DamageReductionForBinding"));
			this.DamageReductionLabel.Location = DPIScalingHelper.GetScaledPoint(120,280);
			this.DamageReductionLabel.Name = "DamageReductionLabel";
			this.DamageReductionLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.DamageReductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AccelLabel
			// 
			this.AccelLabel.Caption = "Acceleration:";
			this.AccelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "AccelerationForBinding"));
			this.AccelLabel.Location = DPIScalingHelper.GetScaledPoint(120,240);
			this.AccelLabel.Name = "AccelLabel";
			this.AccelLabel.Size = DPIScalingHelper.GetScaledSize(62, 21);
			this.AccelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// StatsControl
			//
			this.Controls.Add(DamageLabel);
			this.Controls.Add(ToughnessLabel);
			this.Controls.Add(AttackLabel);
			this.Controls.Add(AttackSpeedLabel);
			this.Controls.Add(CriticalDamageLabel);
			this.Controls.Add(CriticalChanceLabel);
			this.Controls.Add(HealthLabel);
			this.Controls.Add(HealthArmorLabel);
			this.Controls.Add(ShieldsLabel);
			this.Controls.Add(ShieldsArmorLabel);
			this.Controls.Add(DamageReductionLabel);
			this.Controls.Add(DamageIncreaseLabel);
			this.Controls.Add(AccelLabel);
			this.Size = DPIScalingHelper.GetScaledSize(175, 310);
			this.Text = "Stats";
			((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private VLabel DamageLabel;
		private VLabel ToughnessLabel;
		private VLabel RecoveryLabel;
		private VLabel AttackLabel;
		private VLabel AttackSpeedLabel;
		private VLabel CriticalDamageLabel;
		private VLabel CriticalChanceLabel;
		private VLabel HealthLabel;
		private VLabel HealthArmorLabel;
		private VLabel ShieldsLabel;
		private VLabel ShieldsArmorLabel;
		private VLabel DamageReductionLabel;
		private VLabel DamageIncreaseLabel;
		private VLabel AccelLabel;
		private System.Windows.Forms.BindingSource statsBindingSource;
	}
}
