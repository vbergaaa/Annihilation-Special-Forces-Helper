using System.Windows.Forms;

namespace VUserInterface
{
	partial class VTextBox
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
			this.TextBox = new System.Windows.Forms.TextBox();
			this.CoreControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// CoreControl
			// 
			this.CoreControl.Controls.Add(this.TextBox);
			this.CoreControl.Size = new System.Drawing.Size(300, 29);
			// 
			// TextBox
			// 
			this.TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "Text", true));
			this.TextBox.Location = new System.Drawing.Point(0, 1);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(300, 23);
			this.TextBox.TabIndex = 2;
			// 
			// VTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.Name = "VTextBox";
			this.Size = new System.Drawing.Size(300, 24);
			this.CoreControl.ResumeLayout(false);
			this.CoreControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		TextBox TextBox;

		#endregion
	}
}
