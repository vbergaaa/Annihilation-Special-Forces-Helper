using System.Windows.Forms;
using VBusiness;
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
			this.AdditionalFarmRoomDropBox = new VDropBox();
			this.BrutaliskOverrideControl = new BrutaliskOverrideControl();
			this.BrutaliskOverrideCheckBox = new VCheckControl();
			this.InfinitySpawnerCheckBox = new VCheckControl();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(IncomeManager);
			//
			// FarmRoomComboBox
			//
			this.FarmRoomDropBox.Caption = "Farming Room:";
			this.FarmRoomDropBox.DataBindings.Add("SelectedValue", BindingSource, "FarmRoom");
			this.FarmRoomDropBox.List = FarmRoomList;
			this.FarmRoomDropBox.Location = DPIScalingHelper.GetScaledPoint(175, 20);
			this.FarmRoomDropBox.Name = "FarmRoomDropBox";
			this.FarmRoomDropBox.Size = DPIScalingHelper.GetScaledSize(180, 30);
			//
			// AdditionalFarmRoomComboBox
			//
			this.AdditionalFarmRoomDropBox.AllowSelectionOfStrings = true;
			this.AdditionalFarmRoomDropBox.Caption = "Additional Farming Room:";
			this.AdditionalFarmRoomDropBox.DataBindings.Add("SelectedValue", BindingSource, "AdditionalFarmRoom");
			this.AdditionalFarmRoomDropBox.DataBindings.Add("List", BindingSource, "AdditionalRoomsLookup");
			this.AdditionalFarmRoomDropBox.DataBindings.Add("Visible", BindingSource, "AdditionalFarmRoom_Visible");
			this.AdditionalFarmRoomDropBox.Location = DPIScalingHelper.GetScaledPoint(175, 50);
			this.AdditionalFarmRoomDropBox.Name = "AdditionalFarmRoomDropBox";
			this.AdditionalFarmRoomDropBox.Size = DPIScalingHelper.GetScaledSize(180, 30);
			//
			// BrutaliskOverrideControl
			//
			this.BrutaliskOverrideControl.Caption = "Brutalisks";
			this.BrutaliskOverrideControl.DataBindings.Add("BrutaliskOverride", BindingSource, "BrutaliskOverride");
			this.BrutaliskOverrideControl.Enabled = false;
			this.BrutaliskOverrideControl.Location = DPIScalingHelper.GetScaledPoint(175, 80);
			this.BrutaliskOverrideControl.Name = "BrutaliskOverrideControl";
			//
			// BrutaliskOverrideCheckBox
			//
			this.BrutaliskOverrideCheckBox.DataBindings.Add("Checked", BindingSource, "BrutaliskOverride.ShouldOverrideBrutalisks");
			this.BrutaliskOverrideCheckBox.Location = DPIScalingHelper.GetScaledPoint(175, 110);
			this.BrutaliskOverrideCheckBox.Caption = "Override Brutalisks";
			this.BrutaliskOverrideCheckBox.Name = "BrutaliskOverrideCheckBox";
			this.BrutaliskOverrideCheckBox.CheckedChanged += BrutaliskOverrideCheckBox_CheckedChanged;
			//
			// InfinitySpawnerCheckBox
			//
			this.InfinitySpawnerCheckBox.DataBindings.Add("Checked", BindingSource, "HasInfinitySpawner");
			this.InfinitySpawnerCheckBox.Location = DPIScalingHelper.GetScaledPoint(175, 140);
			this.InfinitySpawnerCheckBox.Caption = "Infinity Spawner";
			this.InfinitySpawnerCheckBox.Name = "InfinitySpawnerCheckBox";
			//
			// VLoadoutConfigurationControl
			//
			this.Controls.Add(FarmRoomDropBox);
			this.Controls.Add(BrutaliskOverrideControl);
			this.Controls.Add(BrutaliskOverrideCheckBox);
			this.Controls.Add(InfinitySpawnerCheckBox);
			this.Controls.Add(AdditionalFarmRoomDropBox);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
		}

		#endregion

		BindingSource BindingSource;
		VDropBox FarmRoomDropBox;
		VDropBox AdditionalFarmRoomDropBox;
		BrutaliskOverrideControl BrutaliskOverrideControl;
		VCheckControl BrutaliskOverrideCheckBox;
		VCheckControl InfinitySpawnerCheckBox;
	}
}
