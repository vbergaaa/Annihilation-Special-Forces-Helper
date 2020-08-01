using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Souls;

namespace VUserInterface
{
	partial class SoulForm
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
			this.AttackSpeedCaption = new System.Windows.Forms.Label();
			this.VitalsCaption = new System.Windows.Forms.Label();
			this.ArmorCaption = new System.Windows.Forms.Label();
			this.CriticalChanceCaption = new System.Windows.Forms.Label();
			this.CriticalDamageCaption = new System.Windows.Forms.Label();
			this.MineralCaption = new System.Windows.Forms.Label();
			this.KillsCaption = new System.Windows.Forms.Label();
			this.IncrementVitalsButton = new System.Windows.Forms.Button();
			this.IncrementArmorButton = new System.Windows.Forms.Button();
			this.IncrementCriticalChanceButton = new System.Windows.Forms.Button();
			this.IncrementCriticalDamageButton = new System.Windows.Forms.Button();
			this.IncrementMineralsButton = new System.Windows.Forms.Button();
			this.IncrementKillsButton = new System.Windows.Forms.Button();
			this.DecrementVitalsButton = new System.Windows.Forms.Button();
			this.DecrementArmorButton = new System.Windows.Forms.Button();
			this.DecrementCriticalChanceButton = new System.Windows.Forms.Button();
			this.DecrementCriticalDamageButton = new System.Windows.Forms.Button();
			this.DecrementKillsButton = new System.Windows.Forms.Button();
			this.DecrementMineralsButton = new System.Windows.Forms.Button();
			this.DecrementAttackSpeedButton = new System.Windows.Forms.Button();
			this.DecrementAttackButton = new System.Windows.Forms.Button();
			this.IncrementAttackSpeedButton = new System.Windows.Forms.Button();
			this.IncrementAttackButton = new System.Windows.Forms.Button();
			this.AttackCaption = new System.Windows.Forms.Label();
			this.AttackLabel = new System.Windows.Forms.Label();
			this.AttackSpeedLabel = new System.Windows.Forms.Label();
			this.VitalsLabel = new System.Windows.Forms.Label();
			this.ArmorLabel = new System.Windows.Forms.Label();
			this.CriticalChanceLabel = new System.Windows.Forms.Label();
			this.CriticalDamageLabel = new System.Windows.Forms.Label();
			this.MineralsLabel = new System.Windows.Forms.Label();
			this.KillsLabel = new System.Windows.Forms.Label();
			this.TypeCaption = new System.Windows.Forms.Label();
			this.TypeComboBox = new System.Windows.Forms.ComboBox();
			this.BindingSource = new BindingSource();
			((ISupportInitialize)this.BindingSource).BeginInit();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(Soul);
			// 
			// AttackSpeedCaption
			// 
			this.AttackSpeedCaption.AutoSize = true;
			this.AttackSpeedCaption.Location = new System.Drawing.Point(34, 93);
			this.AttackSpeedCaption.Name = "AttackSpeedCaption";
			this.AttackSpeedCaption.Size = new System.Drawing.Size(76, 15);
			this.AttackSpeedCaption.TabIndex = 0;
			this.AttackSpeedCaption.Text = "Attack Speed";
			// 
			// VitalsCaption
			// 
			this.VitalsCaption.AutoSize = true;
			this.VitalsCaption.Location = new System.Drawing.Point(34, 124);
			this.VitalsCaption.Name = "VitalsCaption";
			this.VitalsCaption.Size = new System.Drawing.Size(35, 15);
			this.VitalsCaption.TabIndex = 1;
			this.VitalsCaption.Text = "Vitals";
			// 
			// ArmorCaption
			// 
			this.ArmorCaption.AutoSize = true;
			this.ArmorCaption.Location = new System.Drawing.Point(34, 155);
			this.ArmorCaption.Name = "ArmorCaption";
			this.ArmorCaption.Size = new System.Drawing.Size(41, 15);
			this.ArmorCaption.TabIndex = 2;
			this.ArmorCaption.Text = "Armor";
			// 
			// CriticalChanceCaption
			// 
			this.CriticalChanceCaption.AutoSize = true;
			this.CriticalChanceCaption.Location = new System.Drawing.Point(34, 186);
			this.CriticalChanceCaption.Name = "CriticalChanceCaption";
			this.CriticalChanceCaption.Size = new System.Drawing.Size(87, 15);
			this.CriticalChanceCaption.TabIndex = 3;
			this.CriticalChanceCaption.Text = "Critical Chance";
			// 
			// CriticalDamageCaption
			// 
			this.CriticalDamageCaption.AutoSize = true;
			this.CriticalDamageCaption.Location = new System.Drawing.Point(34, 217);
			this.CriticalDamageCaption.Name = "CriticalDamageCaption";
			this.CriticalDamageCaption.Size = new System.Drawing.Size(88, 15);
			this.CriticalDamageCaption.TabIndex = 4;
			this.CriticalDamageCaption.Text = "CriticalDamage";
			// 
			// MineralCaption
			// 
			this.MineralCaption.AutoSize = true;
			this.MineralCaption.Location = new System.Drawing.Point(34, 248);
			this.MineralCaption.Name = "MineralCaption";
			this.MineralCaption.Size = new System.Drawing.Size(52, 15);
			this.MineralCaption.TabIndex = 5;
			this.MineralCaption.Text = "Minerals";
			// 
			// KillsCaption
			// 
			this.KillsCaption.AutoSize = true;
			this.KillsCaption.Location = new System.Drawing.Point(34, 279);
			this.KillsCaption.Name = "KillsCaption";
			this.KillsCaption.Size = new System.Drawing.Size(28, 15);
			this.KillsCaption.TabIndex = 6;
			this.KillsCaption.Text = "Kills";
			// 
			// IncrementVitalsButton
			// 
			this.IncrementVitalsButton.Click += IncrementVitalsButton_Click;
			this.IncrementVitalsButton.Location = new System.Drawing.Point(200, 119);
			this.IncrementVitalsButton.Name = "IncrementVitalsButton";
			this.IncrementVitalsButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementVitalsButton.TabIndex = 7;
			this.IncrementVitalsButton.Text = "+";
			this.IncrementVitalsButton.UseVisualStyleBackColor = true;
			// 
			// IncrementArmorButton
			// 
			this.IncrementArmorButton.Click += IncrementArmorButton_Click;
			this.IncrementArmorButton.Location = new System.Drawing.Point(200, 150);
			this.IncrementArmorButton.Name = "IncrementArmorButton";
			this.IncrementArmorButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementArmorButton.TabIndex = 7;
			this.IncrementArmorButton.Text = "+";
			this.IncrementArmorButton.UseVisualStyleBackColor = true;
			// 
			// IncrementCriticalChanceButton
			// 
			this.IncrementCriticalChanceButton.Click += IncrementCriticalChanceButton_Click;
			this.IncrementCriticalChanceButton.Location = new System.Drawing.Point(200, 181);
			this.IncrementCriticalChanceButton.Name = "IncrementCriticalChanceButton";
			this.IncrementCriticalChanceButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementCriticalChanceButton.TabIndex = 7;
			this.IncrementCriticalChanceButton.Text = "+";
			this.IncrementCriticalChanceButton.UseVisualStyleBackColor = true;
			// 
			// IncrementCriticalDamageButton
			// 
			this.IncrementCriticalDamageButton.Click += IncrementCriticalDamageButton_Click;
			this.IncrementCriticalDamageButton.Location = new System.Drawing.Point(200, 212);
			this.IncrementCriticalDamageButton.Name = "IncrementCriticalDamageButton";
			this.IncrementCriticalDamageButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementCriticalDamageButton.TabIndex = 7;
			this.IncrementCriticalDamageButton.Text = "+";
			this.IncrementCriticalDamageButton.UseVisualStyleBackColor = true;
			// 
			// IncrementMineralsButton
			// 
			this.IncrementMineralsButton.Click += IncrementMineralsButton_Click;
			this.IncrementMineralsButton.Location = new System.Drawing.Point(200, 243);
			this.IncrementMineralsButton.Name = "IncrementMineralsButton";
			this.IncrementMineralsButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementMineralsButton.TabIndex = 7;
			this.IncrementMineralsButton.Text = "+";
			this.IncrementMineralsButton.UseVisualStyleBackColor = true;
			// 
			// IncrementKillsButton
			// 
			this.IncrementKillsButton.Click += IncrementKillsButton_Click;
			this.IncrementKillsButton.Location = new System.Drawing.Point(200, 274);
			this.IncrementKillsButton.Name = "IncrementKillsButton";
			this.IncrementKillsButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementKillsButton.TabIndex = 7;
			this.IncrementKillsButton.Text = "+";
			this.IncrementKillsButton.UseVisualStyleBackColor = true;
			// 
			// DecrementVitalsButton
			// 
			this.DecrementVitalsButton.Click += DecrementVitalsButton_Click;
			this.DecrementVitalsButton.Location = new System.Drawing.Point(127, 119);
			this.DecrementVitalsButton.Name = "DecrementVitalsButton";
			this.DecrementVitalsButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementVitalsButton.TabIndex = 7;
			this.DecrementVitalsButton.Text = "-";
			this.DecrementVitalsButton.UseVisualStyleBackColor = true;
			// 
			// DecrementArmorButton
			// 
			this.DecrementArmorButton.Click += DecrementArmorButton_Click;
			this.DecrementArmorButton.Location = new System.Drawing.Point(127, 150);
			this.DecrementArmorButton.Name = "DecrementArmorButton";
			this.DecrementArmorButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementArmorButton.TabIndex = 7;
			this.DecrementArmorButton.Text = "-";
			this.DecrementArmorButton.UseVisualStyleBackColor = true;
			// 
			// DecrementCriticalChanceButton
			// 
			this.DecrementCriticalChanceButton.Click += DecrementCriticalChanceButton_Click;
			this.DecrementCriticalChanceButton.Location = new System.Drawing.Point(127, 181);
			this.DecrementCriticalChanceButton.Name = "DecrementCriticalChanceButton";
			this.DecrementCriticalChanceButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementCriticalChanceButton.TabIndex = 7;
			this.DecrementCriticalChanceButton.Text = "-";
			this.DecrementCriticalChanceButton.UseVisualStyleBackColor = true;
			// 
			// DecrementCriticalDamageButton
			// 
			this.DecrementCriticalDamageButton.Click += DecrementCriticalDamageButton_Click;
			this.DecrementCriticalDamageButton.Location = new System.Drawing.Point(127, 212);
			this.DecrementCriticalDamageButton.Name = "DecrementCriticalDamageButton";
			this.DecrementCriticalDamageButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementCriticalDamageButton.TabIndex = 7;
			this.DecrementCriticalDamageButton.Text = "-";
			this.DecrementCriticalDamageButton.UseVisualStyleBackColor = true;
			// 
			// DecrementKillsButton
			// 
			this.DecrementKillsButton.Click += DecrementKillsButton_Click;
			this.DecrementKillsButton.Location = new System.Drawing.Point(127, 274);
			this.DecrementKillsButton.Name = "DecrementKillsButton";
			this.DecrementKillsButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementKillsButton.TabIndex = 7;
			this.DecrementKillsButton.Text = "-";
			this.DecrementKillsButton.UseVisualStyleBackColor = true;
			// 
			// DecrementMineralsButton
			// 
			this.DecrementMineralsButton.Click += DecrementMineralsButton_Click;
			this.DecrementMineralsButton.Location = new System.Drawing.Point(127, 243);
			this.DecrementMineralsButton.Name = "DecrementMineralsButton";
			this.DecrementMineralsButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementMineralsButton.TabIndex = 7;
			this.DecrementMineralsButton.Text = "-";
			this.DecrementMineralsButton.UseVisualStyleBackColor = true;
			// 
			// DecrementAttackSpeedButton
			// 
			this.DecrementAttackSpeedButton.Click += DecrementAttackSpeedButton_Click;
			this.DecrementAttackSpeedButton.Location = new System.Drawing.Point(127, 88);
			this.DecrementAttackSpeedButton.Name = "DecrementAttackSpeedButton";
			this.DecrementAttackSpeedButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementAttackSpeedButton.TabIndex = 7;
			this.DecrementAttackSpeedButton.Text = "-";
			this.DecrementAttackSpeedButton.UseVisualStyleBackColor = true;
			// 
			// DecrementAttackButton
			// 
			this.DecrementAttackButton.Click += DecrementAttackButton_Click;
			this.DecrementAttackButton.Location = new System.Drawing.Point(127, 57);
			this.DecrementAttackButton.Name = "DecrementAttackButton";
			this.DecrementAttackButton.Size = new System.Drawing.Size(25, 25);
			this.DecrementAttackButton.TabIndex = 7;
			this.DecrementAttackButton.Text = "-";
			this.DecrementAttackButton.UseVisualStyleBackColor = true;
			// 
			// IncrementAttackSpeedButton
			// 
			this.IncrementAttackSpeedButton.Click += IncrementAttackSpeedButton_Click;
			this.IncrementAttackSpeedButton.Location = new System.Drawing.Point(200, 88);
			this.IncrementAttackSpeedButton.Name = "IncrementAttackSpeedButton";
			this.IncrementAttackSpeedButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementAttackSpeedButton.TabIndex = 7;
			this.IncrementAttackSpeedButton.Text = "+";
			this.IncrementAttackSpeedButton.UseVisualStyleBackColor = true;
			// 
			// IncrementAttackButton
			// 
			this.IncrementAttackButton.Click += IncrementAttackButton_Click;
			this.IncrementAttackButton.Location = new System.Drawing.Point(200, 57);
			this.IncrementAttackButton.Name = "IncrementAttackButton";
			this.IncrementAttackButton.Size = new System.Drawing.Size(25, 25);
			this.IncrementAttackButton.TabIndex = 7;
			this.IncrementAttackButton.Text = "+";
			this.IncrementAttackButton.UseVisualStyleBackColor = true;
			// 
			// AttackCaption
			// 
			this.AttackCaption.AutoSize = true;
			this.AttackCaption.Location = new System.Drawing.Point(34, 62);
			this.AttackCaption.Name = "AttackCaption";
			this.AttackCaption.Size = new System.Drawing.Size(41, 15);
			this.AttackCaption.TabIndex = 0;
			this.AttackCaption.Text = "Attack";
			// 
			// AttackLabel
			// 
			this.AttackLabel.AutoSize = true;
			this.AttackLabel.DataBindings.Add("Text", BindingSource, "Attack");
			this.AttackLabel.Location = new System.Drawing.Point(158, 62);
			this.AttackLabel.Name = "AttackLabel";
			this.AttackLabel.Size = new System.Drawing.Size(0, 15);
			this.AttackLabel.TabIndex = 0;
			// 
			// AttackSpeedLabel
			// 
			this.AttackSpeedLabel.AutoSize = true;
			this.AttackSpeedLabel.DataBindings.Add("Text", BindingSource, "AttackSpeed");
			this.AttackSpeedLabel.Location = new System.Drawing.Point(158, 93);
			this.AttackSpeedLabel.Name = "AttackSpeedLabel";
			this.AttackSpeedLabel.Size = new System.Drawing.Size(0, 15);
			this.AttackSpeedLabel.TabIndex = 0;
			// 
			// VitalsLabel
			// 
			this.VitalsLabel.AutoSize = true;
			this.VitalsLabel.DataBindings.Add("Text", BindingSource, "Vitals");
			this.VitalsLabel.Location = new System.Drawing.Point(158, 124);
			this.VitalsLabel.Name = "VitalsLabel";
			this.VitalsLabel.Size = new System.Drawing.Size(0, 15);
			this.VitalsLabel.TabIndex = 0;
			// 
			// ArmorLabel
			// 
			this.ArmorLabel.AutoSize = true;
			this.ArmorLabel.DataBindings.Add("Text", BindingSource, "Armor");
			this.ArmorLabel.Location = new System.Drawing.Point(158, 155);
			this.ArmorLabel.Name = "ArmorLabel";
			this.ArmorLabel.Size = new System.Drawing.Size(0, 15);
			this.ArmorLabel.TabIndex = 0;
			// 
			// CriticalChanceLabel
			// 
			this.CriticalChanceLabel.AutoSize = true;
			this.CriticalChanceLabel.DataBindings.Add("Text", BindingSource, "CriticalChance");
			this.CriticalChanceLabel.Location = new System.Drawing.Point(158, 186);
			this.CriticalChanceLabel.Name = "CriticalChanceLabel";
			this.CriticalChanceLabel.Size = new System.Drawing.Size(0, 15);
			this.CriticalChanceLabel.TabIndex = 0;
			// 
			// CriticalDamageLabel
			// 
			this.CriticalDamageLabel.AutoSize = true;
			this.CriticalDamageLabel.DataBindings.Add("Text", BindingSource, "CriticalDamage");
			this.CriticalDamageLabel.Location = new System.Drawing.Point(158, 217);
			this.CriticalDamageLabel.Name = "CriticalDamageLabel";
			this.CriticalDamageLabel.Size = new System.Drawing.Size(0, 15);
			this.CriticalDamageLabel.TabIndex = 0;
			// 
			// MineralsLabel
			// 
			this.MineralsLabel.AutoSize = true;
			this.MineralsLabel.DataBindings.Add("Text", BindingSource, "Minerals");
			this.MineralsLabel.Location = new System.Drawing.Point(158, 248);
			this.MineralsLabel.Name = "MineralsLabel";
			this.MineralsLabel.Size = new System.Drawing.Size(0, 15);
			this.MineralsLabel.TabIndex = 0;
			// 
			// KillsLabel
			// 
			this.KillsLabel.AutoSize = true;
			this.KillsLabel.DataBindings.Add("Text", BindingSource, "Kills");
			this.KillsLabel.Location = new System.Drawing.Point(158, 279);
			this.KillsLabel.Name = "KillsLabel";
			this.KillsLabel.Size = new System.Drawing.Size(0, 15);
			this.KillsLabel.TabIndex = 0;
			// 
			// TypeCaption
			// 
			this.TypeCaption.AutoSize = true;
			this.TypeCaption.Location = new System.Drawing.Point(34, 31);
			this.TypeCaption.Name = "TypeCaption";
			this.TypeCaption.Size = new System.Drawing.Size(57, 15);
			this.TypeCaption.TabIndex = 8;
			this.TypeCaption.Text = "Soul Type";
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.SelectedValueChanged += TypeComboBox_SelectionChanged;
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Location = new System.Drawing.Point(127, 28);
			this.TypeComboBox.DataSource = SoulTypeList;
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(98, 23);
			this.TypeComboBox.TabIndex = 9;
			// 
			// SoulForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TypeCaption);
			this.Controls.Add(this.TypeComboBox);
			this.Controls.Add(this.KillsLabel);
			this.Controls.Add(this.MineralsLabel);
			this.Controls.Add(this.CriticalDamageLabel);
			this.Controls.Add(this.CriticalChanceLabel);
			this.Controls.Add(this.ArmorLabel);
			this.Controls.Add(this.VitalsLabel);
			this.Controls.Add(this.AttackSpeedLabel);
			this.Controls.Add(this.AttackLabel);
			this.Controls.Add(this.AttackCaption);
			this.Controls.Add(this.IncrementAttackButton);
			this.Controls.Add(this.IncrementAttackSpeedButton);
			this.Controls.Add(this.DecrementAttackButton);
			this.Controls.Add(this.DecrementAttackSpeedButton);
			this.Controls.Add(this.AttackSpeedCaption);
			this.Controls.Add(this.IncrementVitalsButton);
			this.Controls.Add(this.KillsCaption);
			this.Controls.Add(this.MineralCaption);
			this.Controls.Add(this.CriticalDamageCaption);
			this.Controls.Add(this.CriticalChanceCaption);
			this.Controls.Add(this.ArmorCaption);
			this.Controls.Add(this.VitalsCaption);
			this.Controls.Add(this.IncrementMineralsButton);
			this.Controls.Add(this.IncrementKillsButton);
			this.Controls.Add(this.IncrementCriticalDamageButton);
			this.Controls.Add(this.IncrementCriticalChanceButton);
			this.Controls.Add(this.IncrementArmorButton);
			this.Controls.Add(this.DecrementKillsButton);
			this.Controls.Add(this.DecrementMineralsButton);
			this.Controls.Add(this.DecrementCriticalDamageButton);
			this.Controls.Add(this.DecrementCriticalChanceButton);
			this.Controls.Add(this.DecrementArmorButton);
			this.Controls.Add(this.DecrementVitalsButton);
			this.Name = "SoulForm";
			((ISupportInitialize)this.BindingSource).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			this.ClientSize = new System.Drawing.Size(258, 357);
		}

		#endregion

		private System.Windows.Forms.Label AttackSpeedCaption;
		private System.Windows.Forms.Label VitalsCaption;
		private System.Windows.Forms.Label ArmorCaption;
		private System.Windows.Forms.Label CriticalChanceCaption;
		private System.Windows.Forms.Label CriticalDamageCaption;
		private System.Windows.Forms.Label MineralCaption;
		private System.Windows.Forms.Label KillsCaption;
		private System.Windows.Forms.Button IncrementVitalsButton;
		private System.Windows.Forms.Button IncrementArmorButton;
		private System.Windows.Forms.Button IncrementCriticalChanceButton;
		private System.Windows.Forms.Button IncrementCriticalDamageButton;
		private System.Windows.Forms.Button IncrementMineralsButton;
		private System.Windows.Forms.Button IncrementKillsButton;
		private System.Windows.Forms.Button DecrementVitalsButton;
		private System.Windows.Forms.Button DecrementArmorButton;
		private System.Windows.Forms.Button DecrementCriticalChanceButton;
		private System.Windows.Forms.Button DecrementCriticalDamageButton;
		private System.Windows.Forms.Button DecrementKillsButton;
		private System.Windows.Forms.Button DecrementMineralsButton;
		private System.Windows.Forms.Button DecrementAttackSpeedButton;
		private System.Windows.Forms.Button DecrementAttackButton;
		private System.Windows.Forms.Button IncrementAttackSpeedButton;
		private System.Windows.Forms.Button IncrementAttackButton;
		private System.Windows.Forms.Label AttackCaption;
		private System.Windows.Forms.Label AttackLabel;
		private System.Windows.Forms.Label AttackSpeedLabel;
		private System.Windows.Forms.Label VitalsLabel;
		private System.Windows.Forms.Label ArmorLabel;
		private System.Windows.Forms.Label CriticalChanceLabel;
		private System.Windows.Forms.Label CriticalDamageLabel;
		private System.Windows.Forms.Label MineralsLabel;
		private System.Windows.Forms.Label KillsLabel;
		private System.Windows.Forms.Label TypeCaption;
		private System.Windows.Forms.ComboBox TypeComboBox;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}