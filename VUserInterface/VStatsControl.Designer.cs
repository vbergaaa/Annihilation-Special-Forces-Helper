using VBusiness;

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
			this.DamageCaption = new System.Windows.Forms.Label();
			this.ToughnessCaption = new System.Windows.Forms.Label();
			this.RecoveryCaption = new System.Windows.Forms.Label();
			this.AttackCaption = new System.Windows.Forms.Label();
			this.AttackSpeedCaption = new System.Windows.Forms.Label();
			this.CriticalDamageCaption = new System.Windows.Forms.Label();
			this.CriticalChanceCaption = new System.Windows.Forms.Label();
			this.HealthCaption = new System.Windows.Forms.Label();
			this.HealthArmorCaption = new System.Windows.Forms.Label();
			this.ShieldsCaption = new System.Windows.Forms.Label();
			this.ShieldsArmorCaption = new System.Windows.Forms.Label();
			this.DamageLabel = new System.Windows.Forms.Label();
			this.ToughnessLabel = new System.Windows.Forms.Label();
			this.RecoveryLabel = new System.Windows.Forms.Label();
			this.AttackLabel = new System.Windows.Forms.Label();
			this.AttackSpeedLabel = new System.Windows.Forms.Label();
			this.CriticalDamageLabel = new System.Windows.Forms.Label();
			this.CriticalChanceLabel = new System.Windows.Forms.Label();
			this.HealthLabel = new System.Windows.Forms.Label();
			this.HealthArmorLabel = new System.Windows.Forms.Label();
			this.ShieldsLabel = new System.Windows.Forms.Label();
			this.ShieldsArmorLabel = new System.Windows.Forms.Label();
			this.DamageReductionCaption = new System.Windows.Forms.Label();
			this.DamageReductionLabel = new System.Windows.Forms.Label();
			this.statsBindingSource = new System.Windows.Forms.BindingSource();
			this.DisclaimerLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).BeginInit();
			//
			// statsBindingSource
			//
			this.statsBindingSource.DataSource = typeof(Stats);
			// 
			// DamageCaption
			// 
			this.DamageCaption.Location = new System.Drawing.Point(5, 20);
			this.DamageCaption.Name = "DamageCaption";
			this.DamageCaption.Size = new System.Drawing.Size(100, 20);
			this.DamageCaption.Text = "Damage:";
			this.DamageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DamageLabel
			// 
			this.DamageLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Damage"));
			this.DamageLabel.Location = new System.Drawing.Point(110, 20);
			this.DamageLabel.Name = "DamageLabel";
			this.DamageLabel.Size = new System.Drawing.Size(50, 20);
			this.DamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ToughnessCaption
			// 
			this.ToughnessCaption.Location = new System.Drawing.Point(5, 40);
			this.ToughnessCaption.Name = "ToughnessCaption";
			this.ToughnessCaption.Size = new System.Drawing.Size(100, 20);
			this.ToughnessCaption.Text = "Toughness:";
			this.ToughnessCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ToughnessLabel
			// 
			this.ToughnessLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Toughness"));
			this.ToughnessLabel.Location = new System.Drawing.Point(110, 40);
			this.ToughnessLabel.Name = "ToughnessLabel";
			this.ToughnessLabel.Size = new System.Drawing.Size(50, 20);
			this.ToughnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RecoveryCaption
			// 
			this.RecoveryCaption.Location = new System.Drawing.Point(5, 60);
			this.RecoveryCaption.Name = "RecoveryCaption";
			this.RecoveryCaption.Size = new System.Drawing.Size(100, 20);
			this.RecoveryCaption.Text = "Recovery:";
			this.RecoveryCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// RecoveryLabel
			// 
			this.RecoveryLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Recovery"));
			this.RecoveryLabel.Location = new System.Drawing.Point(110, 60);
			this.RecoveryLabel.Name = "RecoveryLabel";
			this.RecoveryLabel.Size = new System.Drawing.Size(50, 20);
			this.RecoveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AttackCaption
			// 
			this.AttackCaption.Location = new System.Drawing.Point(5, 100);
			this.AttackCaption.Name = "AttackCaption";
			this.AttackCaption.Size = new System.Drawing.Size(100, 20);
			this.AttackCaption.Text = "Attack:";
			this.AttackCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AttackLabel
			// 
			this.AttackLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "AttackForBinding"));
			this.AttackLabel.Location = new System.Drawing.Point(110, 100);
			this.AttackLabel.Name = "AttackLabel";
			this.AttackLabel.Size = new System.Drawing.Size(50, 20);
			this.AttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AttackSpeedCaption
			// 
			this.AttackSpeedCaption.Location = new System.Drawing.Point(5, 120);
			this.AttackSpeedCaption.Name = "AttackSpeedCaption";
			this.AttackSpeedCaption.Size = new System.Drawing.Size(100, 20);
			this.AttackSpeedCaption.Text = "AttackSpeed:";
			this.AttackSpeedCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AttackSpeedLabel
			// 
			this.AttackSpeedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "AttackSpeedForBinding"));
			this.AttackSpeedLabel.Location = new System.Drawing.Point(110, 120);
			this.AttackSpeedLabel.Name = "AttackSpeedLabel";
			this.AttackSpeedLabel.Size = new System.Drawing.Size(50, 20);
			this.AttackSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CriticalChanceCaption
			// 
			this.CriticalChanceCaption.Location = new System.Drawing.Point(5, 140);
			this.CriticalChanceCaption.Name = "CriticalChanceCaption";
			this.CriticalChanceCaption.Size = new System.Drawing.Size(100, 20);
			this.CriticalChanceCaption.Text = "Critical Chance:";
			this.CriticalChanceCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CriticalChanceLabel
			// 
			this.CriticalChanceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "CriticalChanceForBinding"));
			this.CriticalChanceLabel.Location = new System.Drawing.Point(110, 140);
			this.CriticalChanceLabel.Name = "CriticalChanceLabel";
			this.CriticalChanceLabel.Size = new System.Drawing.Size(50, 20);
			this.CriticalChanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CriticalDamageCaption
			// 
			this.CriticalDamageCaption.Location = new System.Drawing.Point(5, 160);
			this.CriticalDamageCaption.Name = "CriticalDamageCaption";
			this.CriticalDamageCaption.Size = new System.Drawing.Size(100, 20);
			this.CriticalDamageCaption.Text = "Critical Damage:";
			this.CriticalDamageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CriticalDamageLabel
			// 
			this.CriticalDamageLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "CriticalDamageForBinding"));
			this.CriticalDamageLabel.Location = new System.Drawing.Point(110, 160);
			this.CriticalDamageLabel.Name = "CriticalDamageLabel";
			this.CriticalDamageLabel.Size = new System.Drawing.Size(50, 20);
			this.CriticalDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HealthCaption
			// 
			this.HealthCaption.Location = new System.Drawing.Point(5, 180);
			this.HealthCaption.Name = "HealthCaption";
			this.HealthCaption.Size = new System.Drawing.Size(100, 20);
			this.HealthCaption.Text = "Health:";
			this.HealthCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HealthLabel
			// 
			this.HealthLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "HealthForBinding"));
			this.HealthLabel.Location = new System.Drawing.Point(110, 180);
			this.HealthLabel.Name = "HealthLabel";
			this.HealthLabel.Size = new System.Drawing.Size(50, 20);
			this.HealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HealthArmorCaption
			// 
			this.HealthArmorCaption.Location = new System.Drawing.Point(5, 200);
			this.HealthArmorCaption.Name = "HealthArmorCaption";
			this.HealthArmorCaption.Size = new System.Drawing.Size(100, 20);
			this.HealthArmorCaption.Text = "Health Armor:";
			this.HealthArmorCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HealthArmorLabel
			// 
			this.HealthArmorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "HealthArmorForBinding"));
			this.HealthArmorLabel.Location = new System.Drawing.Point(110, 200);
			this.HealthArmorLabel.Name = "HealthArmorLabel";
			this.HealthArmorLabel.Size = new System.Drawing.Size(50, 20);
			this.HealthArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ShieldsCaption
			// 
			this.ShieldsCaption.Location = new System.Drawing.Point(5, 220);
			this.ShieldsCaption.Name = "ShieldsCaption";
			this.ShieldsCaption.Size = new System.Drawing.Size(100, 20);
			this.ShieldsCaption.Text = "Shields:";
			this.ShieldsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ShieldsLabel
			// 
			this.ShieldsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "ShieldsForBinding"));
			this.ShieldsLabel.Location = new System.Drawing.Point(110, 220);
			this.ShieldsLabel.Name = "ShieldsLabel";
			this.ShieldsLabel.Size = new System.Drawing.Size(50, 20);
			this.ShieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ShieldsArmorCaption
			// 
			this.ShieldsArmorCaption.Location = new System.Drawing.Point(5, 240);
			this.ShieldsArmorCaption.Name = "ShieldsArmorCaption";
			this.ShieldsArmorCaption.Size = new System.Drawing.Size(100, 20);
			this.ShieldsArmorCaption.Text = "Shields Armor:";
			this.ShieldsArmorCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ShieldsArmorLabel
			// 
			this.ShieldsArmorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "ShieldsArmorForBinding"));
			this.ShieldsArmorLabel.Location = new System.Drawing.Point(110, 240);
			this.ShieldsArmorLabel.Name = "ShieldsArmorLabel";
			this.ShieldsArmorLabel.Size = new System.Drawing.Size(50, 20);
			this.ShieldsArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DamageReductionCaption
			// 
			this.DamageReductionCaption.Location = new System.Drawing.Point(5, 260);
			this.DamageReductionCaption.Name = "DamageReductionCaption";
			this.DamageReductionCaption.Size = new System.Drawing.Size(105, 20);
			this.DamageReductionCaption.Text = "Dmg Reduction:";
			this.DamageReductionCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DamageReductionLabel
			// 
			this.DamageReductionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "DamageReduction"));
			this.DamageReductionLabel.Location = new System.Drawing.Point(110, 260);
			this.DamageReductionLabel.Name = "DamageReductionLabel";
			this.DamageReductionLabel.Size = new System.Drawing.Size(50, 20);
			this.DamageReductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DisclaimerLabel
			// 
			this.DisclaimerLabel.Location = new System.Drawing.Point(5, 80);
			this.DisclaimerLabel.Name = "DisclaimerLabel";
			this.DisclaimerLabel.Size = new System.Drawing.Size(150, 20);
			this.DisclaimerLabel.Text = "Calculations Disclaimer";
			this.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DisclaimerLabel.ForeColor = System.Drawing.Color.Blue;
			this.DisclaimerLabel.Font = new System.Drawing.Font(this.DisclaimerLabel.Font, System.Drawing.FontStyle.Underline);
			this.DisclaimerLabel.Click += DisclaimerLabel_Click;
			this.DisclaimerLabel.MouseHover += DisclaimerLabel_MouseHover;
			this.DisclaimerLabel.MouseMove += DisclaimerLabel_MouseMove;
			//
			// StatsControl
			//
			this.Controls.Add(DamageCaption);
			this.Controls.Add(DamageLabel);
			this.Controls.Add(ToughnessCaption);
			this.Controls.Add(ToughnessLabel);
			//this.Controls.Add(RecoveryLabel);
			//this.Controls.Add(RecoveryCaption);
			this.Controls.Add(AttackCaption);
			this.Controls.Add(AttackSpeedCaption);
			this.Controls.Add(CriticalDamageCaption);
			this.Controls.Add(CriticalChanceCaption);
			this.Controls.Add(HealthCaption);
			this.Controls.Add(HealthArmorCaption);
			this.Controls.Add(ShieldsCaption);
			this.Controls.Add(ShieldsArmorCaption);
			this.Controls.Add(DamageLabel);
			this.Controls.Add(ToughnessLabel);
			this.Controls.Add(RecoveryLabel);
			this.Controls.Add(AttackLabel);
			this.Controls.Add(AttackSpeedLabel);
			this.Controls.Add(CriticalDamageLabel);
			this.Controls.Add(CriticalChanceLabel);
			this.Controls.Add(HealthLabel);
			this.Controls.Add(HealthArmorLabel);
			this.Controls.Add(ShieldsLabel);
			this.Controls.Add(ShieldsArmorLabel);
			this.Controls.Add(DamageReductionCaption);
			this.Controls.Add(DamageReductionLabel);
			this.Controls.Add(DisclaimerLabel);
			this.Size = new System.Drawing.Size(170, 290);
			this.Text = "Stats";
			((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.Label DamageCaption;
		private System.Windows.Forms.Label ToughnessCaption;
		private System.Windows.Forms.Label RecoveryCaption;
		private System.Windows.Forms.Label AttackCaption;
		private System.Windows.Forms.Label AttackSpeedCaption;
		private System.Windows.Forms.Label CriticalDamageCaption;
		private System.Windows.Forms.Label CriticalChanceCaption;
		private System.Windows.Forms.Label HealthCaption;
		private System.Windows.Forms.Label HealthArmorCaption;
		private System.Windows.Forms.Label ShieldsCaption;
		private System.Windows.Forms.Label ShieldsArmorCaption;
		private System.Windows.Forms.Label DamageReductionCaption;
		private System.Windows.Forms.Label DamageLabel;
		private System.Windows.Forms.Label ToughnessLabel;
		private System.Windows.Forms.Label RecoveryLabel;
		private System.Windows.Forms.Label AttackLabel;
		private System.Windows.Forms.Label AttackSpeedLabel;
		private System.Windows.Forms.Label CriticalDamageLabel;
		private System.Windows.Forms.Label CriticalChanceLabel;
		private System.Windows.Forms.Label HealthLabel;
		private System.Windows.Forms.Label HealthArmorLabel;
		private System.Windows.Forms.Label ShieldsLabel;
		private System.Windows.Forms.Label ShieldsArmorLabel;
		private System.Windows.Forms.Label DamageReductionLabel;
		private System.Windows.Forms.BindingSource statsBindingSource;
		private System.Windows.Forms.Label DisclaimerLabel;
	}
}
