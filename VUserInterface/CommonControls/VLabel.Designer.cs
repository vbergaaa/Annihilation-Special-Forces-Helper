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
			components = new System.ComponentModel.Container();
			this.Label = new System.Windows.Forms.Label();
			this.Label.AutoSize = true;
			this.Label.DataBindings.Add("Text", this, "Text");
			this.Label.Location = new Point(0, 3);
			this.Label.TextAlign = ContentAlignment.MiddleLeft;
#if DEBUG
			this.Label.ForeColor = Color.White;
			this.Label.BackColor = Color.Navy;
#endif
			this.CoreControl.Controls.Add(Label);

		}

		#endregion

		private System.Windows.Forms.Label Label;
	}
}
