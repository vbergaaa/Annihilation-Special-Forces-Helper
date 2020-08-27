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
			this.CaptionLabel = new VLabel();
			this.CheckBox = new VCheckBox();
			//
			// this.CaptionLabel
			//
			this.CaptionLabel.AutoSize = true;
			this.CaptionLabel.Location = new System.Drawing.Point(0, 7);
			this.CaptionLabel.Name = "CaptionLabel";
			this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CaptionLabel.Visible = false;
			//
			// CheckBox
			//
			this.CheckBox.AutoSize = false;
			this.CheckBox.DataBindings.Add("CheckState", this, "Checked", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox.Location = new System.Drawing.Point(1, 3);
			this.CheckBox.Size = new System.Drawing.Size(20, 20);
			//
			// VCheckBox
			//
			this.Controls.Add(CheckBox);
			this.Controls.Add(CaptionLabel);
			this.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
		}

		#endregion

		private Label CaptionLabel;
		private CheckBox CheckBox;
	}
}
