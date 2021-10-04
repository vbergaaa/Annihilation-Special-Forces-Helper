using System.Windows.Forms;
using VBusiness.Loadouts;

namespace VUserInterface
{
	partial class UnitsControl
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
			this.bindingSource = new VBindingSource();
			this.UnitsLoadList = new UnitSelectList();
			this.CurrentUnitControl = new UnitControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(Loadout);
			//
			// UnitsLoadList
			//
			this.UnitsLoadList.DataBindings.Add("List", bindingSource, "Units", true, DataSourceUpdateMode.OnPropertyChanged);
			this.UnitsLoadList.DataBindings.Add("Loadout", bindingSource, ".", true, DataSourceUpdateMode.OnPropertyChanged);
			this.UnitsLoadList.Location = DPIScalingHelper.GetScaledPoint(20, 30);
			this.UnitsLoadList.Name = "UnitsLoadList";
			this.UnitsLoadList.Size = DPIScalingHelper.GetScaledSize(280, 160);
			this.UnitsLoadList.TabIndex = 0;
			this.UnitsLoadList.Text = "Units";
			//
			// CurrentUnitControl
			//
			this.CurrentUnitControl.DataBindings.Add("Unit", bindingSource, "CurrentUnit");
			this.CurrentUnitControl.Name = "CurrentUserControl";
			this.CurrentUnitControl.Location = DPIScalingHelper.GetScaledPoint(290, 30);
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(UnitsLoadList);
			this.Controls.Add(CurrentUnitControl);
			this.Size = DPIScalingHelper.GetScaledSize(589, 272);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		UnitSelectList UnitsLoadList;
		UnitControl CurrentUnitControl;
	}
}
