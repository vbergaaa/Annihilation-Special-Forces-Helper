using System.Reflection.Emit;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class VPerkControl
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
			this.CostLabel = new VLabel();
			this.CurrentLevelIncrementor = new VIncrementor();
			this.CostCaption = new VLabel();
			this.perkBindingSource = new System.Windows.Forms.BindingSource();
			this.perkInfo = new ToolTip();
			((System.ComponentModel.ISupportInitialize)(this.perkBindingSource)).BeginInit();
			// 
			// CostCaption
			// 
			this.CostCaption.Location = DPIScalingHelper.GetScaledPoint(10, 69);
			this.CostCaption.Name = "CostCaption";
			this.CostCaption.Size = DPIScalingHelper.GetScaledSize(50, 23);
			this.CostCaption.TabIndex = 6;
			this.CostCaption.Text = "Cost";
			this.CostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CostLabel
			// 
			this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "RemainingCost"));
			this.CostLabel.Location = DPIScalingHelper.GetScaledPoint(70, 69);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = DPIScalingHelper.GetScaledSize(70, 23);
			this.CostLabel.TabIndex = 6;
			this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// CurrentLevelIncrementor
			//
			this.CurrentLevelIncrementor.Location = DPIScalingHelper.GetScaledPoint(27, 30);
			this.CurrentLevelIncrementor.DataBindings.Add("Value", perkBindingSource, "DesiredLevel");
			this.CurrentLevelIncrementor.DataBindings.Add("MaxValue", perkBindingSource, "MaxLevel");
			//
			// perkInfo
			//
			this.perkInfo.SetToolTip(this, "Perk Info");
			this.perkInfo.Popup += PerkInfo_Popup;
			// 
			// perkBindingSource
			// 
			this.perkBindingSource.DataSource = typeof(VPerk);
			// 
			// VPerkControl
			// 
			this.Controls.Add(this.CostLabel);
			this.Controls.Add(this.CurrentLevelIncrementor);
			this.Controls.Add(this.CostCaption);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "Name"));
			this.Size = DPIScalingHelper.GetScaledSize(160, 100);
			((System.ComponentModel.ISupportInitialize)(this.perkBindingSource)).EndInit();
		}

		#endregion

		private ToolTip perkInfo;
		private VLabel CostLabel;
		private VIncrementor CurrentLevelIncrementor;
		private System.Windows.Forms.BindingSource perkBindingSource;
		private VLabel CostCaption;
	}
}
