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
			this.SoloBonusCheckBox = new VCheckControl();
			this.UnitSpecCheckBox = new VCheckControl();
			this.AdrenalineRushCheckBox = new VCheckControl();
			this.DifficultyDropBox = new VDropBox();
			this.UnitsLoadList = new VSelectList();
			this.CurrentUnitControl = new UnitControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(UnitConfiguration);
			//
			// UnitsLoadList
			//
			this.UnitsLoadList.DataBindings.Add("List", bindingSource, "Units", true, DataSourceUpdateMode.OnPropertyChanged);
			this.UnitsLoadList.Location = DPIScalingHelper.GetScaledPoint(20, 30);
			this.UnitsLoadList.Name = "UnitsLoadList";
			this.UnitsLoadList.Size = DPIScalingHelper.GetScaledSize(280, 160);
			this.UnitsLoadList.TabIndex = 0;
			this.UnitsLoadList.Text = "Units";
			this.UnitsLoadList.IndexChanged += UnitsLoadList_IndexChanged;
			this.UnitsLoadList.NewButtonClicked += UnitsLoadList_NewButtonClicked;
			this.UnitsLoadList.DeleteButtonClicked += UnitsLoadList_DeleteButtonClicked;
			//
			// CurrentUnitControl
			//
			this.CurrentUnitControl.DataBindings.Add("Unit", bindingSource, "Loadout.CurrentUnit");
			this.CurrentUnitControl.Name = "CurrentUserControl";
			this.CurrentUnitControl.Location = DPIScalingHelper.GetScaledPoint(290, 30);
			this.CurrentUnitControl.UnitChanged += CurrentUnitControl_UnitChanged;
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(DifficultyDropBox);
			this.Controls.Add(SoloBonusCheckBox);
			this.Controls.Add(UnitSpecCheckBox);
			this.Controls.Add(AdrenalineRushCheckBox);
			this.Controls.Add(UnitsLoadList);
			this.Controls.Add(CurrentUnitControl);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			this.VisibleChanged += UnitConfigurationControl_VisibleChanged;
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		VDropBox DifficultyDropBox;
		VCheckControl SoloBonusCheckBox;
		VCheckControl UnitSpecCheckBox;
		VCheckControl AdrenalineRushCheckBox;
		VSelectList UnitsLoadList;
		UnitControl CurrentUnitControl;
	}
}
