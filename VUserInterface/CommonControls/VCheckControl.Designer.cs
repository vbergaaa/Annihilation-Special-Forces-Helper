using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	partial class VCheckControl
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.CheckBox = new VCheckBox();
			//
			// this.CaptionLabel
			//
			this.CaptionLabel.Location = new System.Drawing.Point(0, 0);
			//
			// CheckBox
			//
			this.CheckBox.AutoSize = false;
			this.CheckBox.DataBindings.Add("CheckState", this, "Checked", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox.Location = new System.Drawing.Point(0, 0);
			this.CheckBox.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CoreControl
			//
			this.CoreControl.Size = DPIScalingHelper.GetScaledSize(21, 21);
			this.CoreControl.Controls.Add(CheckBox);
			//
			// VCheckBox
			//
			this.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
			this.Size = DPIScalingHelper.GetScaledSize(21, 21);
		}

		#endregion

		private CheckBox CheckBox;
	}
}
