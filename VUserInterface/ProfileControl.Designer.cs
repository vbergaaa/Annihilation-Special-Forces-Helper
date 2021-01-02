using System;
using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class ProfileControl
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
			this.components = new System.ComponentModel.Container();
			this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.NameTextBox = new VUserInterface.VTextBox();
			this.RankDropBox = new VUserInterface.CommonControls.VDropBox();
			this.PerkPointsLabel2 = new VLabel();
			this.RankPointsTextBox = new VUserInterface.VTextBox();
			this.ModScoreTextBox = new VUserInterface.VTextBox();
			this.GemsTextBox = new VUserInterface.VTextBox();
			this.CPTextBox = new VUserInterface.VTextBox();
			this.NameLabel = new VUserInterface.CommonControls.VLabel();
			this.RankLabel = new VUserInterface.CommonControls.VLabel();
			this.PerkPointsLabel = new VLabel();
			this.RankPointsLabel = new VUserInterface.CommonControls.VLabel();
			this.ModScoreLabel = new VUserInterface.CommonControls.VLabel();
			this.GemsLabel = new VUserInterface.CommonControls.VLabel();
			this.CPLabel = new VUserInterface.CommonControls.VLabel();
			this.EditPanel = new VUserInterface.CommonControls.DPIPanel();
			this.ReadonlyPanel = new VUserInterface.CommonControls.DPIPanel();
			this.SaveEditButton = new VUserInterface.CommonControls.VButton();
			this.ProfileTitleLabel = new VLabel();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.EditPanel.SuspendLayout();
			this.ReadonlyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BindingSource
			// 
			this.BindingSource.DataSource = typeof(VEntityFramework.Model.VProfile);
			//
			// ProfileTitleLabel
			//
			this.ProfileTitleLabel.Name = "ProfileTitleLabel";
			this.ProfileTitleLabel.Location = DPIScalingHelper.GetScaledPoint(120, 22);
			this.ProfileTitleLabel.Text = "Profile";
			this.ProfileTitleLabel.Font = new System.Drawing.Font(this.ProfileTitleLabel.Font.FontFamily, 14);
			// 
			// NameTextBox
			// 
			this.NameTextBox.Caption = "Name:";
			this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Name", true));
			this.NameTextBox.Location = DPIScalingHelper.GetScaledPoint(150, 0);
			this.NameTextBox.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = DPIScalingHelper.GetScaledSize(150, 24);
			this.NameTextBox.TabIndex = 0;
			// 
			// RankDropBox
			// 
			this.RankDropBox.Caption = "Rank:";
			this.RankDropBox.DataBindings.Add("SelectedValue", BindingSource, "Rank");
			this.RankDropBox.List = PlayerRankList;
			this.RankDropBox.Location = DPIScalingHelper.GetScaledPoint(150, 25);
			this.RankDropBox.Name = "RankDropBox";
			this.RankDropBox.SelectedIndex = -1;
			this.RankDropBox.SelectedValueChanged += PlayerRankChanged;
			this.RankDropBox.Size = DPIScalingHelper.GetScaledSize(150, 24);
			this.RankDropBox.TabIndex = 0;
			// 
			// PerkPointsLabel2
			// 
			this.PerkPointsLabel2.Caption = "Perk Points:";
			this.PerkPointsLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "PerkPoints", true));
			this.PerkPointsLabel2.Location = DPIScalingHelper.GetScaledPoint(150, 50);
			this.PerkPointsLabel2.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.PerkPointsLabel2.Name = "PerkPointsLabel2";
			this.PerkPointsLabel2.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.PerkPointsLabel2.TabIndex = 0;
			this.PerkPointsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RankPointsTextBox
			// 
			this.RankPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "RankPoints", true));
			this.RankPointsTextBox.Location = DPIScalingHelper.GetScaledPoint(150, 75);
			this.RankPointsTextBox.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.RankPointsTextBox.Name = "RankPointsTextBox";
			this.RankPointsTextBox.Size = DPIScalingHelper.GetScaledSize(75, 24);
			this.RankPointsTextBox.TabIndex = 0;
			this.RankPointsTextBox.Caption = "Rank Points:";
			// 
			// ModScoreTextBox
			// 
			this.ModScoreTextBox.Caption = "Mod Score:";
			this.ModScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ModScore", true));
			this.ModScoreTextBox.Location = DPIScalingHelper.GetScaledPoint(150, 100);
			this.ModScoreTextBox.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.ModScoreTextBox.Name = "ModScoreTextBox";
			this.ModScoreTextBox.Size = DPIScalingHelper.GetScaledSize(75, 24);
			this.ModScoreTextBox.TabIndex = 0;
			// 
			// GemsTextBox
			// 
			this.GemsTextBox.Caption = "Gems:";
			this.GemsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Gems", true));
			this.GemsTextBox.Location = DPIScalingHelper.GetScaledPoint(150, 125);
			this.GemsTextBox.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.GemsTextBox.Name = "GemsTextBox";
			this.GemsTextBox.Size = DPIScalingHelper.GetScaledSize(75, 24);
			this.GemsTextBox.TabIndex = 0;
			// 
			// CPTextBox
			// 
			this.CPTextBox.Caption = "Challenge Points:";
			this.CPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ChallengePoints", true));
			this.CPTextBox.Location = DPIScalingHelper.GetScaledPoint(150, 150);
			this.CPTextBox.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.CPTextBox.Name = "CPTextBox";
			this.CPTextBox.Size = DPIScalingHelper.GetScaledSize(75, 24);
			this.CPTextBox.TabIndex = 0;
			// 
			// NameLabel
			// 
			this.NameLabel.Caption = "Name:";
			this.NameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Name", true));
			this.NameLabel.Location = DPIScalingHelper.GetScaledPoint(150, 0);
			this.NameLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RankLabel
			// 
			this.RankLabel.Caption = "Rank:";
			this.RankLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Rank", true));
			this.RankLabel.Location = DPIScalingHelper.GetScaledPoint(150, 25);
			this.RankLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.RankLabel.Name = "RankLabel";
			this.RankLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.RankLabel.TabIndex = 0;
			this.RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PerkPointsLabel
			// 
			this.PerkPointsLabel.Caption = "Perk Points:";
			this.PerkPointsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "PerkPoints", true));
			this.PerkPointsLabel.Location = DPIScalingHelper.GetScaledPoint(150, 50);
			this.PerkPointsLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.PerkPointsLabel.Name = "PerkPointsLabel";
			this.PerkPointsLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.PerkPointsLabel.TabIndex = 0;
			this.PerkPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RankPointsLabel
			// 
			this.RankPointsLabel.Caption = "Rank Points:";
			this.RankPointsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "RankPoints", true));
			this.RankPointsLabel.Location = DPIScalingHelper.GetScaledPoint(150, 75);
			this.RankPointsLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.RankPointsLabel.Name = "RankPointsLabel";
			this.RankPointsLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.RankPointsLabel.TabIndex = 0;
			this.RankPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ModScoreLabel
			// 
			this.ModScoreLabel.Caption = "Mod Score:";
			this.ModScoreLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ModScore", true));
			this.ModScoreLabel.Location = DPIScalingHelper.GetScaledPoint(150, 100);
			this.ModScoreLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.ModScoreLabel.Name = "ModScoreLabel";
			this.ModScoreLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.ModScoreLabel.TabIndex = 0;
			this.ModScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GemsLabel
			// 
			this.GemsLabel.Caption = "Gems:";
			this.GemsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Gems", true));
			this.GemsLabel.Location = DPIScalingHelper.GetScaledPoint(150, 125);
			this.GemsLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.GemsLabel.Name = "GemsLabel";
			this.GemsLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.GemsLabel.TabIndex = 0;
			this.GemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CPLabel
			// 
			this.CPLabel.Caption = "Challenge Points:";
			this.CPLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ChallengePoints", true));
			this.CPLabel.Location = DPIScalingHelper.GetScaledPoint(150, 150);
			this.CPLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.CPLabel.Name = "CPLabel";
			this.CPLabel.Size = DPIScalingHelper.GetScaledSize(300, 24);
			this.CPLabel.TabIndex = 0;
			this.CPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EditPanel
			// 
			this.EditPanel.Controls.Add(this.NameTextBox);
			this.EditPanel.Controls.Add(this.RankDropBox);
			this.EditPanel.Controls.Add(this.PerkPointsLabel);
			this.EditPanel.Controls.Add(this.RankPointsTextBox);
			this.EditPanel.Controls.Add(this.ModScoreTextBox);
			this.EditPanel.Controls.Add(this.GemsTextBox);
			this.EditPanel.Controls.Add(this.CPTextBox);
			this.EditPanel.Location = DPIScalingHelper.GetScaledPoint(0, 50);
			this.EditPanel.Name = "EditPanel";
			this.EditPanel.Size = DPIScalingHelper.GetScaledSize(400, 400);
			this.EditPanel.TabIndex = 1;
			this.EditPanel.Visible = false;
			// 
			// ReadonlyPanel
			// 
			this.ReadonlyPanel.Controls.Add(this.NameLabel);
			this.ReadonlyPanel.Controls.Add(this.RankLabel);
			this.ReadonlyPanel.Controls.Add(this.PerkPointsLabel2);
			this.ReadonlyPanel.Controls.Add(this.RankPointsLabel);
			this.ReadonlyPanel.Controls.Add(this.ModScoreLabel);
			this.ReadonlyPanel.Controls.Add(this.GemsLabel);
			this.ReadonlyPanel.Controls.Add(this.CPLabel);
			this.ReadonlyPanel.Location = DPIScalingHelper.GetScaledPoint(0, 60);
			this.ReadonlyPanel.Name = "ReadonlyPanel";
			this.ReadonlyPanel.Size = DPIScalingHelper.GetScaledSize(400, 400);
			this.ReadonlyPanel.TabIndex = 2;
			// 
			// SaveEditButton
			// 
			this.SaveEditButton.Location = DPIScalingHelper.GetScaledPoint(275, 22);
			this.SaveEditButton.Name = "SaveEditButton";
			this.SaveEditButton.Size = DPIScalingHelper.GetScaledSize(75, 23);
			this.SaveEditButton.TabIndex = 0;
			this.SaveEditButton.Text = "Edit";
			this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
			// 
			// ProfileControl
			// 
			this.Controls.Add(this.SaveEditButton);
			this.Controls.Add(this.EditPanel);
			this.Controls.Add(this.ReadonlyPanel);
			this.Controls.Add(this.ProfileTitleLabel);
			this.Name = "ProfileControl";
			this.Size = DPIScalingHelper.GetScaledSize(400, 400);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.EditPanel.ResumeLayout(false);
			this.ReadonlyPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BindingSource BindingSource;
		private Panel EditPanel;
		private Panel ReadonlyPanel;
		private VTextBox NameTextBox;
		private VDropBox RankDropBox;
		private VTextBox RankPointsTextBox;
		private VTextBox ModScoreTextBox;
		private VTextBox GemsTextBox;
		private VTextBox CPTextBox;
		private VLabel NameLabel;
		private VLabel RankLabel;
		private VLabel PerkPointsLabel;
		private VLabel PerkPointsLabel2;
		private VLabel RankPointsLabel;
		private VLabel ModScoreLabel;
		private VLabel GemsLabel;
		private VLabel CPLabel;
		private VButton SaveEditButton;
		private VLabel ProfileTitleLabel;
	}
}
