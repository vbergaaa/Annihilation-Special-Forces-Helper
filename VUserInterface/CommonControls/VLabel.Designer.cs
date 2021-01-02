using System.Drawing;
using System.Media;
using System.Reflection.Emit;

namespace VUserInterface.CommonControls
{
	partial class VLabel
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
			this.Label = new System.Windows.Forms.Label();
			this.CoreControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// CoreControl
			// 
			this.CoreControl.Controls.Add(this.Label);
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.BackColor = System.Drawing.Color.Navy;
			this.Label.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "Text", true));
			this.Label.ForeColor = System.Drawing.Color.White;
			this.Label.Location = new System.Drawing.Point(0, 3);
			this.Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(0, 25);
			this.Label.TabIndex = 0;
			this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VLabel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "VLabel";
			this.CoreControl.ResumeLayout(false);
			this.CoreControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Label;
	}
}
