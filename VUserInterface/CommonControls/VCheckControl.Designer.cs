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
			this.CheckBox = new VCheckBox();
			//
			// this.CaptionLabel
			//
			this.CaptionLabel.Location = new System.Drawing.Point(0, 2);
			//
			// CheckBox
			//
			this.CheckBox.AutoSize = false;
			this.CheckBox.DataBindings.Add("CheckState", this, "Checked", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox.Location = new System.Drawing.Point(0, 0);
			this.CheckBox.Size = new System.Drawing.Size(20, 20);
			//
			// VCheckBox
			//
			this.CoreControl.Controls.Add(CheckBox);
			this.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
			this.Height = 29;
		}

		#endregion

		private CheckBox CheckBox;
	}
}
