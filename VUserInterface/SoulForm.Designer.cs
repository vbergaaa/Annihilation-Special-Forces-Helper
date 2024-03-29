﻿using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Souls;
using VUserInterface.CommonControls;

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
			this.TypeCaption = new VLabel();
			this.TypeDropBox = new VDropBox();
			this.SaveSlotTextBox = new VTextBox();
			this.BindingSource = new VBindingSource();
			this.AttackIncrementor = new VIncrementor();
			this.AttackSpeedIncrementor = new VIncrementor();
			this.VitalsIncrementor = new VIncrementor();
			this.ArmorIncrementor = new VIncrementor();
			this.CritChanceIncrementor = new VIncrementor();
			this.CritDamageIncrementor = new VIncrementor();
			this.MineralsIncrementor = new VIncrementor();
			this.KillsIncrementor = new VIncrementor();
			((ISupportInitialize)this.BindingSource).BeginInit();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(Soul);
			// TypeCaption
			// 
			this.TypeCaption.AutoSize = true;
			this.TypeCaption.Location = DPIScalingHelper.GetScaledPoint(20, 60);
			this.TypeCaption.Name = "TypeCaption";
			this.TypeCaption.Size = DPIScalingHelper.GetScaledSize(57, 15);
			this.TypeCaption.TabIndex = 8;
			this.TypeCaption.Text = "Soul Type";
			// 
			// SaveSlotTextBox
			// 
			this.SaveSlotTextBox.Caption = "Save Slot";
			this.SaveSlotTextBox.Location = DPIScalingHelper.GetScaledPoint(130, 29);
			this.SaveSlotTextBox.DataBindings.Add("Text", BindingSource, "SaveSlot");
			this.SaveSlotTextBox.Name = "SaveSlotComboBox";
			this.SaveSlotTextBox.Size = DPIScalingHelper.GetScaledSize(50, 24);
			this.SaveSlotTextBox.TabIndex = 0;
			// 
			// TypeComboBox
			// 
			this.TypeDropBox.SelectedValueChanged += TypeComboBox_SelectionChanged;
			this.TypeDropBox.Location = DPIScalingHelper.GetScaledPoint(20, 91);
			this.TypeDropBox.BindingContext = new BindingContext();
			this.TypeDropBox.List = SoulTypesList;
			this.TypeDropBox.Name = "TypeComboBox";
			this.TypeDropBox.Size = DPIScalingHelper.GetScaledSize(220, 23);
			this.TypeDropBox.TabIndex = 9;
			//
			// AttackIncrementor
			//
			this.AttackIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 124);
			this.AttackIncrementor.Caption = "Attack:";
			this.AttackIncrementor.DataBindings.Add("Value", BindingSource, "Attack");
			this.AttackIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxAttack");
			this.AttackIncrementor.DataBindings.Add("MinValue", BindingSource, "MinAttack");
			//
			// AttackSpeedIncrementor
			//
			this.AttackSpeedIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 155);
			this.AttackSpeedIncrementor.Caption = "Attack Speed:";
			this.AttackSpeedIncrementor.DataBindings.Add("Value", BindingSource, "AttackSpeed");
			this.AttackSpeedIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxAttackSpeed");
			this.AttackSpeedIncrementor.DataBindings.Add("MinValue", BindingSource, "MinAttackSpeed");
			//
			// VitalsIncrementor
			//
			this.VitalsIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 186);
			this.VitalsIncrementor.Caption = "Vitals:";
			this.VitalsIncrementor.DataBindings.Add("Value", BindingSource, "Vitals");
			this.VitalsIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxVitals");
			this.VitalsIncrementor.DataBindings.Add("MinValue", BindingSource, "MinVitals");
			//
			// ArmorIncrementor
			//
			this.ArmorIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 217);
			this.ArmorIncrementor.Caption = "Armor:";
			this.ArmorIncrementor.DataBindings.Add("Value", BindingSource, "Armor");
			this.ArmorIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxArmor");
			this.ArmorIncrementor.DataBindings.Add("MinValue", BindingSource, "MinArmor");
			//
			// CritChanceIncrementor
			//
			this.CritChanceIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 248);
			this.CritChanceIncrementor.Caption = "Crit Chance:";
			this.CritChanceIncrementor.DataBindings.Add("Value", BindingSource, "CriticalChance");
			this.CritChanceIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxCriticalChance");
			this.CritChanceIncrementor.DataBindings.Add("MinValue", BindingSource, "MinCriticalChance");
			//
			// CritDamageIncrementor
			//
			this.CritDamageIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 279);
			this.CritDamageIncrementor.Caption = "Crit Damage:";
			this.CritDamageIncrementor.DataBindings.Add("Value", BindingSource, "CriticalDamage");
			this.CritDamageIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxCriticalDamage");
			this.CritDamageIncrementor.DataBindings.Add("MinValue", BindingSource, "MinCriticalDamage");
			//
			// MineralsIncrementor
			//
			this.MineralsIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 310);
			this.MineralsIncrementor.Caption = "Minerals:";
			this.MineralsIncrementor.DataBindings.Add("Value", BindingSource, "Minerals");
			this.MineralsIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxMinerals");
			this.MineralsIncrementor.DataBindings.Add("MinValue", BindingSource, "MinMinerals");
			this.MineralsIncrementor.IncrementAmount = 1000;
			//
			// KillsIncrementor
			//
			this.KillsIncrementor.Location = DPIScalingHelper.GetScaledPoint(130, 341);
			this.KillsIncrementor.Caption = "Kills:";
			this.KillsIncrementor.DataBindings.Add("Value", BindingSource, "Kills");
			this.KillsIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxKills");
			this.KillsIncrementor.DataBindings.Add("MinValue", BindingSource, "MinKills");
			this.KillsIncrementor.IncrementAmount = 100;
			// 
			// SoulForm
			// 
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = DPIScalingHelper.GetScaledSize(258, 419);
			this.Controls.Add(this.TypeCaption);
			this.Controls.Add(this.TypeDropBox);
			this.Controls.Add(this.SaveSlotTextBox);
			this.Controls.Add(this.AttackIncrementor);
			this.Controls.Add(this.AttackSpeedIncrementor);
			this.Controls.Add(this.VitalsIncrementor);
			this.Controls.Add(this.ArmorIncrementor);
			this.Controls.Add(this.CritChanceIncrementor);
			this.Controls.Add(this.CritDamageIncrementor);
			this.Controls.Add(this.MineralsIncrementor);
			this.Controls.Add(this.KillsIncrementor);
			this.Name = "SoulForm";
			this.Text = "Create/Edit Soul";
			((ISupportInitialize)this.BindingSource).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private VIncrementor AttackIncrementor;
		private VIncrementor AttackSpeedIncrementor;
		private VIncrementor VitalsIncrementor;
		private VIncrementor ArmorIncrementor;
		private VIncrementor CritChanceIncrementor;
		private VIncrementor CritDamageIncrementor;
		private VIncrementor MineralsIncrementor;
		private VIncrementor KillsIncrementor;
		private VLabel TypeCaption;
		private VDropBox TypeDropBox;
		private VTextBox SaveSlotTextBox;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}