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
			this.SoulsListBox = new System.Windows.Forms.ListBox();
			this.SoulsLabel = new System.Windows.Forms.Label();
			this.DeleteSoulButton = new System.Windows.Forms.Button();
			this.NewSoulButton = new System.Windows.Forms.Button();
			this.OpenSoulButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LoadoutsListBox
			// 
			this.LoadoutsListBox.DataSource = this.LoadoutsCollection;
			this.LoadoutsListBox.FormattingEnabled = true;
			this.LoadoutsListBox.ItemHeight = 15;
			this.LoadoutsListBox.Location = new System.Drawing.Point(83, 52);
			this.LoadoutsListBox.Name = "LoadoutsListBox";
			this.LoadoutsListBox.Size = new System.Drawing.Size(275, 94);
			this.LoadoutsListBox.TabIndex = 0;
			// 
			// LoadoutsLabel
			// 
			this.LoadoutsLabel.AutoSize = true;
			this.LoadoutsLabel.Location = new System.Drawing.Point(85, 33);
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
			// SoulsListBox
			// 
			this.SoulsListBox.DataSource = this.SoulsCollection;
			this.SoulsListBox.FormattingEnabled = true;
			this.SoulsListBox.ItemHeight = 15;
			this.SoulsListBox.Location = new System.Drawing.Point(83, 232);
			this.SoulsListBox.Name = "SoulsListBox";
			this.SoulsListBox.Size = new System.Drawing.Size(275, 94);
			this.SoulsListBox.TabIndex = 0;
			// 
			// SoulsLabel
			// 
			this.SoulsLabel.AutoSize = true;
			this.SoulsLabel.Location = new System.Drawing.Point(85, 213);
			this.SoulsLabel.Name = "SoulsLabel";
			this.SoulsLabel.Size = new System.Drawing.Size(56, 15);
			this.SoulsLabel.TabIndex = 1;
			this.SoulsLabel.Text = "Souls";
			// 
			// NewSoulButton
			// 
			this.NewSoulButton.Click += NewSoul_Click;
			this.NewSoulButton.Location = new System.Drawing.Point(82, 333);
			this.NewSoulButton.Name = "NewSoulButton";
			this.NewSoulButton.Size = new System.Drawing.Size(85, 23);
			this.NewSoulButton.TabIndex = 2;
			this.NewSoulButton.Text = "New";
			this.NewSoulButton.UseVisualStyleBackColor = true;
			// 
			// OpenSoulButton
			// 
			this.OpenSoulButton.Click += OpenSoul_Click;
			this.OpenSoulButton.Location = new System.Drawing.Point(177, 333);
			this.OpenSoulButton.Name = "OpenSoulButton";
			this.OpenSoulButton.Size = new System.Drawing.Size(85, 23);
			this.OpenSoulButton.TabIndex = 2;
			this.OpenSoulButton.Text = "Open";
			this.OpenSoulButton.UseVisualStyleBackColor = true;
			// 
			// DeleteSoulButton
			// 
			this.DeleteSoulButton.Click += DeleteSoul_Click;
			this.DeleteSoulButton.Location = new System.Drawing.Point(272, 333);
			this.DeleteSoulButton.Name = "DeleteSoulButton";
			this.DeleteSoulButton.Size = new System.Drawing.Size(85, 23);
			this.DeleteSoulButton.TabIndex = 2;
			this.DeleteSoulButton.Text = "Delete";
			this.DeleteSoulButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 380);
			this.Controls.Add(this.DeleteLoadoutButton);
			this.Controls.Add(this.OpenLoadoutButton);
			this.Controls.Add(this.NewLoadoutButton);
			this.Controls.Add(this.LoadoutsLabel);
			this.Controls.Add(this.LoadoutsListBox);
			this.Controls.Add(this.DeleteSoulButton);
			this.Controls.Add(this.OpenSoulButton);
			this.Controls.Add(this.NewSoulButton);
			this.Controls.Add(this.SoulsLabel);
			this.Controls.Add(this.SoulsListBox);
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
		private System.Windows.Forms.ListBox SoulsListBox;
		private System.Windows.Forms.Label SoulsLabel;
		private System.Windows.Forms.Button DeleteSoulButton;
		private System.Windows.Forms.Button NewSoulButton;
		private System.Windows.Forms.Button OpenSoulButton;
	}
}