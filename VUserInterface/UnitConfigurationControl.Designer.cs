using System;
using System.Windows.Forms;
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
			this.RankComboBox = new VDropBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(UnitConfigurationControl);
			//
			// RankComboBox
			//
			this.RankComboBox.Location = new System.Drawing.Point(125, 40);
			this.RankComboBox.Caption = "Rank:";
			this.RankComboBox.List = Ranks;
			this.RankComboBox.SelectedValueChanged += RankChanged;
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(RankComboBox);
			this.Size = new System.Drawing.Size(589, 292);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		VDropBox RankComboBox;
	}
}
