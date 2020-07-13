using System.Windows.Forms;

namespace VUserInterface
{
	abstract partial class VForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.SaveButton = new Button();
			this.CancelButton = new Button();
			//
			// SaveButton
			//
			this.SaveButton.Location = new System.Drawing.Point(620, 420);
			this.SaveButton.Size = new System.Drawing.Size(80, 25);
			this.SaveButton.Text = "Save";
			this.SaveButton.Click += SaveButton_Click;
			//
			// CancelButton
			//
			this.CancelButton.Location = new System.Drawing.Point(710, 420);
			this.CancelButton.Size = new System.Drawing.Size(80, 25);
			this.CancelButton.Text = "Cancel";
			this.CancelButton.Click += CancelButton_Click;
			//
			// this
			//
			this.Text = "Annihilation Special Forces Companion Application";
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CancelButton);
		}
		#endregion

		private Button SaveButton;
		private new Button CancelButton;
	}
}