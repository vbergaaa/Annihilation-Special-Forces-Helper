using System.Collections.Generic;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class LoadoutIncomeControl
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
			this.FarmRoomDropBox = new VDropBox();
			this.BrutaliskOverrideControl = new BrutaliskOverrideControl();
			this.BrutaliskOverrideCheckBox = new VCheckControl();
			this.InfinitySpawnerCheckBox = new VCheckControl();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(Loadout);
			//
			// FarmRoomComboBox
			//
			this.FarmRoomDropBox.DataBindings.Add("SelectedValue", BindingSource, "IncomeManager.FarmRoom");
			this.FarmRoomDropBox.List = FarmRoomList;
			this.FarmRoomDropBox.Location = DPIScalingHelper.GetScaledPoint(125, 20);
			this.FarmRoomDropBox.Caption = "Farming Room:";
			//
			// BrutaliskOverrideControl
			//
			this.BrutaliskOverrideControl.Caption = "Brutalisks";
			this.BrutaliskOverrideControl.DataBindings.Add("BrutaliskOverride", BindingSource, "IncomeManager.BrutaliskOverride");
			this.BrutaliskOverrideControl.Enabled = false;
			this.BrutaliskOverrideControl.Location = DPIScalingHelper.GetScaledPoint(125, 50);
			this.BrutaliskOverrideControl.Name = "BrutaliskOverrideControl";
			//
			// BrutaliskOverrideCheckBox
			//
			this.BrutaliskOverrideCheckBox.DataBindings.Add("Checked", BindingSource, "IncomeManager.BrutaliskOverride.ShouldOverrideBrutalisks");
			this.BrutaliskOverrideCheckBox.Location = DPIScalingHelper.GetScaledPoint(125, 80);
			this.BrutaliskOverrideCheckBox.Caption = "Override Brutalisks";
			this.BrutaliskOverrideCheckBox.Name = "BrutaliskOverrideCheckBox";
			this.BrutaliskOverrideCheckBox.CheckedChanged += BrutaliskOverrideCheckBox_CheckedChanged;
			//
			// InfinitySpawnerCheckBox
			//
			this.InfinitySpawnerCheckBox.DataBindings.Add("Checked", BindingSource, "IncomeManager.HasInfinitySpawner");
			this.InfinitySpawnerCheckBox.Location = DPIScalingHelper.GetScaledPoint(125, 110);
			this.InfinitySpawnerCheckBox.Caption = "Infinity Spawner";
			this.InfinitySpawnerCheckBox.Name = "InfinitySpawnerCheckBox";
			//
			// VLoadoutConfigurationControl
			//
			this.Controls.Add(FarmRoomDropBox);
			this.Controls.Add(BrutaliskOverrideControl);
			this.Controls.Add(BrutaliskOverrideCheckBox);
			this.Controls.Add(InfinitySpawnerCheckBox);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
		}

		#endregion

		BindingSource BindingSource;
		VDropBox FarmRoomDropBox;
		BrutaliskOverrideControl BrutaliskOverrideControl;
		VCheckControl BrutaliskOverrideCheckBox;
		VCheckControl InfinitySpawnerCheckBox;
	}
}
