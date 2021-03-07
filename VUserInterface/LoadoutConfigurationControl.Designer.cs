using System.Windows.Forms;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class LoadoutConfigurationControl
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
			this.BindingSource = new BindingSource();
			this.UpgradeControl = new UpgradeControl();
			this.UpgradesLabel = new VLabel();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.BindingSource.DataSource = typeof(Loadout);
			//
			// UpgradeControl
			//
			this.UpgradeControl.DataBindings.Add("Upgrades", BindingSource, "Upgrades");
			this.UpgradeControl.Location = DPIScalingHelper.GetScaledPoint(30, 60);
			this.UpgradeControl.Name = "UpgradeControl";
			//
			// UpgradesLabel
			//
			this.UpgradesLabel.Location = DPIScalingHelper.GetScaledPoint(30, 30);
			this.UpgradesLabel.Name = "UpgradesLabel";
			this.UpgradesLabel.Text = "Upgrades";
			//
			// VLoadoutConfigurationControl
			//
			this.Controls.Add(UpgradeControl);
			this.Controls.Add(UpgradesLabel);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
		}

		#endregion

		VLabel UpgradesLabel;
		BindingSource BindingSource;
		UpgradeControl UpgradeControl;
	}
}
