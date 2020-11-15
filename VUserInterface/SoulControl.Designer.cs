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
			// AttackLabel
			// 
			this.AttackLabel.AutoSize = true;
			this.AttackLabel.Caption = "Attack";
			this.AttackLabel.DataBindings.Add("Text", BindingSource, "Attack");
			this.AttackLabel.Location = new System.Drawing.Point(120, 60);
			this.AttackLabel.Name = "AttackLabel";
			this.AttackLabel.TabIndex = 0;
			// 
			// AttackSpeedLabel
			// 
			this.AttackSpeedLabel.AutoSize = true;
			this.AttackSpeedLabel.Caption = "Attack Speed";
			this.AttackSpeedLabel.DataBindings.Add("Text", BindingSource, "AttackSpeed");
			this.AttackSpeedLabel.Location = new System.Drawing.Point(120, 80);
			this.AttackSpeedLabel.Name = "AttackSpeedLabel";
			this.AttackSpeedLabel.TabIndex = 0;
			// 
			// VitalsLabel
			// 
			this.VitalsLabel.AutoSize = true;
			this.VitalsLabel.Caption = "Vitals";
			this.VitalsLabel.DataBindings.Add("Text", BindingSource, "Vitals");
			this.VitalsLabel.Location = new System.Drawing.Point(120, 100);
			this.VitalsLabel.Name = "VitalsLabel";
			this.VitalsLabel.TabIndex = 0;
			// 
			// ArmorLabel
			// 
			this.ArmorLabel.AutoSize = true;
			this.ArmorLabel.Caption = "Armor";
			this.ArmorLabel.DataBindings.Add("Text", BindingSource, "Armor");
			this.ArmorLabel.Location = new System.Drawing.Point(120, 120);
			this.ArmorLabel.Name = "ArmorLabel";
			this.ArmorLabel.TabIndex = 0;
			// 
			// CriticalChanceLabel
			// 
			this.CriticalChanceLabel.AutoSize = true;
			this.CriticalChanceLabel.Caption = "Crit Chance";
			this.CriticalChanceLabel.DataBindings.Add("Text", BindingSource, "CriticalChance");
			this.CriticalChanceLabel.Location = new System.Drawing.Point(120, 140);
			this.CriticalChanceLabel.Name = "CriticalChanceLabel";
			this.CriticalChanceLabel.TabIndex = 0;
			// 
			// CriticalDamageLabel
			// 
			this.CriticalDamageLabel.AutoSize = true;
			this.CriticalDamageLabel.Caption = "Crit Damage";
			this.CriticalDamageLabel.DataBindings.Add("Text", BindingSource, "CriticalDamage");
			this.CriticalDamageLabel.Location = new System.Drawing.Point(120, 160);
			this.CriticalDamageLabel.Name = "CriticalDamageLabel";
			this.CriticalDamageLabel.TabIndex = 0;
			// 
			// MineralsLabel
			// 
			this.MineralsLabel.AutoSize = true;
			this.MineralsLabel.Caption = "Minerals";
			this.MineralsLabel.DataBindings.Add("Text", BindingSource, "Minerals");
			this.MineralsLabel.Location = new System.Drawing.Point(120, 180);
			this.MineralsLabel.Name = "MineralsLabel";
			this.MineralsLabel.TabIndex = 0;
			// 
			// KillsLabel
			// 
			this.KillsLabel.AutoSize = true;
			this.KillsLabel.Caption = "Kills";
			this.KillsLabel.DataBindings.Add("Text", BindingSource, "Kills");
			this.KillsLabel.Location = new System.Drawing.Point(120, 200);
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
			this.Name = "SoulForm";
			this.Size = new System.Drawing.Size(163, 230);
			((ISupportInitialize)this.BindingSource).EndInit();
		}

		#endregion

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
