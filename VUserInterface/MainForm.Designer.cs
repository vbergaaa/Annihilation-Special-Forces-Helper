using System;
using System.ComponentModel;
using VBusiness.Loadouts;
using VBusiness.Souls;
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
			this.SoulsLoadList = new VLoadList();
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
			// SoulsLoadList
			//
			this.SoulsLoadList.BizoType = typeof(Soul);
			this.SoulsLoadList.Location = new System.Drawing.Point(83, 213);
			this.SoulsLoadList.Name = "SoulsListBox";
			this.SoulsLoadList.TabIndex = 0;
			this.SoulsLoadList.Text = "Souls";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 380);
			this.Controls.Add(this.LoadoutsLoadList);
			this.Controls.Add(this.SoulsLoadList);
			this.Name = "MainForm";
			this.Text = "Annihilation Special Forces Companion App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VLoadList LoadoutsLoadList;
		private VLoadList SoulsLoadList;
	}
}