﻿using System.Windows.Forms;
using VEntityFramework.Data;

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
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.BindingSource = new BindingSource();
			this.SaveButton = new Button();
			this.CancelButton = new Button();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(VBusinessObject);
			//
			// SaveButton
			//
			this.SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.SaveButton.DataBindings.Add(new Binding("Enabled", BindingSource, "HasChanges"));
			this.SaveButton.Location = new System.Drawing.Point(this.ClientSize.Width - 180, this.ClientSize.Height - 30);
			this.SaveButton.Size = new System.Drawing.Size(80, 25);
			this.SaveButton.Text = "Save";
			this.SaveButton.Click += SaveButton_Click;
			//
			// CancelButton
			//
			this.CancelButton.Anchor = AnchorStyles.Bottom  | AnchorStyles.Right;
			this.CancelButton.Location = new System.Drawing.Point(this.ClientSize.Width - 90, this.ClientSize.Height - 30);
			this.CancelButton.Size = new System.Drawing.Size(80, 25);
			this.CancelButton.Text = "Close";
			this.CancelButton.Click += CancelButton_Click;
			//
			// this
			//
			this.Text = "Annihilation Special Forces Companion App";
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CancelButton);
		}
		#endregion

		private Button SaveButton;
		private new Button CancelButton;
		private BindingSource BindingSource;
	}
}