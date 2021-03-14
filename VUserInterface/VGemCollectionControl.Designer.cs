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
			this.AttackGemControl = new GemControl();
			this.AttackSpeedGemControl = new GemControl();
			this.ShieldsGemControl = new GemControl();
			this.ShieldsArmorGemControl = new GemControl();
			this.HealthGemControl = new GemControl();
			this.HealthArmorGemControl = new GemControl();
			this.CriticalChanceGemControl = new GemControl();
			this.CriticalDamageGemControl = new GemControl();
			this.DoubleWarpGemControl = new GemControl();
			this.gemsBindingSource = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.gemsBindingSource)).BeginInit();
			//
			// AttackControl
			//
			this.AttackGemControl.Location = DPIScalingHelper.GetScaledPoint(35, 20);
			this.AttackGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "AttackGem");
			this.AttackGemControl.TabIndex = 2;
			//
			// AttackSpeedControl
			//
			this.AttackSpeedGemControl.Location = DPIScalingHelper.GetScaledPoint(208, 20);
			this.AttackSpeedGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "AttackSpeedGem");
			this.AttackSpeedGemControl.TabIndex = 3;
			//
			// ShieldsControl
			//
			this.ShieldsGemControl.Location = DPIScalingHelper.GetScaledPoint(381, 20);
			this.ShieldsGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "ShieldsGem");
			this.ShieldsGemControl.TabIndex = 4;
			//
			// ShieldsArmorControl
			//
			this.ShieldsArmorGemControl.Location = DPIScalingHelper.GetScaledPoint(35, 107);
			this.ShieldsArmorGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "ShieldsArmorGem");
			this.ShieldsArmorGemControl.TabIndex = 5;
			//
			// HealthControl
			//
			this.HealthGemControl.Location = DPIScalingHelper.GetScaledPoint(208, 107);
			this.HealthGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "HealthGem");
			this.HealthGemControl.TabIndex = 6;
			//
			// HealthArmorControl
			//
			this.HealthArmorGemControl.Location = DPIScalingHelper.GetScaledPoint(381, 107);
			this.HealthArmorGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "HealthArmorGem");
			this.HealthArmorGemControl.TabIndex = 7;
			//
			// CriticalChanceControl
			//
			this.CriticalChanceGemControl.Location = DPIScalingHelper.GetScaledPoint(35, 187);
			this.CriticalChanceGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "CritChanceGem");
			this.CriticalChanceGemControl.TabIndex = 8;
			//
			// CriticalDamageControl
			//
			this.CriticalDamageGemControl.Location = DPIScalingHelper.GetScaledPoint(208, 187);
			this.CriticalDamageGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "CritDamageGem");
			this.CriticalDamageGemControl.TabIndex = 9;
			//
			// DoubleWarpControl
			//
			this.DoubleWarpGemControl.Location = DPIScalingHelper.GetScaledPoint(381, 187);
			this.DoubleWarpGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "EconomyGem");
			this.DoubleWarpGemControl.TabIndex = 10;
			// 
			// gemsBindingSource
			// 
			this.gemsBindingSource.DataSource = typeof(VGemCollection);
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
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.gemsBindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.BindingSource gemsBindingSource;
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
