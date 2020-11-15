using System;
using System.Windows.Forms;
using VBusiness;
using VBusiness.Souls;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class UnitConfigurationControl
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
			this.RankDropBox = new VDropBox();
			this.InfusionIncrementor = new VIncrementor();
			this.EssenceIncrementor = new VIncrementor();
			this.SoloBonusCheckBox = new VCheckControl();
			this.UnitSpecCheckBox = new VCheckControl();
			this.AdrenalineRushCheckBox = new VCheckControl();
			this.DifficultyDropBox = new VDropBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(UnitConfiguration);
			//
			// RankComboBox
			//
			this.RankDropBox.DataBindings.Add("SelectedValue", bindingSource, "UnitRank");
			this.RankDropBox.List = RankList;
			this.RankDropBox.Location = new System.Drawing.Point(125, 20);
			this.RankDropBox.Caption = "Rank:";
			//
			// InfusionIncrementor
			//
			this.InfusionIncrementor.Location = new System.Drawing.Point(125, 50);
			this.InfusionIncrementor.DataBindings.Add("Value", bindingSource, "CurrentInfusion");
			this.InfusionIncrementor.DataBindings.Add("MaxValue", bindingSource, "MaximumInfusion");
			this.InfusionIncrementor.Caption = "Infusion:";
			//
			// EssenceIncrementor
			//
			this.EssenceIncrementor.Location = new System.Drawing.Point(125, 80);
			this.EssenceIncrementor.DataBindings.Add("Value", bindingSource, "EssenceStacks");
			this.EssenceIncrementor.DataBindings.Add("MaxValue", bindingSource, "MaximumEssence");
			this.EssenceIncrementor.Caption = "Essence:";
			//
			// SoloBonusCheckBox
			//
			this.SoloBonusCheckBox.Location = new System.Drawing.Point(125, 110);
			this.SoloBonusCheckBox.Caption = "Solo Bonus:";
			this.SoloBonusCheckBox.DataBindings.Add("Checked", bindingSource, "HasSoloBonus");
			//
			// UnitSpecCheckBox
			//
			this.UnitSpecCheckBox.Location = new System.Drawing.Point(125, 140);
			this.UnitSpecCheckBox.Caption = "Has Unit Spec:";
			this.UnitSpecCheckBox.DataBindings.Add("Checked", bindingSource, "HasUnitSpec");
			//
			// AdrenalineRushCheckBox
			//
			this.AdrenalineRushCheckBox.Location = new System.Drawing.Point(125, 170);
			this.AdrenalineRushCheckBox.Caption = "Adrenaline Rush:";
			this.AdrenalineRushCheckBox.DataBindings.Add("Checked", bindingSource, "HasAdrenalineBuffActive");
			//
			// DifficutlyComboBox
			//
			this.DifficultyDropBox.DataBindings.Add("SelectedValue", bindingSource, "DifficultyLevel");
			this.DifficultyDropBox.List = DifficultyList;
			this.DifficultyDropBox.Location = new System.Drawing.Point(125, 200);
			this.DifficultyDropBox.Caption = "Difficulty:";
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(RankDropBox);
			this.Controls.Add(DifficultyDropBox);
			this.Controls.Add(InfusionIncrementor);
			this.Controls.Add(EssenceIncrementor);
			this.Controls.Add(SoloBonusCheckBox);
			this.Controls.Add(UnitSpecCheckBox);
			this.Controls.Add(AdrenalineRushCheckBox);
			this.Size = new System.Drawing.Size(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		VDropBox RankDropBox;
		VDropBox DifficultyDropBox;
		VIncrementor InfusionIncrementor;
		VIncrementor EssenceIncrementor;
		VCheckControl SoloBonusCheckBox;
		VCheckControl UnitSpecCheckBox;
		VCheckControl AdrenalineRushCheckBox;
	}
}
