using System;
using System.ComponentModel;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;

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
			this.LoadoutsLoadList = new VLoadList();
			this.SoulsListBox = new System.Windows.Forms.ListBox();
			this.SoulsLabel = new VLabel();
			this.DeleteSoulButton = new System.Windows.Forms.Button();
			this.NewSoulButton = new System.Windows.Forms.Button();
			this.OpenSoulButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// LoadoutsLoadList
			//
			this.LoadoutsLoadList.BizoType = typeof(Loadout);
			this.LoadoutsLoadList.Location = new System.Drawing.Point(83, 32);
			this.LoadoutsLoadList.Name = "LoadoutsListBox";
			this.LoadoutsLoadList.TabIndex = 0;
			this.LoadoutsLoadList.Text = "Loadouts";
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
			this.Controls.Add(this.LoadoutsLoadList);
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

		private VLoadList LoadoutsLoadList;
		private System.Windows.Forms.ListBox SoulsListBox;
		private System.Windows.Forms.Label SoulsLabel;
		private System.Windows.Forms.Button DeleteSoulButton;
		private System.Windows.Forms.Button NewSoulButton;
		private System.Windows.Forms.Button OpenSoulButton;
	}
}