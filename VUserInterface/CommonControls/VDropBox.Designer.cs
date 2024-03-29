﻿using System;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	partial class VDropBox
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
			this.ComboBox = new ComboBox();
			//
			// ComboBox
			//
			this.ComboBox.DataBindings.Add("SelectedIndex", this, "SelectedIndex", true, DataSourceUpdateMode.OnPropertyChanged);
			this.ComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboBox_Format);
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Location = DPIScalingHelper.GetScaledPoint(0, 1);
			this.ComboBox.SelectedValueChanged += ComboBox_SelectedValueChanged;
			//
			// DropBox
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.MaximumSize = DPIScalingHelper.GetScaledSize(200, 30);
			this.CoreControl.Controls.Add(ComboBox);
			this.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
		}

		#endregion

		private ComboBox ComboBox;
	}
}
