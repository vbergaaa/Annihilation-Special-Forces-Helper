
using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class LoadoutDetailsControl
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
			this.LoadoutNameTextBox = new VTextBox();
			this.SlotNumberTextBox = new VTextBox();
			this.RemoveProfileRestrictionsCheckBox = new VCheckControl();
			this.DifficultyDropBox = new VDropBox();
			this.SoloBonusCheckBox = new VCheckControl();
			this.UnitSpecDropBox = new VDropBox();
			this.TotalPerkPointsLabel = new VLabel();
			this.TotalGemsLabel = new VLabel();
			this.TotalCPLabel = new VLabel();
			((ISupportInitialize)this.BindingSource).BeginInit();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(Loadout);
			//
			// LoadoutNameTextBox
			//
			this.LoadoutNameTextBox.DataBindings.Add("Text", this.BindingSource, "Name", true);
			this.LoadoutNameTextBox.Location = DPIScalingHelper.GetScaledPoint(100, 20);
			this.LoadoutNameTextBox.Name = "LoadoutNameTextBox";
			this.LoadoutNameTextBox.Caption = "Name";
			this.LoadoutNameTextBox.Width = 100;
			//
			// SlotNumberTextBox
			//
			this.SlotNumberTextBox.DataBindings.Add("Text", this.BindingSource, "Slot", true);
			this.SlotNumberTextBox.Location = DPIScalingHelper.GetScaledPoint(100, 50);
			this.SlotNumberTextBox.Name = "SlotNumberTextBox";
			this.SlotNumberTextBox.Width = 30;
			this.SlotNumberTextBox.Caption = "Save Slot";
			//
			// RestrictCheckBox
			//
			this.RemoveProfileRestrictionsCheckBox.Name = "RemoveProfileRestrictionsCheckBox";
			this.RemoveProfileRestrictionsCheckBox.Caption = "Remove Loadout Restrictions";
			this.RemoveProfileRestrictionsCheckBox.DataBindings.Add("Checked", BindingSource, "RemoveProfileLimits");
			this.RemoveProfileRestrictionsCheckBox.Location = DPIScalingHelper.GetScaledPoint(500, 20);
			//
			// SoloBonusCheckBox
			//
			this.SoloBonusCheckBox.Location = DPIScalingHelper.GetScaledPoint(100, 140);
			this.SoloBonusCheckBox.Caption = "Solo Bonus:";
			this.SoloBonusCheckBox.Name = "SoloBonuscheckBox";
			this.SoloBonusCheckBox.DataBindings.Add("Checked", BindingSource, "UnitConfiguration.HasSoloBonus");
			//
			// DifficutlyComboBox
			//
			this.DifficultyDropBox.DataBindings.Add("SelectedValue", BindingSource, "UnitConfiguration.DifficultyLevel");
			this.DifficultyDropBox.Name = "DifficultyDropBox";
			this.DifficultyDropBox.List = DifficultyList;
			this.DifficultyDropBox.Location = DPIScalingHelper.GetScaledPoint(100, 80);
			this.DifficultyDropBox.Caption = "Difficulty:";
			//
			// UnitSpecComboBox
			//
			this.UnitSpecDropBox.DataBindings.Add("SelectedValue", BindingSource, "UnitSpec");
			this.UnitSpecDropBox.DataBindings.Add("Enabled", BindingSource, "UnitSpec_Readonly");
			this.UnitSpecDropBox.List = UnitSpecList;
			this.UnitSpecDropBox.Location = DPIScalingHelper.GetScaledPoint(100, 110);
			this.UnitSpecDropBox.Name = "UnitSpecDropBox";
			this.UnitSpecDropBox.Caption = "UnitSpec:";
			//
			// TotalPerkPointsLabel
			//
			this.TotalPerkPointsLabel.Caption = "Total Perk Points:";
			this.TotalPerkPointsLabel.DataBindings.Add("Text", BindingSource, "PerkPointsCost");
			this.TotalPerkPointsLabel.Name = "TotalPerkPointsLabel";
			this.TotalPerkPointsLabel.Location = DPIScalingHelper.GetScaledPoint(450, 50);
			//
			// TotalGemsLabel
			//
			this.TotalGemsLabel.Caption = "Total Gems:";
			this.TotalGemsLabel.DataBindings.Add("Text", BindingSource, "Gems.TotalCost");
			this.TotalGemsLabel.Name = "TotalGemsLabel";
			this.TotalGemsLabel.Location = DPIScalingHelper.GetScaledPoint(450, 80);
			//
			// TotalCPLabel
			//
			this.TotalCPLabel.Caption = "Total Challenge Points:";
			this.TotalCPLabel.DataBindings.Add("Text", BindingSource, "ChallengePoints.TotalCost");
			this.TotalCPLabel.Name = "TotalCPLabel";
			this.TotalCPLabel.Location = DPIScalingHelper.GetScaledPoint(450, 110);
			// 
			// LoadoutDetailsControl
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(LoadoutNameTextBox);
			this.Controls.Add(SlotNumberTextBox);
			this.Controls.Add(RemoveProfileRestrictionsCheckBox);
			this.Controls.Add(SoloBonusCheckBox);
			this.Controls.Add(DifficultyDropBox);
			this.Controls.Add(UnitSpecDropBox);
			this.Controls.Add(TotalPerkPointsLabel);
			this.Controls.Add(TotalGemsLabel);
			this.Controls.Add(TotalCPLabel);
			((ISupportInitialize)this.BindingSource).EndInit();
			this.ResumeLayout();
			this.PerformLayout();
		}

		#endregion

		private VCheckControl RemoveProfileRestrictionsCheckBox;
		private VTextBox SlotNumberTextBox;
		private VTextBox LoadoutNameTextBox;
		private BindingSource BindingSource;
		private VCheckControl SoloBonusCheckBox;
		private VDropBox DifficultyDropBox;
		private VDropBox UnitSpecDropBox;
		private VLabel TotalPerkPointsLabel;
		private VLabel TotalGemsLabel;
		private VLabel TotalCPLabel;
	}
}
