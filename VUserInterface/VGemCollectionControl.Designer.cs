using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class VGemCollectionControl
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
			this.TotalGemsLabel = new VLabel();
			this.RemainingGemsLabel = new VLabel();
			this.AttackGemControl = new GemControl();
			this.AttackSpeedGemControl = new GemControl();
			this.ShieldsGemControl = new GemControl();
			this.ShieldsArmorGemControl = new GemControl();
			this.HealthGemControl = new GemControl();
			this.HealthArmorGemControl = new GemControl();
			this.CriticalChanceGemControl = new GemControl();
			this.CriticalDamageGemControl = new GemControl();
			this.DoubleWarpGemControl = new GemControl();
			this.BindingSource = new VBindingSource();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			//
			// TotalGemsLabel;
			//
			this.TotalGemsLabel.DataBindings.Add("Text", BindingSource, "TotalCost");
			this.TotalGemsLabel.Caption = "Total Gems:";
			this.TotalGemsLabel.Location = DPIScalingHelper.GetScaledPoint(200, 0);
			this.TotalGemsLabel.Name = "TotalGemsLabel";
			this.TotalGemsLabel.Size = DPIScalingHelper.GetScaledSize(100, 30);
			//
			// RemainingGemsLabel;
			//
			this.RemainingGemsLabel.DataBindings.Add("Text", BindingSource, "RemainingGems");
			this.RemainingGemsLabel.Caption = "Remaining Gems:";
			this.RemainingGemsLabel.Location = DPIScalingHelper.GetScaledPoint(450, 0);
			this.RemainingGemsLabel.Name = "RemainingGemsLabel";
			this.RemainingGemsLabel.Size = DPIScalingHelper.GetScaledSize(100, 30);
			//
			// AttackControl
			//
			this.AttackGemControl.Location = DPIScalingHelper.GetScaledPoint(35, 50);
			this.AttackGemControl.DataBindings.Add("Gem", this.BindingSource, "AttackGem");
			this.AttackGemControl.TabIndex = 2;
			//
			// AttackSpeedControl
			//
			this.AttackSpeedGemControl.Location = DPIScalingHelper.GetScaledPoint(208, 50);
			this.AttackSpeedGemControl.DataBindings.Add("Gem", this.BindingSource, "AttackSpeedGem");
			this.AttackSpeedGemControl.TabIndex = 3;
			//
			// ShieldsControl
			//
			this.ShieldsGemControl.Location = DPIScalingHelper.GetScaledPoint(381, 50);
			this.ShieldsGemControl.DataBindings.Add("Gem", this.BindingSource, "ShieldsGem");
			this.ShieldsGemControl.TabIndex = 4;
			//
			// ShieldsArmorControl
			//
			this.ShieldsArmorGemControl.Location = DPIScalingHelper.GetScaledPoint(35, 137);
			this.ShieldsArmorGemControl.DataBindings.Add("Gem", this.BindingSource, "ShieldsArmorGem");
			this.ShieldsArmorGemControl.TabIndex = 5;
			//
			// HealthControl
			//
			this.HealthGemControl.Location = DPIScalingHelper.GetScaledPoint(208, 137);
			this.HealthGemControl.DataBindings.Add("Gem", this.BindingSource, "HealthGem");
			this.HealthGemControl.TabIndex = 6;
			//
			// HealthArmorControl
			//
			this.HealthArmorGemControl.Location = DPIScalingHelper.GetScaledPoint(381, 137);
			this.HealthArmorGemControl.DataBindings.Add("Gem", this.BindingSource, "HealthArmorGem");
			this.HealthArmorGemControl.TabIndex = 7;
			//
			// CriticalChanceControl
			//
			this.CriticalChanceGemControl.Location = DPIScalingHelper.GetScaledPoint(35, 217);
			this.CriticalChanceGemControl.DataBindings.Add("Gem", this.BindingSource, "CritChanceGem");
			this.CriticalChanceGemControl.TabIndex = 8;
			//
			// CriticalDamageControl
			//
			this.CriticalDamageGemControl.Location = DPIScalingHelper.GetScaledPoint(208, 217);
			this.CriticalDamageGemControl.DataBindings.Add("Gem", this.BindingSource, "CritDamageGem");
			this.CriticalDamageGemControl.TabIndex = 9;
			//
			// DoubleWarpControl
			//
			this.DoubleWarpGemControl.Location = DPIScalingHelper.GetScaledPoint(381, 217);
			this.DoubleWarpGemControl.DataBindings.Add("Gem", this.BindingSource, "EconomyGem");
			this.DoubleWarpGemControl.TabIndex = 10;
			// 
			// gemsBindingSource
			// 
			this.BindingSource.DataSource = typeof(VGemCollection);
			//
			// VPerkPageControl
			//
			this.Controls.Add(AttackGemControl);
			this.Controls.Add(AttackSpeedGemControl);
			this.Controls.Add(ShieldsGemControl);
			this.Controls.Add(ShieldsArmorGemControl);
			this.Controls.Add(HealthGemControl);
			this.Controls.Add(HealthArmorGemControl);
			this.Controls.Add(CriticalChanceGemControl);
			this.Controls.Add(CriticalDamageGemControl);
			this.Controls.Add(DoubleWarpGemControl);
			this.Controls.Add(TotalGemsLabel);
			this.Controls.Add(RemainingGemsLabel);
			this.Size = DPIScalingHelper.GetScaledSize(589, 302);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.BindingSource BindingSource;
		private VLabel TotalGemsLabel;
		private VLabel RemainingGemsLabel;
		private GemControl AttackGemControl;
		private GemControl AttackSpeedGemControl;
		private GemControl ShieldsGemControl;
		private GemControl ShieldsArmorGemControl;
		private GemControl HealthGemControl;
		private GemControl HealthArmorGemControl;
		private GemControl CriticalChanceGemControl;
		private GemControl CriticalDamageGemControl;
		private GemControl DoubleWarpGemControl;
	}
}
