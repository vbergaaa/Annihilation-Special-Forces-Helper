using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	partial class VUserControl
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
			this.CaptionLabel = new VLabel();
			this.CoreControl = new UserControl();
			components = new System.ComponentModel.Container();
			//
			// CaptionLabel
			//
			this.CaptionLabel.AutoSize = true;
			this.CaptionLabel.Location = new System.Drawing.Point(0, 7);
			this.CaptionLabel.Name = "CaptionLabel";
			this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CaptionLabel.Visible = false;
			//
			// VUserControl
			//
			this.Controls.Add(CaptionLabel);
			this.Controls.Add(CoreControl);
			this.MaximumSize = new System.Drawing.Size(500, 29);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		}

		#endregion

		protected VLabel CaptionLabel;
		protected UserControl CoreControl;
	}
}
