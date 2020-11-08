using System;
using System.ComponentModel;
using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

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
			this.AttackSpeedCaption = new VLabel();
			this.VitalsCaption = new VLabel();
			this.ArmorCaption = new VLabel();
			this.CriticalChanceCaption = new VLabel();
			this.CriticalDamageCaption = new VLabel();
			this.MineralCaption = new VLabel();
			this.KillsCaption = new VLabel();
			this.AttackCaption = new VLabel();
			this.AttackLabel = new VLabel();
			this.AttackSpeedLabel = new VLabel();
			this.VitalsLabel = new VLabel();
			this.ArmorLabel = new VLabel();
			this.CriticalChanceLabel = new VLabel();
			this.CriticalDamageLabel = new VLabel();
			this.MineralsLabel = new VLabel();
			this.KillsLabel = new VLabel();
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
			this.AttackSpeedCaption.Location = new System.Drawing.Point(15, 80);
			this.AttackSpeedCaption.Name = "AttackSpeedCaption";
			this.AttackSpeedCaption.TabIndex = 0;
			this.AttackSpeedCaption.Text = "Attack Speed";
			// 
			// VitalsCaption
			// 
			this.VitalsCaption.AutoSize = true;
			this.VitalsCaption.Location = new System.Drawing.Point(15, 100);
			this.VitalsCaption.Name = "VitalsCaption";
			this.VitalsCaption.TabIndex = 1;
			this.VitalsCaption.Text = "Vitals";
			// 
			// ArmorCaption
			// 
			this.ArmorCaption.AutoSize = true;
			this.ArmorCaption.Location = new System.Drawing.Point(15, 120);
			this.ArmorCaption.Name = "ArmorCaption";
			this.ArmorCaption.TabIndex = 2;
			this.ArmorCaption.Text = "Armor";
			// 
			// CriticalChanceCaption
			// 
			this.CriticalChanceCaption.AutoSize = true;
			this.CriticalChanceCaption.Location = new System.Drawing.Point(15, 140);
			this.CriticalChanceCaption.Name = "CriticalChanceCaption";
			this.CriticalChanceCaption.TabIndex = 3;
			this.CriticalChanceCaption.Text = "Crit Chance";
			// 
			// CriticalDamageCaption
			// 
			this.CriticalDamageCaption.AutoSize = true;
			this.CriticalDamageCaption.Location = new System.Drawing.Point(15, 160);
			this.CriticalDamageCaption.Name = "CriticalDamageCaption";
			this.CriticalDamageCaption.TabIndex = 4;
			this.CriticalDamageCaption.Text = "Crit Damage";
			// 
			// MineralCaption
			// 
			this.MineralCaption.AutoSize = true;
			this.MineralCaption.Location = new System.Drawing.Point(15, 180);
			this.MineralCaption.Name = "MineralCaption";
			this.MineralCaption.TabIndex = 5;
			this.MineralCaption.Text = "Minerals";
			// 
			// KillsCaption
			// 
			this.KillsCaption.AutoSize = true;
			this.KillsCaption.Location = new System.Drawing.Point(15, 200);
			this.KillsCaption.Name = "KillsCaption";
			this.KillsCaption.TabIndex = 6;
			this.KillsCaption.Text = "Kills";
			//
			// AttackCaption
			//
			this.AttackCaption.AutoSize = true;
			this.AttackCaption.Location = new System.Drawing.Point(15, 60);
			this.AttackCaption.Name = "AttackCaption";
			this.AttackCaption.TabIndex = 0;
			this.AttackCaption.Text = "Attack";
			// 
			// AttackLabel
			// 
			this.AttackLabel.AutoSize = true;
			this.AttackLabel.DataBindings.Add("Text", BindingSource, "Attack");
			this.AttackLabel.Location = new System.Drawing.Point(128, 60);
			this.AttackLabel.Name = "AttackLabel";
			this.AttackLabel.TabIndex = 0;
			// 
			// AttackSpeedLabel
			// 
			this.AttackSpeedLabel.AutoSize = true;
			this.AttackSpeedLabel.DataBindings.Add("Text", BindingSource, "AttackSpeed");
			this.AttackSpeedLabel.Location = new System.Drawing.Point(128, 80);
			this.AttackSpeedLabel.Name = "AttackSpeedLabel";
			this.AttackSpeedLabel.TabIndex = 0;
			// 
			// VitalsLabel
			// 
			this.VitalsLabel.AutoSize = true;
			this.VitalsLabel.DataBindings.Add("Text", BindingSource, "Vitals");
			this.VitalsLabel.Location = new System.Drawing.Point(128, 100);
			this.VitalsLabel.Name = "VitalsLabel";
			this.VitalsLabel.TabIndex = 0;
			// 
			// ArmorLabel
			// 
			this.ArmorLabel.AutoSize = true;
			this.ArmorLabel.DataBindings.Add("Text", BindingSource, "Armor");
			this.ArmorLabel.Location = new System.Drawing.Point(128, 120);
			this.ArmorLabel.Name = "ArmorLabel";
			this.ArmorLabel.TabIndex = 0;
			// 
			// CriticalChanceLabel
			// 
			this.CriticalChanceLabel.AutoSize = true;
			this.CriticalChanceLabel.DataBindings.Add("Text", BindingSource, "CriticalChance");
			this.CriticalChanceLabel.Location = new System.Drawing.Point(128, 140);
			this.CriticalChanceLabel.Name = "CriticalChanceLabel";
			this.CriticalChanceLabel.TabIndex = 0;
			// 
			// CriticalDamageLabel
			// 
			this.CriticalDamageLabel.AutoSize = true;
			this.CriticalDamageLabel.DataBindings.Add("Text", BindingSource, "CriticalDamage");
			this.CriticalDamageLabel.Location = new System.Drawing.Point(128, 160);
			this.CriticalDamageLabel.Name = "CriticalDamageLabel";
			this.CriticalDamageLabel.TabIndex = 0;
			// 
			// MineralsLabel
			// 
			this.MineralsLabel.AutoSize = true;
			this.MineralsLabel.DataBindings.Add("Text", BindingSource, "Minerals");
			this.MineralsLabel.Location = new System.Drawing.Point(128, 180);
			this.MineralsLabel.Name = "MineralsLabel";
			this.MineralsLabel.TabIndex = 0;
			// 
			// KillsLabel
			// 
			this.KillsLabel.AutoSize = true;
			this.KillsLabel.DataBindings.Add("Text", BindingSource, "Kills");
			this.KillsLabel.Location = new System.Drawing.Point(128, 200);
			this.KillsLabel.Name = "KillsLabel";
			this.KillsLabel.TabIndex = 0;
			//
			// SoulComboBox
			//
			this.SoulComboBox.Location = new System.Drawing.Point(15, 30);
			this.SoulComboBox.Size = new System.Drawing.Size(135, 25);
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

		private VLabel AttackSpeedCaption;
		private VLabel VitalsCaption;
		private VLabel ArmorCaption;
		private VLabel CriticalChanceCaption;
		private VLabel CriticalDamageCaption;
		private VLabel MineralCaption;
		private VLabel KillsCaption;
		private VLabel AttackCaption;
		private VLabel AttackLabel;
		private VLabel AttackSpeedLabel;
		private VLabel VitalsLabel;
		private VLabel ArmorLabel;
		private VLabel CriticalChanceLabel;
		private VLabel CriticalDamageLabel;
		private VLabel MineralsLabel;
		private VLabel KillsLabel;
		private System.Windows.Forms.ComboBox SoulComboBox;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}
