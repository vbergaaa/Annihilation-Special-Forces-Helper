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
			this.RankComboBox = new ComboBox();
			this.RankCaption = new VLabel();
			this.InfusionIncrementor = new VIncrementor();
			this.EssenceIncrementor = new VIncrementor();
			this.SoloBonusCheckBox = new VCheckControl();
			this.UnitSpecCheckBox = new VCheckControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(UnitConfiguration);
			//
			// RankComboBox
			//
			this.RankComboBox.DataSource = Ranks;
			this.RankComboBox.Location = new System.Drawing.Point(125, 40);
			this.RankComboBox.SelectedValueChanged += RankChanged;
			//
			// RankCaption
			//
			this.RankCaption.Location = new System.Drawing.Point(35, 40);
			this.RankCaption.Size = new System.Drawing.Size(86, 20);
			this.RankCaption.Text = "Rank:";
			this.RankCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// InfusionIncrementor
			//
			this.InfusionIncrementor.Location = new System.Drawing.Point(125, 70);
			this.InfusionIncrementor.DataBindings.Add("Value", bindingSource, "CurrentInfusion");
			this.InfusionIncrementor.DataBindings.Add("MaxValue", bindingSource, "MaximumInfusion");
			this.InfusionIncrementor.Caption = "Infusion:";
			//
			// EssenceIncrementor
			//
			this.EssenceIncrementor.Location = new System.Drawing.Point(125, 100);
			this.EssenceIncrementor.DataBindings.Add("Value", bindingSource, "EssenceStacks");
			this.EssenceIncrementor.DataBindings.Add("MaxValue", bindingSource, "MaximumEssence");
			this.EssenceIncrementor.Caption = "Essence:";
			//
			// SoloBonusCheckBox
			//
			this.SoloBonusCheckBox.Location = new System.Drawing.Point(125, 130);
			this.SoloBonusCheckBox.Caption = "Solo Bonus:";
			this.SoloBonusCheckBox.DataBindings.Add("Checked", bindingSource, "HasSoloBonus");
			//
			// UnitSpecCheckBox
			//
			this.UnitSpecCheckBox.Location = new System.Drawing.Point(125, 160);
			this.UnitSpecCheckBox.Caption = "Has Unit Spec:";
			this.UnitSpecCheckBox.DataBindings.Add("Checked", bindingSource, "HasUnitSpec");
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(RankComboBox);
			this.Controls.Add(RankCaption);
			this.Controls.Add(InfusionIncrementor);
			this.Controls.Add(EssenceIncrementor);
			this.Controls.Add(SoloBonusCheckBox);
			this.Controls.Add(UnitSpecCheckBox);
			this.Size = new System.Drawing.Size(589, 292);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		ComboBox RankComboBox;
		Label RankCaption;
		VIncrementor InfusionIncrementor;
		VIncrementor EssenceIncrementor;
		VCheckControl SoloBonusCheckBox;
		VCheckControl UnitSpecCheckBox;
	}
}
