using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
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
			this.LoadoutsLoadList = new VUserInterface.CommonControls.VLoadList();
			this.SoulsLoadList = new VUserInterface.CommonControls.VLoadList();
			this.TitleLabel = new VUserInterface.CommonControls.VLabel();
			this.LeftPanel = new System.Windows.Forms.Panel();
			this.SoulsButton = new System.Windows.Forms.Button();
			this.LoadoutsButton = new System.Windows.Forms.Button();
			this.ProfileButton = new System.Windows.Forms.Button();
			this.RightPanel = new System.Windows.Forms.Panel();
			this.ProfilePanel = new System.Windows.Forms.Panel();
			this.LoadoutsPanel = new System.Windows.Forms.Panel();
			this.SoulsPanel = new System.Windows.Forms.Panel();
			this.ProfileControl = new ProfileControl();
			this.LeftPanel.SuspendLayout();
			this.RightPanel.SuspendLayout();
			this.LoadoutsPanel.SuspendLayout();
			this.SoulsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LoadoutsLoadList
			// 
			this.LoadoutsLoadList.BizoType = typeof(VBusiness.Loadouts.Loadout);
			this.LoadoutsLoadList.Location = new System.Drawing.Point(50, 30);
			this.LoadoutsLoadList.Name = "LoadoutsLoadList";
			this.LoadoutsLoadList.Size = new System.Drawing.Size(280, 160);
			this.LoadoutsLoadList.TabIndex = 0;
			this.LoadoutsLoadList.Text = "Loadouts";
			// 
			// SoulsLoadList
			// 
			this.SoulsLoadList.BizoType = typeof(VBusiness.Souls.Soul);
			this.SoulsLoadList.Location = new System.Drawing.Point(50, 30);
			this.SoulsLoadList.Name = "SoulsLoadList";
			this.SoulsLoadList.Size = new System.Drawing.Size(280, 160);
			this.SoulsLoadList.TabIndex = 0;
			this.SoulsLoadList.Text = "Souls";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleLabel.Location = new System.Drawing.Point(1, 5);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(598, 30);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Annihilation Special Forces Companion Application";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LeftPanel
			// 
			this.LeftPanel.Controls.Add(this.SoulsButton);
			this.LeftPanel.Controls.Add(this.LoadoutsButton);
			this.LeftPanel.Controls.Add(this.ProfileButton);
			this.LeftPanel.Location = new System.Drawing.Point(0, 35);
			this.LeftPanel.Name = "LeftPanel";
			this.LeftPanel.Size = new System.Drawing.Size(200, 400);
			this.LeftPanel.TabIndex = 0;
			// 
			// SoulsButton
			// 
			this.SoulsButton.Location = new System.Drawing.Point(12, 133);
			this.SoulsButton.Name = "SoulsButton";
			this.SoulsButton.Size = new System.Drawing.Size(182, 31);
			this.SoulsButton.TabIndex = 2;
			this.SoulsButton.Text = "Souls";
			this.SoulsButton.UseVisualStyleBackColor = true;
			this.SoulsButton.Click += new System.EventHandler(this.SoulsButton_Click);
			// 
			// LoadoutsButton
			// 
			this.LoadoutsButton.Location = new System.Drawing.Point(12, 96);
			this.LoadoutsButton.Name = "LoadoutsButton";
			this.LoadoutsButton.Size = new System.Drawing.Size(182, 31);
			this.LoadoutsButton.TabIndex = 1;
			this.LoadoutsButton.Text = "Loadouts";
			this.LoadoutsButton.UseVisualStyleBackColor = true;
			this.LoadoutsButton.Click += new System.EventHandler(this.LoadoutsButton_Click);
			// 
			// ProfileButton
			// 
			this.ProfileButton.Location = new System.Drawing.Point(12, 59);
			this.ProfileButton.Name = "ProfileButton";
			this.ProfileButton.Size = new System.Drawing.Size(182, 31);
			this.ProfileButton.TabIndex = 0;
			this.ProfileButton.Text = "Profile";
			this.ProfileButton.UseVisualStyleBackColor = true;
			this.ProfileButton.Visible = true;
			this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
			// 
			// RightPanel
			// 
			this.RightPanel.Controls.Add(this.ProfilePanel);
			this.RightPanel.Controls.Add(this.LoadoutsPanel);
			this.RightPanel.Controls.Add(this.SoulsPanel);
			this.RightPanel.Location = new System.Drawing.Point(200, 35);
			this.RightPanel.Name = "RightPanel";
			this.RightPanel.Size = new System.Drawing.Size(450, 400);
			this.RightPanel.TabIndex = 1;
			// 
			// ProfilePanel
			// 
			this.ProfilePanel.Controls.Add(this.ProfileControl);
			this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
			this.ProfilePanel.Name = "ProfilePanel";
			this.ProfilePanel.Size = new System.Drawing.Size(450, 400);
			this.ProfilePanel.TabIndex = 1;
			this.ProfilePanel.Visible = true;
			// 
			// LoadoutsPanel
			// 
			this.LoadoutsPanel.Controls.Add(this.LoadoutsLoadList);
			this.LoadoutsPanel.Location = new System.Drawing.Point(0, 0);
			this.LoadoutsPanel.Name = "LoadoutsPanel";
			this.LoadoutsPanel.Size = new System.Drawing.Size(450, 400);
			this.LoadoutsPanel.TabIndex = 1;
			this.LoadoutsPanel.Visible = false;
			// 
			// SoulsPanel
			// 
			this.SoulsPanel.Controls.Add(this.SoulsLoadList);
			this.SoulsPanel.Location = new System.Drawing.Point(0, 0);
			this.SoulsPanel.Name = "SoulsPanel";
			this.SoulsPanel.Size = new System.Drawing.Size(450, 400);
			this.SoulsPanel.TabIndex = 1;
			this.SoulsPanel.Visible = false;
			//
			// ProfileControl
			//
			this.ProfileControl.Name = "ProfileControl";
			this.ProfileControl.Size = new Size(350, 300);
			this.ProfileControl.Location = new Point(0, 0);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 300);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.LeftPanel);
			this.Controls.Add(this.RightPanel);
			this.Name = "MainForm";
			this.Text = "Annihilation Special Forces Companion App";
			this.LeftPanel.ResumeLayout(false);
			this.RightPanel.ResumeLayout(false);
			this.LoadoutsPanel.ResumeLayout(false);
			this.SoulsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel LeftPanel;
		private Panel RightPanel;
		private Panel ProfilePanel;
		private Panel LoadoutsPanel;
		private Panel SoulsPanel;
		private VLoadList LoadoutsLoadList;
		private VLoadList SoulsLoadList;
		private ProfileControl ProfileControl;
		private VLabel TitleLabel;
		private Button SoulsButton;
		private Button LoadoutsButton;
		private Button ProfileButton;
	}
}