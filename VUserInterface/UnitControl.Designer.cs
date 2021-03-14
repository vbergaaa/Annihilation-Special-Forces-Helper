
using System.Collections.Generic;
using VBusiness.Units;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class UnitControl
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
			this.components = new System.ComponentModel.Container();
			this.UnitTypeDropBox = new VUserInterface.CommonControls.VDropBox();
			this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.InfusionIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.RankDropBox = new VUserInterface.CommonControls.VDropBox();
			this.EssenceIncrementor = new VUserInterface.CommonControls.VIncrementor();
			this.UnitTypeLabel = new VLabel();
			this.TitleLabel = new VLabel();
			this.AddButton = new DPIButton();
			this.SpecCheckBox = new VCheckControl();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.SuspendLayout();
			//
			// TitleLabel
			//
			this.TitleLabel.Font = new System.Drawing.Font(TitleLabel.Font, System.Drawing.FontStyle.Bold);
			this.TitleLabel.Text = "Current Unit";
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = DPIScalingHelper.GetScaledPoint(50, 0);
			// 
			// UnitTypeDropBox
			// 
			this.UnitTypeDropBox.Caption = "Type:";
			this.UnitTypeDropBox.SelectedValueChanged += UnitTypeDropBox_SelectedValueChanged;
			this.UnitTypeDropBox.DataBindings.Add("SelectedValue", BindingSource, "UnitData.Type");
			this.UnitTypeDropBox.List = UnitsTypesList;
			this.UnitTypeDropBox.Location = DPIScalingHelper.GetScaledPoint(106, 30);
			this.UnitTypeDropBox.Name = "UnitTypeDropBox";
			this.UnitTypeDropBox.Size = DPIScalingHelper.GetScaledSize(150, 29);
			this.UnitTypeDropBox.Visible = true;
			// 
			// UnitTypeLabel
			// 
			this.UnitTypeLabel.Caption = "Type: ";
			this.UnitTypeLabel.DataBindings.Add("Text", BindingSource, "UnitData.Type");
			this.UnitTypeLabel.Location = DPIScalingHelper.GetScaledPoint(106, 30);
			this.UnitTypeLabel.Name = "UnitTypeLabel";
			this.UnitTypeLabel.Size = DPIScalingHelper.GetScaledSize(211, 29);
			this.UnitTypeLabel.Visible = false;
			// 
			// BindingSource
			// 
			this.BindingSource.DataSource = typeof(VBusiness.Units.Unit);
			// 
			// InfusionIncrementor
			// 
			this.InfusionIncrementor.Caption = "Infusion:";
			this.InfusionIncrementor.DataBindings.Add("Value", BindingSource, "CurrentInfusion");
			this.InfusionIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaximumInfusion");
			this.InfusionIncrementor.Location = DPIScalingHelper.GetScaledPoint(106, 90);
			this.InfusionIncrementor.Name = "InfusionIncrementor";
			this.InfusionIncrementor.TabIndex = 1;
			this.InfusionIncrementor.Value = 0;
			//this.InfusionIncrementor.ValueChanged += UpdateUnitsListBindings;
			// 
			// RankDropBox
			// 
			this.RankDropBox.Caption = "Rank";
			this.RankDropBox.DataBindings.Add("SelectedValue", BindingSource, "UnitRank");
			this.RankDropBox.List = RanksList;
			this.RankDropBox.Location = DPIScalingHelper.GetScaledPoint(106, 60);
			this.RankDropBox.Name = "RankDropBox";
			this.RankDropBox.Size = DPIScalingHelper.GetScaledSize(150, 29);
			this.RankDropBox.TabIndex = 2;
			//this.RankDropBox.SelectedValueChanged += UpdateUnitsListBindings;
			// 
			// EssenceIncrementor
			// 
			this.EssenceIncrementor.Caption = "Essence:";
			this.EssenceIncrementor.DataBindings.Add("Value", BindingSource, "EssenceStacks");
			this.EssenceIncrementor.DataBindings.Add("MaxValue", BindingSource, "MaximumEssence");
			this.EssenceIncrementor.IncrementAmount = 1;
			this.EssenceIncrementor.Location = DPIScalingHelper.GetScaledPoint(106, 120);
			this.EssenceIncrementor.Name = "EssenceIncrementor";
			this.EssenceIncrementor.TabIndex = 3;
			this.EssenceIncrementor.Value = 0;
			//
			// SpecCheckBox
			//
			this.SpecCheckBox.Caption = "Unit Spec";
			this.SpecCheckBox.DataBindings.Add("Checked", BindingSource, "HasUnitSpec");
			this.SpecCheckBox.Enabled = false;
			this.SpecCheckBox.Location = DPIScalingHelper.GetScaledPoint(106, 150);
			this.SpecCheckBox.Name = "SpecCheckBox";
			// 
			// AddButton
			// 
			this.AddButton.Location = DPIScalingHelper.GetScaledPoint(106, 180);
			this.AddButton.Name = "AddButton";
			this.AddButton.TabIndex = 4;
			this.AddButton.Text = "Add";
			this.AddButton.Click += AddButton_Click;
			// 
			// UnitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.DataBindings.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
			this.Controls.Add(this.EssenceIncrementor);
			this.Controls.Add(this.RankDropBox);
			this.Controls.Add(this.InfusionIncrementor);
			this.Controls.Add(this.UnitTypeDropBox);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.UnitTypeLabel);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.SpecCheckBox);
			this.Name = "UnitControl";
			this.Size = DPIScalingHelper.GetScaledSize(256, 210);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		VLabel TitleLabel;
		private CommonControls.VDropBox UnitTypeDropBox;
		private CommonControls.VIncrementor InfusionIncrementor;
		private CommonControls.VDropBox RankDropBox;
		private CommonControls.VIncrementor EssenceIncrementor;
		System.Windows.Forms.BindingSource BindingSource;
		VLabel UnitTypeLabel;
		System.Windows.Forms.Button AddButton;
		VCheckControl SpecCheckBox;
	}
}
