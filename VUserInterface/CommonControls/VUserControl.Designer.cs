using System.Drawing;
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
			this.CaptionLabel = new Label();
			this.CoreControl = new Panel();
			components = new System.ComponentModel.Container();
			//
			// CaptionLabel
			//
			this.CaptionLabel.AutoSize = true;
			this.CaptionLabel.Location = new System.Drawing.Point(0, 3);
			this.CaptionLabel.Name = "CaptionLabel";
			this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.CaptionLabel.Visible = false;
#if DEBUG
			this.CaptionLabel.ForeColor = Color.White;
			this.CaptionLabel.BackColor = Color.Navy;
#endif
			//
			// CoreControl
			//
			this.CoreControl.Location = new Point(0, 0);
			this.CoreControl.Name = "CoreControl";
			this.CoreControl.SizeChanged += CoreControl_SizeChanged;
			this.CoreControl.Size = new Size(100, 29);
			//
			// VUserControl
			//
			this.Controls.Add(CaptionLabel);
			this.Controls.Add(CoreControl);
			this.MaximumSize = new System.Drawing.Size(500, 29);
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		}

		#endregion

		protected System.Windows.Forms.Label CaptionLabel;
		protected Panel CoreControl;
	}
}
