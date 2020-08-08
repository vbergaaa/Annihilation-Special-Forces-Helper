using System;
using System.ComponentModel;
using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	partial class SoulControl
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
			this.AttackSpeedCaption = new System.Windows.Forms.Label();
			this.VitalsCaption = new System.Windows.Forms.Label();
			this.ArmorCaption = new System.Windows.Forms.Label();
			this.CriticalChanceCaption = new System.Windows.Forms.Label();
			this.CriticalDamageCaption = new System.Windows.Forms.Label();
			this.MineralCaption = new System.Windows.Forms.Label();
			this.KillsCaption = new System.Windows.Forms.Label();
			this.AttackCaption = new System.Windows.Forms.Label();
			this.AttackLabel = new System.Windows.Forms.Label();
			this.AttackSpeedLabel = new System.Windows.Forms.Label();
			this.VitalsLabel = new System.Windows.Forms.Label();
			this.ArmorLabel = new System.Windows.Forms.Label();
			this.CriticalChanceLabel = new System.Windows.Forms.Label();
			this.CriticalDamageLabel = new System.Windows.Forms.Label();
			this.MineralsLabel = new System.Windows.Forms.Label();
			this.KillsLabel = new System.Windows.Forms.Label();
			this.SoulComboBox = new System.Windows.Forms.ComboBox();
			this.BindingSource = new BindingSource();
			((ISupportInitialize)this.BindingSource).BeginInit();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(VSoul);
			// 
			// AttackSpeedCaption
			// 
			this.AttackSpeedCaption.AutoSize = true;
			this.AttackSpeedCaption.Location = new System.Drawing.Point(20, 80);
			this.AttackSpeedCaption.Name = "AttackSpeedCaption";
			this.AttackSpeedCaption.Size = new System.Drawing.Size(76, 15);
			this.AttackSpeedCaption.TabIndex = 0;
			this.AttackSpeedCaption.Text = "Attack Speed";
			// 
			// VitalsCaption
			// 
			this.VitalsCaption.AutoSize = true;
			this.VitalsCaption.Location = new System.Drawing.Point(20, 100);
			this.VitalsCaption.Name = "VitalsCaption";
			this.VitalsCaption.Size = new System.Drawing.Size(35, 15);
			this.VitalsCaption.TabIndex = 1;
			this.VitalsCaption.Text = "Vitals";
			// 
			// ArmorCaption
			// 
			this.ArmorCaption.AutoSize = true;
			this.ArmorCaption.Location = new System.Drawing.Point(20, 120);
			this.ArmorCaption.Name = "ArmorCaption";
			this.ArmorCaption.Size = new System.Drawing.Size(41, 15);
			this.ArmorCaption.TabIndex = 2;
			this.ArmorCaption.Text = "Armor";
			// 
			// CriticalChanceCaption
			// 
			this.CriticalChanceCaption.AutoSize = true;
			this.CriticalChanceCaption.Location = new System.Drawing.Point(20, 140);
			this.CriticalChanceCaption.Name = "CriticalChanceCaption";
			this.CriticalChanceCaption.Size = new System.Drawing.Size(87, 15);
			this.CriticalChanceCaption.TabIndex = 3;
			this.CriticalChanceCaption.Text = "Critical Chance";
			// 
			// CriticalDamageCaption
			// 
			this.CriticalDamageCaption.AutoSize = true;
			this.CriticalDamageCaption.Location = new System.Drawing.Point(20, 160);
			this.CriticalDamageCaption.Name = "CriticalDamageCaption";
			this.CriticalDamageCaption.Size = new System.Drawing.Size(88, 15);
			this.CriticalDamageCaption.TabIndex = 4;
			this.CriticalDamageCaption.Text = "Critical Damage";
			// 
			// MineralCaption
			// 
			this.MineralCaption.AutoSize = true;
			this.MineralCaption.Location = new System.Drawing.Point(20, 180);
			this.MineralCaption.Name = "MineralCaption";
			this.MineralCaption.Size = new System.Drawing.Size(52, 15);
			this.MineralCaption.TabIndex = 5;
			this.MineralCaption.Text = "Minerals";
			// 
			// KillsCaption
			// 
			this.KillsCaption.AutoSize = true;
			this.KillsCaption.Location = new System.Drawing.Point(20, 200);
			this.KillsCaption.Name = "KillsCaption";
			this.KillsCaption.Size = new System.Drawing.Size(28, 15);
			this.KillsCaption.TabIndex = 6;
			this.KillsCaption.Text = "Kills";
			//
			// AttackCaption
			//
			this.AttackCaption.AutoSize = true;
			this.AttackCaption.Location = new System.Drawing.Point(20, 60);
			this.AttackCaption.Name = "AttackCaption";
			this.AttackCaption.Size = new System.Drawing.Size(41, 15);
			this.AttackCaption.TabIndex = 0;
			this.AttackCaption.Text = "Attack";
			// 
			// AttackLabel
			// 
			this.AttackLabel.AutoSize = true;
			this.AttackLabel.DataBindings.Add("Text", BindingSource, "Attack");
			this.AttackLabel.Location = new System.Drawing.Point(128, 60);
			this.AttackLabel.Name = "AttackLabel";
			this.AttackLabel.Size = new System.Drawing.Size(0, 15);
			this.AttackLabel.TabIndex = 0;
			// 
			// AttackSpeedLabel
			// 
			this.AttackSpeedLabel.AutoSize = true;
			this.AttackSpeedLabel.DataBindings.Add("Text", BindingSource, "AttackSpeed");
			this.AttackSpeedLabel.Location = new System.Drawing.Point(128, 80);
			this.AttackSpeedLabel.Name = "AttackSpeedLabel";
			this.AttackSpeedLabel.Size = new System.Drawing.Size(0, 15);
			this.AttackSpeedLabel.TabIndex = 0;
			// 
			// VitalsLabel
			// 
			this.VitalsLabel.AutoSize = true;
			this.VitalsLabel.DataBindings.Add("Text", BindingSource, "Vitals");
			this.VitalsLabel.Location = new System.Drawing.Point(128, 100);
			this.VitalsLabel.Name = "VitalsLabel";
			this.VitalsLabel.Size = new System.Drawing.Size(0, 15);
			this.VitalsLabel.TabIndex = 0;
			// 
			// ArmorLabel
			// 
			this.ArmorLabel.AutoSize = true;
			this.ArmorLabel.DataBindings.Add("Text", BindingSource, "Armor");
			this.ArmorLabel.Location = new System.Drawing.Point(128, 120);
			this.ArmorLabel.Name = "ArmorLabel";
			this.ArmorLabel.Size = new System.Drawing.Size(0, 15);
			this.ArmorLabel.TabIndex = 0;
			// 
			// CriticalChanceLabel
			// 
			this.CriticalChanceLabel.AutoSize = true;
			this.CriticalChanceLabel.DataBindings.Add("Text", BindingSource, "CriticalChance");
			this.CriticalChanceLabel.Location = new System.Drawing.Point(128, 140);
			this.CriticalChanceLabel.Name = "CriticalChanceLabel";
			this.CriticalChanceLabel.Size = new System.Drawing.Size(0, 15);
			this.CriticalChanceLabel.TabIndex = 0;
			// 
			// CriticalDamageLabel
			// 
			this.CriticalDamageLabel.AutoSize = true;
			this.CriticalDamageLabel.DataBindings.Add("Text", BindingSource, "CriticalDamage");
			this.CriticalDamageLabel.Location = new System.Drawing.Point(128, 160);
			this.CriticalDamageLabel.Name = "CriticalDamageLabel";
			this.CriticalDamageLabel.Size = new System.Drawing.Size(0, 15);
			this.CriticalDamageLabel.TabIndex = 0;
			// 
			// MineralsLabel
			// 
			this.MineralsLabel.AutoSize = true;
			this.MineralsLabel.DataBindings.Add("Text", BindingSource, "Minerals");
			this.MineralsLabel.Location = new System.Drawing.Point(128, 180);
			this.MineralsLabel.Name = "MineralsLabel";
			this.MineralsLabel.Size = new System.Drawing.Size(0, 15);
			this.MineralsLabel.TabIndex = 0;
			// 
			// KillsLabel
			// 
			this.KillsLabel.AutoSize = true;
			this.KillsLabel.DataBindings.Add("Text", BindingSource, "Kills");
			this.KillsLabel.Location = new System.Drawing.Point(128, 200);
			this.KillsLabel.Name = "KillsLabel";
			this.KillsLabel.Size = new System.Drawing.Size(0, 15);
			this.KillsLabel.TabIndex = 0;
			//
			// SoulComboBox
			//
			this.SoulComboBox.Location = new System.Drawing.Point(20, 30);
			this.SoulComboBox.Size = new System.Drawing.Size(130, 25);
			this.SoulComboBox.DataSource = SoulList;
			this.SoulComboBox.SelectedValueChanged += SoulChanged;
			// 
			// SoulControl
			// 
			this.Controls.Add(this.SoulComboBox);
			this.Controls.Add(this.KillsLabel);
			this.Controls.Add(this.MineralsLabel);
			this.Controls.Add(this.CriticalDamageLabel);
			this.Controls.Add(this.CriticalChanceLabel);
			this.Controls.Add(this.ArmorLabel);
			this.Controls.Add(this.VitalsLabel);
			this.Controls.Add(this.AttackSpeedLabel);
			this.Controls.Add(this.AttackLabel);
			this.Controls.Add(this.AttackCaption);
			this.Controls.Add(this.AttackSpeedCaption);
			this.Controls.Add(this.KillsCaption);
			this.Controls.Add(this.MineralCaption);
			this.Controls.Add(this.CriticalDamageCaption);
			this.Controls.Add(this.CriticalChanceCaption);
			this.Controls.Add(this.ArmorCaption);
			this.Controls.Add(this.VitalsCaption);
			this.Name = "SoulForm";
			this.Size = new System.Drawing.Size(163, 230);
			((ISupportInitialize)this.BindingSource).EndInit();
		}

		#endregion

		private System.Windows.Forms.Label AttackSpeedCaption;
		private System.Windows.Forms.Label VitalsCaption;
		private System.Windows.Forms.Label ArmorCaption;
		private System.Windows.Forms.Label CriticalChanceCaption;
		private System.Windows.Forms.Label CriticalDamageCaption;
		private System.Windows.Forms.Label MineralCaption;
		private System.Windows.Forms.Label KillsCaption;
		private System.Windows.Forms.Label AttackCaption;
		private System.Windows.Forms.Label AttackLabel;
		private System.Windows.Forms.Label AttackSpeedLabel;
		private System.Windows.Forms.Label VitalsLabel;
		private System.Windows.Forms.Label ArmorLabel;
		private System.Windows.Forms.Label CriticalChanceLabel;
		private System.Windows.Forms.Label CriticalDamageLabel;
		private System.Windows.Forms.Label MineralsLabel;
		private System.Windows.Forms.Label KillsLabel;
		private System.Windows.Forms.ComboBox SoulComboBox;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}
