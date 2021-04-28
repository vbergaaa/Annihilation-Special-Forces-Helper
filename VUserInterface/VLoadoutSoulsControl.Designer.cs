using System.Windows.Forms;
using VBusiness.Profile;
using VBusiness.Souls;
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
			this.bindingSource = new BindingSource();
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
			// Soul1Control
			//
			this.Soul1Control.DataBindings.Add("Soul", bindingSource, "Soul1");
			this.Soul1Control.DataBindings.Add("SoulCollection", bindingSource, ".");
			this.Soul1Control.Location = DPIScalingHelper.GetScaledPoint(35, 20);
			this.Soul1Control.OnSoulChanged += Soul1Control_OnSoulChanged;
			//
			// Soul2Control
			//
			this.Soul2Control.DataBindings.Add("Soul", bindingSource, "Soul2");
			this.Soul2Control.DataBindings.Add("SoulCollection", bindingSource, ".");
			this.Soul2Control.Location = DPIScalingHelper.GetScaledPoint(208, 20);
			this.Soul2Control.OnSoulChanged += Soul2Control_OnSoulChanged;
			//
			// Soul3Control
			//
			this.Soul3Control.DataBindings.Add("Soul", bindingSource, "Soul3");
			this.Soul3Control.DataBindings.Add("SoulCollection", bindingSource, ".");
			this.Soul3Control.Enabled = false;
			this.Soul3Control.Location = DPIScalingHelper.GetScaledPoint(381, 20);
			this.Soul3Control.OnSoulChanged += Soul3Control_OnSoulChanged;
			this.Soul3Control.Visible = false;
			//
			// SoulPowerButton
			//
			this.SoulPowerButton.Click += VLoadoutSoulsControl_Click;
			this.SoulPowerButton.Size = DPIScalingHelper.GetScaledSize(150, 30);
			this.SoulPowerButton.Location = DPIScalingHelper.GetScaledPoint(420, 40);
			this.SoulPowerButton.Name = "SoulPowerButton";
			this.SoulPowerButton.Text = "Soul Powers";
			//
			// SoulPower1Label
			//
			this.SoulPower1Label.Caption = "Soul Power 1:";
			this.SoulPower1Label.DataBindings.Add("Text", bindingSource, "SoulPower1");
			this.SoulPower1Label.Location = DPIScalingHelper.GetScaledPoint(470, 100);
			this.SoulPower1Label.Name = "SoulPowerButton";
			this.SoulPower1Label.Visible = Profile.GetProfile().SoulCollection.PowerSoulsCount > 0;
			//
			// SoulPower1Label
			//
			this.SoulPower2Label.Caption = "Soul Power 2:";
			this.SoulPower2Label.DataBindings.Add("Text", bindingSource, "SoulPower2");
			this.SoulPower2Label.Location = DPIScalingHelper.GetScaledPoint(470, 130);
			this.SoulPower2Label.Name = "SoulPowerButton";
			this.SoulPower2Label.Visible = Profile.GetProfile().SoulCollection.PowerSoulsCount > 1;
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(Soul1Control);
			this.Controls.Add(Soul2Control);
			this.Controls.Add(Soul3Control);
			this.Controls.Add(SoulPowerButton);
			this.Controls.Add(SoulPower1Label);
			this.Controls.Add(SoulPower2Label);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
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
	}
}
