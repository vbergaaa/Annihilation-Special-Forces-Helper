
using VBusiness;
using VEntityFramework.Model;

namespace VUserInterface
{
	partial class UpgradeControl
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
			this.AttackIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.AttackSpeedIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.ShieldsIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.ShieldsArmorIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.HealthIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.HealthArmorIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.BindingSource = new System.Windows.Forms.BindingSource();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(VUpgradeManager);
			// 
			// AttackIncrementor
			// 
			this.AttackIncrementor.Caption = "Attack";
			this.AttackIncrementor.DataBindings.Add("Value", BindingSource, "AttackUpgrade");
			this.AttackIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxAttack");
			this.AttackIncrementor.Location = DPIScalingHelper.GetScaledPoint(125, 0);
			this.AttackIncrementor.Name = "AttackIncrementor";
			this.AttackIncrementor.Size = DPIScalingHelper.GetScaledSize(155, 28);
			this.AttackIncrementor.TabIndex = 0;
			// 
			// AttackSpeedIncrementor
			// 
			this.AttackSpeedIncrementor.Caption = "Attack Speed";
			this.AttackSpeedIncrementor.DataBindings.Add("Value", BindingSource, "AttackSpeedUpgrade");
			this.AttackSpeedIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxAttackSpeed");
			this.AttackSpeedIncrementor.Location = DPIScalingHelper.GetScaledPoint(125, 30);
			this.AttackSpeedIncrementor.Name = "AttackSpeedIncrementor";
			this.AttackSpeedIncrementor.Size = DPIScalingHelper.GetScaledSize(190, 28);
			this.AttackSpeedIncrementor.TabIndex = 1;
			// 
			// ShieldsIncrementor
			// 
			this.ShieldsIncrementor.Caption = "Shields";
			this.ShieldsIncrementor.DataBindings.Add("Value", BindingSource, "ShieldsUpgrade");
			this.ShieldsIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxShields");
			this.ShieldsIncrementor.Location = DPIScalingHelper.GetScaledPoint(125, 60);
			this.ShieldsIncrementor.Name = "ShieldsIncrementor";
			this.ShieldsIncrementor.Size = DPIScalingHelper.GetScaledSize(158, 28);
			this.ShieldsIncrementor.TabIndex = 2;
			// 
			// ShieldsArmorIncrement
			// 
			this.ShieldsArmorIncrementor.Caption = "Shields Armor";
			this.ShieldsArmorIncrementor.DataBindings.Add("Value", BindingSource, "ShieldsArmorUpgrade");
			this.ShieldsArmorIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxShieldsArmor");
			this.ShieldsArmorIncrementor.Location = DPIScalingHelper.GetScaledPoint(125, 90);
			this.ShieldsArmorIncrementor.Name = "ShieldsArmorIncrementor";
			this.ShieldsArmorIncrementor.Size = DPIScalingHelper.GetScaledSize(195, 28);
			this.ShieldsArmorIncrementor.TabIndex = 3;
			// 
			// HealthIncrementor
			// 
			this.HealthIncrementor.Caption = "Health";
			this.HealthIncrementor.DataBindings.Add("Value", BindingSource, "HealthUpgrade");
			this.HealthIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxHealth");
			this.HealthIncrementor.Location = DPIScalingHelper.GetScaledPoint(125, 120);
			this.HealthIncrementor.Name = "HealthIncrementor";
			this.HealthIncrementor.Size = DPIScalingHelper.GetScaledSize(156, 28);
			this.HealthIncrementor.TabIndex = 4;
			// 
			// HealthArmorIncrementor
			// 
			this.HealthArmorIncrementor.Caption = "Health Armor";
			this.HealthArmorIncrementor.DataBindings.Add("Value", BindingSource, "HealthArmorUpgrade");
			this.HealthArmorIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaxHealthArmor");
			this.HealthArmorIncrementor.Location = DPIScalingHelper.GetScaledPoint(125, 150);
			this.HealthArmorIncrementor.Name = "HealthArmorIncrementor";
			this.HealthArmorIncrementor.Size = DPIScalingHelper.GetScaledSize(193, 28);
			this.HealthArmorIncrementor.TabIndex = 5;
			// 
			// UpgradeControl
			// 
			this.Controls.Add(this.HealthArmorIncrementor);
			this.Controls.Add(this.HealthIncrementor);
			this.Controls.Add(this.ShieldsArmorIncrementor);
			this.Controls.Add(this.ShieldsIncrementor);
			this.Controls.Add(this.AttackSpeedIncrementor);
			this.Controls.Add(this.AttackIncrementor);
			this.Name = "UpgradeControl";
			this.Size = DPIScalingHelper.GetScaledSize(250, 233);
			this.ResumeLayout(false);

		}

		#endregion

		private CommonControls.VIncrementor AttackIncrementor;
		private CommonControls.VIncrementor AttackSpeedIncrementor;
		private CommonControls.VIncrementor ShieldsIncrementor;
		private CommonControls.VIncrementor ShieldsArmorIncrementor;
		private CommonControls.VIncrementor HealthIncrementor;
		private CommonControls.VIncrementor HealthArmorIncrementor;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}
