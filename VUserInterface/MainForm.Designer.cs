using System;
using System.ComponentModel;

namespace VUserInterface
{
	partial class MainForm
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
			this.LoadoutsListBox = new System.Windows.Forms.ListBox();
			this.LoadoutsLabel = new System.Windows.Forms.Label();
			this.DeleteLoadoutButton = new System.Windows.Forms.Button();
			this.NewLoadoutButton = new System.Windows.Forms.Button();
			this.OpenLoadoutButton = new System.Windows.Forms.Button(); 
			this.SuspendLayout();
			// 
			// LoadoutsListBox
			// 
			this.LoadoutsListBox.DisplayMember = "Key";
			this.LoadoutsListBox.DataSource = this.LoadoutsCollection;
			this.LoadoutsListBox.FormattingEnabled = true;
			this.LoadoutsListBox.ItemHeight = 15;
			this.LoadoutsListBox.Location = new System.Drawing.Point(83, 52);
			this.LoadoutsListBox.Name = "LoadoutsListBox";
			this.LoadoutsListBox.Size = new System.Drawing.Size(275, 94);
			this.LoadoutsListBox.Sorted = true;
			this.LoadoutsListBox.TabIndex = 0;
			this.LoadoutsListBox.ValueMember = "Value";
			// 
			// LoadoutsLabel
			// 
			this.LoadoutsLabel.AutoSize = true;
			this.LoadoutsLabel.Location = new System.Drawing.Point(85, 23);
			this.LoadoutsLabel.Name = "LoadoutsLabel";
			this.LoadoutsLabel.Size = new System.Drawing.Size(56, 15);
			this.LoadoutsLabel.TabIndex = 1;
			this.LoadoutsLabel.Text = "Loadouts";
			// 
			// NewLoadoutButton
			// 
			this.NewLoadoutButton.Click += NewLoadout_Click;
			this.NewLoadoutButton.Location = new System.Drawing.Point(82, 153);
			this.NewLoadoutButton.Name = "NewLoadoutButton";
			this.NewLoadoutButton.Size = new System.Drawing.Size(85, 23);
			this.NewLoadoutButton.TabIndex = 2;
			this.NewLoadoutButton.Text = "New";
			this.NewLoadoutButton.UseVisualStyleBackColor = true;
			// 
			// OpenLoadoutButton
			// 
			this.OpenLoadoutButton.Click += OpenLoadout_Click;
			this.OpenLoadoutButton.Location = new System.Drawing.Point(177, 153);
			this.OpenLoadoutButton.Name = "OpenLoadoutButton";
			this.OpenLoadoutButton.Size = new System.Drawing.Size(85, 23);
			this.OpenLoadoutButton.TabIndex = 2;
			this.OpenLoadoutButton.Text = "Open";
			this.OpenLoadoutButton.UseVisualStyleBackColor = true;
			// 
			// DeleteLoadoutButton
			// 
			this.DeleteLoadoutButton.Click += DeleteLoadout_Click;
			this.DeleteLoadoutButton.Location = new System.Drawing.Point(272, 153);
			this.DeleteLoadoutButton.Name = "DeleteLoadoutButton";
			this.DeleteLoadoutButton.Size = new System.Drawing.Size(85, 23);
			this.DeleteLoadoutButton.TabIndex = 2;
			this.DeleteLoadoutButton.Text = "Delete";
			this.DeleteLoadoutButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 230);
			this.Controls.Add(this.DeleteLoadoutButton);
			this.Controls.Add(this.OpenLoadoutButton);
			this.Controls.Add(this.NewLoadoutButton);
			this.Controls.Add(this.LoadoutsLabel);
			this.Controls.Add(this.LoadoutsListBox);
			this.Name = "MainForm";
			this.Text = "Annihilation Special Forces Companion App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox LoadoutsListBox;
		private System.Windows.Forms.Label LoadoutsLabel;
		private System.Windows.Forms.Button DeleteLoadoutButton;
		private System.Windows.Forms.Button NewLoadoutButton;
		private System.Windows.Forms.Button OpenLoadoutButton;
	}
}