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
			this.TotalCostCaption = new VLabel();
			this.TotalCostLabel = new VLabel();
			((System.ComponentModel.ISupportInitialize)(this.gemsBindingSource)).BeginInit();
			//
			// AttackControl
			//
			this.AttackGemControl.Location = new System.Drawing.Point(35, 40);
			this.AttackGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "AttackGem");
			this.AttackGemControl.TabIndex = 2;
			//
			// AttackSpeedControl
			//
			this.AttackSpeedGemControl.Location = new System.Drawing.Point(208, 40);
			this.AttackSpeedGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "AttackSpeedGem");
			this.AttackSpeedGemControl.TabIndex = 3;
			//
			// ShieldsControl
			//
			this.ShieldsGemControl.Location = new System.Drawing.Point(381, 40);
			this.ShieldsGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "ShieldsGem");
			this.ShieldsGemControl.TabIndex = 4;
			//
			// ShieldsArmorControl
			//
			this.ShieldsArmorGemControl.Location = new System.Drawing.Point(35, 127);
			this.ShieldsArmorGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "ShieldsArmorGem");
			this.ShieldsArmorGemControl.TabIndex = 5;
			//
			// HealthControl
			//
			this.HealthGemControl.Location = new System.Drawing.Point(208, 127);
			this.HealthGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "HealthGem");
			this.HealthGemControl.TabIndex = 6;
			//
			// HealthArmorControl
			//
			this.HealthArmorGemControl.Location = new System.Drawing.Point(381, 127);
			this.HealthArmorGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "HealthArmorGem");
			this.HealthArmorGemControl.TabIndex = 7;
			//
			// CriticalChanceControl
			//
			this.CriticalChanceGemControl.Location = new System.Drawing.Point(35, 207);
			this.CriticalChanceGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "CritChanceGem");
			this.CriticalChanceGemControl.TabIndex = 8;
			//
			// CriticalDamageControl
			//
			this.CriticalDamageGemControl.Location = new System.Drawing.Point(208, 207);
			this.CriticalDamageGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "CritDamageGem");
			this.CriticalDamageGemControl.TabIndex = 9;
			//
			// DoubleWarpControl
			//
			this.DoubleWarpGemControl.Location = new System.Drawing.Point(381, 207);
			this.DoubleWarpGemControl.DataBindings.Add("Gem", this.gemsBindingSource, "DoubleWarpGem");
			this.DoubleWarpGemControl.TabIndex = 10;
			// 
			// gemsBindingSource
			// 
			this.gemsBindingSource.DataSource = typeof(VGemCollection);
			//
			// totalDesiredCostLabel
			//
			this.TotalCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gemsBindingSource, "TotalCost"));
			this.TotalCostLabel.Location = new System.Drawing.Point(501, 20);
			this.TotalCostLabel.Size = new System.Drawing.Size(50, 20);
			this.TotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// totalDesiredCostCaption
			//
			this.TotalCostCaption.Location = new System.Drawing.Point(400, 20);
			this.TotalCostCaption.Size = new System.Drawing.Size(100, 20);
			this.TotalCostCaption.Text = "Total Cost:";
			this.TotalCostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.Controls.Add(TotalCostLabel);
			this.Controls.Add(TotalCostCaption);
			this.Size = new System.Drawing.Size(589, 292);
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
		private System.Windows.Forms.Label TotalCostLabel;
		private System.Windows.Forms.Label TotalCostCaption;
	}
}
