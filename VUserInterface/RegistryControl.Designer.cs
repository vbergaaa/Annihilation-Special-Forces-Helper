using System.Windows.Forms;
using VBusiness;
using VEntityFramework.HelperClasses;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class RegistryControl
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
			this.BindingSource = new VBindingSource();
			this.SyncProfileBankCheckControl = new VCheckControl();
			this.SyncLoadoutBankCheckControl = new VCheckControl();
			this.SyncSoulBankCheckControl = new VCheckControl();
			this.TitleLabel = new VLabel();
			this.VersionLabel = new VLabel();
			this.SaveButton = new VButton();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(Registry);
			//
			// ProfileTitleLabel
			//
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Location = DPIScalingHelper.GetScaledPoint(120, 22);
			this.TitleLabel.Text = "Settings";
			this.TitleLabel.Font = new System.Drawing.Font(this.TitleLabel.Font.FontFamily, 14);
			//
			// VersionLabel
			//
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Location = DPIScalingHelper.GetScaledPoint(120, 220);
			this.VersionLabel.Text = "Version Date: " + VersionHelper.GetVersionBuildDate().ToString("dd-MMM-yyyy");
			// 
			// SaveEditButton
			// 
			this.SaveButton.DataBindings.Add("Enabled", BindingSource, "HasChanges");
			this.SaveButton.Location = DPIScalingHelper.GetScaledPoint(275, 22);
			this.SaveButton.Name = "SaveEditButton";
			this.SaveButton.Size = DPIScalingHelper.GetScaledSize(75, 23);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.Text = "Save";
			this.SaveButton.Click += new System.EventHandler(this.SaveEditButton_Click);
			//
			// SyncProfileBankControl
			//
			this.SyncProfileBankCheckControl.Caption = "Sync Profile on app start:";
			this.SyncProfileBankCheckControl.DataBindings.Add("Checked", BindingSource, "SyncProfileWithBank");
			this.SyncProfileBankCheckControl.Location = DPIScalingHelper.GetScaledPoint(200, 70);
			this.SyncProfileBankCheckControl.Name = "SyncBankControl";
			//
			// SyncLoadoutBankControl
			//
			this.SyncLoadoutBankCheckControl.Caption = "Sync all loadouts on app start:";
			this.SyncLoadoutBankCheckControl.DataBindings.Add("Checked", BindingSource, "SyncLoadoutsWithBank");
			this.SyncLoadoutBankCheckControl.Location = DPIScalingHelper.GetScaledPoint(200, 100);
			this.SyncLoadoutBankCheckControl.Name = "SyncBankControl";
			//
			// SyncSoulBankControl
			//
			this.SyncSoulBankCheckControl.Caption = "Sync all souls on app start:";
			this.SyncSoulBankCheckControl.DataBindings.Add("Checked", BindingSource, "SyncSoulsWithBank");
			this.SyncSoulBankCheckControl.Location = DPIScalingHelper.GetScaledPoint(200, 130);
			this.SyncSoulBankCheckControl.Name = "SyncBankControl";
			//
			// RegistryControl
			//
			this.Controls.Add(SyncProfileBankCheckControl);
			this.Controls.Add(SyncLoadoutBankCheckControl);
			this.Controls.Add(SyncSoulBankCheckControl);
			this.Controls.Add(VersionLabel);
			this.Controls.Add(SaveButton);
			this.Controls.Add(TitleLabel);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		}

		#endregion

		BindingSource BindingSource;
		VCheckControl SyncProfileBankCheckControl;
		VCheckControl SyncLoadoutBankCheckControl;
		VCheckControl SyncSoulBankCheckControl;
		VLabel TitleLabel;
		VButton SaveButton;
		VLabel VersionLabel;
	}
}
