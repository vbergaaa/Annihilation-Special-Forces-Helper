﻿using System.Windows.Forms;
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
			this.LoadoutsLoadList = new VUserInterface.CommonControls.LoadList();
			this.SoulsLoadList = new VUserInterface.CommonControls.LoadList();
			this.TitleLabel = new VUserInterface.CommonControls.VLabel();
			this.LeftPanel = new VUserInterface.CommonControls.DPIPanel();
			this.SoulsButton = new VUserInterface.CommonControls.VButton();
			this.LoadoutsButton = new VUserInterface.CommonControls.VButton();
			this.ProfileButton = new VUserInterface.CommonControls.VButton();
			this.RegistryButton = new VButton();
			this.RightPanel = new VUserInterface.CommonControls.DPIPanel();
			this.ProfilePanel = new VUserInterface.CommonControls.DPIPanel();
			this.RegistryPanel = new DPIPanel();
			this.LoadoutsPanel = new VUserInterface.CommonControls.DPIPanel();
			this.SoulsPanel = new VUserInterface.CommonControls.DPIPanel();
			this.SoulCollectionButton = new VButton();
			this.ProfileControl = new ProfileControl();
			this.RegistryControl = new RegistryControl();
			this.LeftPanel.SuspendLayout();
			this.RightPanel.SuspendLayout();
			this.LoadoutsPanel.SuspendLayout();
			this.SoulsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LoadoutsLoadList
			// 
			this.LoadoutsLoadList.BizoType = typeof(VBusiness.Loadouts.Loadout);
			this.LoadoutsLoadList.Location = DPIScalingHelper.GetScaledPoint(50, 30);
			this.LoadoutsLoadList.Name = "LoadoutsLoadList";
			this.LoadoutsLoadList.Size = DPIScalingHelper.GetScaledSize(330, 160);
			this.LoadoutsLoadList.TabIndex = 0;
			this.LoadoutsLoadList.Text = "Loadouts";
			// 
			// SoulsLoadList
			// 
			this.SoulsLoadList.BizoType = typeof(VBusiness.Souls.Soul);
			this.SoulsLoadList.Location = DPIScalingHelper.GetScaledPoint(50, 30);
			this.SoulsLoadList.Name = "SoulsLoadList";
			this.SoulsLoadList.Size = DPIScalingHelper.GetScaledSize(330, 160);
			this.SoulsLoadList.TabIndex = 0;
			this.SoulsLoadList.Text = "Souls";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleLabel.Location = DPIScalingHelper.GetScaledPoint(1, 5);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = DPIScalingHelper.GetScaledSize(598, 30);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Annihilation Special Forces Companion Application";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LeftPanel
			// 
			this.LeftPanel.Controls.Add(this.SoulsButton);
			this.LeftPanel.Controls.Add(this.LoadoutsButton);
			this.LeftPanel.Controls.Add(this.ProfileButton);
			this.LeftPanel.Controls.Add(this.RegistryButton);
			this.LeftPanel.Controls.Add(this.SoulCollectionButton);
			this.LeftPanel.Location = DPIScalingHelper.GetScaledPoint(0, 35);
			this.LeftPanel.Name = "LeftPanel";
			this.LeftPanel.Size = DPIScalingHelper.GetScaledSize(200, 400);
			this.LeftPanel.TabIndex = 0;
			// 
			// SoulsButton
			// 
			this.SoulsButton.Location = DPIScalingHelper.GetScaledPoint(12, 133);
			this.SoulsButton.Name = "SoulsButton";
			this.SoulsButton.Size = DPIScalingHelper.GetScaledSize(182, 31);
			this.SoulsButton.TabIndex = 2;
			this.SoulsButton.Text = "Souls";
			this.SoulsButton.UseVisualStyleBackColor = true;
			this.SoulsButton.Click += new System.EventHandler(this.SoulsButton_Click);
			// 
			// LoadoutsButton
			// 
			this.LoadoutsButton.Location = DPIScalingHelper.GetScaledPoint(12, 96);
			this.LoadoutsButton.Name = "LoadoutsButton";
			this.LoadoutsButton.Size = DPIScalingHelper.GetScaledSize(182, 31);
			this.LoadoutsButton.TabIndex = 1;
			this.LoadoutsButton.Text = "Loadouts";
			this.LoadoutsButton.UseVisualStyleBackColor = true;
			this.LoadoutsButton.Click += new System.EventHandler(this.LoadoutsButton_Click);
			// 
			// SoulCollectionButton
			// 
			this.SoulCollectionButton.Location = DPIScalingHelper.GetScaledPoint(12, 170);
			this.SoulCollectionButton.Name = "SoulCollectionButton";
			this.SoulCollectionButton.Size = DPIScalingHelper.GetScaledSize(182, 31);
			this.SoulCollectionButton.TabIndex = 1;
			this.SoulCollectionButton.Text = "Soul Collection";
			this.SoulCollectionButton.UseVisualStyleBackColor = true;
			this.SoulCollectionButton.Click += new System.EventHandler(this.SoulCollectionButton_Click);
			// 
			// ProfileButton
			// 
			this.ProfileButton.Location = DPIScalingHelper.GetScaledPoint(12, 59);
			this.ProfileButton.Name = "ProfileButton";
			this.ProfileButton.Size = DPIScalingHelper.GetScaledSize(182, 31);
			this.ProfileButton.TabIndex = 0;
			this.ProfileButton.Text = "Profile";
			this.ProfileButton.UseVisualStyleBackColor = true;
			this.ProfileButton.Visible = true;
			this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
			// 
			// RegistryButton
			// 
			this.RegistryButton.Location = DPIScalingHelper.GetScaledPoint(12, 207);
			this.RegistryButton.Name = "RegistryButton";
			this.RegistryButton.Size = DPIScalingHelper.GetScaledSize(182, 31);
			this.RegistryButton.TabIndex = 0;
			this.RegistryButton.Text = "Settings";
			this.RegistryButton.UseVisualStyleBackColor = true;
			this.RegistryButton.Visible = true;
			this.RegistryButton.Click += new System.EventHandler(this.RegistryButton_Click);
			// 
			// RightPanel
			// 
			this.RightPanel.Controls.Add(this.ProfilePanel);
			this.RightPanel.Controls.Add(this.LoadoutsPanel);
			this.RightPanel.Controls.Add(this.SoulsPanel);
			this.RightPanel.Controls.Add(this.RegistryPanel);
			this.RightPanel.Location = DPIScalingHelper.GetScaledPoint(200, 35);
			this.RightPanel.Name = "RightPanel";
			this.RightPanel.Size = DPIScalingHelper.GetScaledSize(450, 400);
			this.RightPanel.TabIndex = 1;
			// 
			// ProfilePanel
			// 
			this.ProfilePanel.Controls.Add(this.ProfileControl);
			this.ProfilePanel.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.ProfilePanel.Name = "ProfilePanel";
			this.ProfilePanel.Size = DPIScalingHelper.GetScaledSize(450, 400);
			this.ProfilePanel.TabIndex = 1;
			this.ProfilePanel.Visible = true;
			// 
			// LoadoutsPanel
			// 
			this.LoadoutsPanel.Controls.Add(this.LoadoutsLoadList);
			this.LoadoutsPanel.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.LoadoutsPanel.Name = "LoadoutsPanel";
			this.LoadoutsPanel.Size = DPIScalingHelper.GetScaledSize(450, 400);
			this.LoadoutsPanel.TabIndex = 1;
			this.LoadoutsPanel.Visible = false;
			// 
			// SoulsPanel
			// 
			this.SoulsPanel.Controls.Add(this.SoulsLoadList);
			this.SoulsPanel.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.SoulsPanel.Name = "SoulsPanel";
			this.SoulsPanel.Size = DPIScalingHelper.GetScaledSize(450, 400);
			this.SoulsPanel.TabIndex = 1;
			this.SoulsPanel.Visible = false;
			// 
			// RegistryPanel
			// 
			this.RegistryPanel.Controls.Add(this.RegistryControl);
			this.RegistryPanel.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.RegistryPanel.Name = "RegistryPanel";
			this.RegistryPanel.Size = DPIScalingHelper.GetScaledSize(450, 400);
			this.RegistryPanel.TabIndex = 1;
			this.RegistryPanel.Visible = false;
			//
			// ProfileControl
			//
			this.ProfileControl.Name = "ProfileControl";
			this.ProfileControl.Size = DPIScalingHelper.GetScaledSize(350, 300);
			this.ProfileControl.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			//
			// RegistryControl
			//
			this.RegistryControl.Name = "RegistryControl";
			this.RegistryControl.Size = DPIScalingHelper.GetScaledSize(350, 300);
			this.RegistryControl.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = DPIScalingHelper.GetScaledSize(600, 300);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.LeftPanel);
			this.Controls.Add(this.RightPanel);
			this.Icon = Properties.Resources.asflogo;
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
		private Panel RegistryPanel;
		private Panel LoadoutsPanel;
		private Panel SoulsPanel;
		private LoadList LoadoutsLoadList;
		private LoadList SoulsLoadList;
		private ProfileControl ProfileControl;
		private RegistryControl RegistryControl;
		private VLabel TitleLabel;
		private VButton SoulsButton;
		private VButton LoadoutsButton;
		private VButton ProfileButton;
		private VButton SoulCollectionButton;
		private VButton RegistryButton;
	}
}