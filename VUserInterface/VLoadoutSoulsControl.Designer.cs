using System.Windows.Forms;
using VBusiness.Profile;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class VLoadoutSoulsControl
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
			this.bindingSource = new VBindingSource();
			this.SoulsCostLabel = new VLabel();
			this.TotalCostLabel = new VLabel();
			this.RemainingCostLabel = new VLabel();
			this.Soul1Control = new SoulControl();
			this.Soul2Control = new SoulControl();
			this.Soul3Control = new SoulControl();
			this.SoulPowerButton = new DPIButton();
			this.SoulPower1Label = new VLabel();
			this.SoulPower2Label = new VLabel();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(VLoadoutSouls);
			//
			// PageCostLabel;
			//
			this.SoulsCostLabel.DataBindings.Add("Text", bindingSource, "SoulCosts");
			this.SoulsCostLabel.Caption = "Cost of Souls:";
			this.SoulsCostLabel.Location = DPIScalingHelper.GetScaledPoint(100, 0);
			this.SoulsCostLabel.Name = "PageCostLabel";
			this.SoulsCostLabel.Size = DPIScalingHelper.GetScaledSize(100, 30);
			//
			// TotalCostLabel;
			//
			this.TotalCostLabel.DataBindings.Add("Text", bindingSource, "Loadout.PerkPointsCost");
			this.TotalCostLabel.Caption = "Total Loadout Cost:";
			this.TotalCostLabel.Location = DPIScalingHelper.GetScaledPoint(300, 0);
			this.TotalCostLabel.Name = "TotalCostLabel";
			this.TotalCostLabel.Size = DPIScalingHelper.GetScaledSize(100, 30);
			//
			// RemainingCostLabel;
			//
			this.RemainingCostLabel.DataBindings.Add("Text", bindingSource, "Loadout.RemainingPerkPoints");
			this.RemainingCostLabel.Caption = "Available PP:";
			this.RemainingCostLabel.Location = DPIScalingHelper.GetScaledPoint(500, 0);
			this.RemainingCostLabel.Name = "RemainingCostLabel";
			this.RemainingCostLabel.Size = DPIScalingHelper.GetScaledSize(100, 30);
			//
			// Soul1Control
			//
			this.Soul1Control.DataBindings.Add("Soul", bindingSource, "Soul1");
			this.Soul1Control.DataBindings.Add("SoulCollection", bindingSource, ".");
			this.Soul1Control.Location = DPIScalingHelper.GetScaledPoint(85, 30);
			this.Soul1Control.OnSoulChanged += Soul1Control_OnSoulChanged;
			//
			// Soul2Control
			//
			this.Soul2Control.DataBindings.Add("Soul", bindingSource, "Soul2");
			this.Soul2Control.DataBindings.Add("SoulCollection", bindingSource, ".");
			this.Soul2Control.Enabled = Profile.GetProfile().Rank >= PlayerRank.SuperCrusader;
			this.Soul2Control.Location = DPIScalingHelper.GetScaledPoint(85, 90);
			this.Soul2Control.OnSoulChanged += Soul2Control_OnSoulChanged;
			//
			// Soul3Control
			//
			this.Soul3Control.DataBindings.Add("Soul", bindingSource, "Soul3");
			this.Soul3Control.DataBindings.Add("SoulCollection", bindingSource, ".");
			this.Soul3Control.Enabled = false;
			this.Soul3Control.Location = DPIScalingHelper.GetScaledPoint(85, 150);
			this.Soul3Control.OnSoulChanged += Soul3Control_OnSoulChanged;
			//
			// SoulPowerButton
			//
			this.SoulPowerButton.Click += VLoadoutSoulsControl_Click;
			this.SoulPowerButton.Size = DPIScalingHelper.GetScaledSize(150, 30);
			this.SoulPowerButton.Location = DPIScalingHelper.GetScaledPoint(85, 220);
			this.SoulPowerButton.Name = "SoulPowerButton";
			this.SoulPowerButton.Text = "Soul Powers";
			//
			// SoulPower1Label
			//
			this.SoulPower1Label.Caption = "Soul Power 1:";
			this.SoulPower1Label.DataBindings.Add("Text", bindingSource, "SoulPower1");
			this.SoulPower1Label.Location = DPIScalingHelper.GetScaledPoint(170, 260);
			this.SoulPower1Label.Name = "SoulPowerButton";
			this.SoulPower1Label.Visible = Profile.GetProfile().SoulCollection.PowerSoulsCount > 0;
			//
			// SoulPower2Label
			//
			this.SoulPower2Label.Caption = "Soul Power 2:";
			this.SoulPower2Label.DataBindings.Add("Text", bindingSource, "SoulPower2");
			this.SoulPower2Label.Location = DPIScalingHelper.GetScaledPoint(170, 290);
			this.SoulPower2Label.Name = "SoulPowerButton";
			this.SoulPower2Label.Visible = Profile.GetProfile().SoulCollection.PowerSoulsCount > 1;
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(TotalCostLabel);
			this.Controls.Add(SoulsCostLabel);
			this.Controls.Add(RemainingCostLabel);
			this.Controls.Add(Soul1Control);
			this.Controls.Add(Soul2Control);
			this.Controls.Add(Soul3Control);
			this.Controls.Add(SoulPowerButton);
			this.Controls.Add(SoulPower1Label);
			this.Controls.Add(SoulPower2Label);
			this.Size = DPIScalingHelper.GetScaledSize(589, 330);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		SoulControl Soul1Control;
		SoulControl Soul2Control;
		SoulControl Soul3Control;
		DPIButton SoulPowerButton;
		VLabel SoulPower1Label;
		VLabel SoulPower2Label;
		VLabel SoulsCostLabel;
		VLabel TotalCostLabel;
		VLabel RemainingCostLabel;
	}
}
