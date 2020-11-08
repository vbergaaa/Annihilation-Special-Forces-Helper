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
			this.RankPointsTextBox = new VUserInterface.VTextBox();
			this.ModScoreTextBox = new VUserInterface.VTextBox();
			this.GemsTextBox = new VUserInterface.VTextBox();
			this.CPTextBox = new VUserInterface.VTextBox();
			this.NameLabel = new VUserInterface.CommonControls.VLabel();
			this.RankLabel = new VUserInterface.CommonControls.VLabel();
			this.RankPointsLabel = new VUserInterface.CommonControls.VLabel();
			this.ModScoreLabel = new VUserInterface.CommonControls.VLabel();
			this.GemsLabel = new VUserInterface.CommonControls.VLabel();
			this.CPLabel = new VUserInterface.CommonControls.VLabel();
			this.EditPanel = new System.Windows.Forms.Panel();
			this.ReadonlyPanel = new System.Windows.Forms.Panel();
			this.SaveEditButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.EditPanel.SuspendLayout();
			this.ReadonlyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BindingSource
			// 
			this.BindingSource.DataSource = typeof(VEntityFramework.Model.VProfile);
			// 
			// NameTextBox
			// 
			this.NameTextBox.Caption = "Name:";
			this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSource, "Name", true));
			this.NameTextBox.Location = new System.Drawing.Point(133, 28);
			this.NameTextBox.MaximumSize = new System.Drawing.Size(500, 29);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(300, 24);
			this.NameTextBox.TabIndex = 0;
			this.NameTextBox.Value = null;
			// 
			// RankDropBox
			// 
			this.RankDropBox.Caption = "Rank:";
			this.RankDropBox.List = null;
			this.RankDropBox.Location = new System.Drawing.Point(139, 58);
			this.RankDropBox.MaximumSize = new System.Drawing.Size(500, 29);
			this.RankDropBox.Name = "RankDropBox";
			this.RankDropBox.SelectedIndex = -1;
			this.RankDropBox.Size = new System.Drawing.Size(300, 24);
			this.RankDropBox.TabIndex = 0;
			// 
			// RankPointsTextBox
			// 
			this.RankPointsTextBox.Caption = "Rank Points:";
			this.RankPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSource, "RankPoints", true));
			this.RankPointsTextBox.Location = new System.Drawing.Point(103, 88);
			this.RankPointsTextBox.MaximumSize = new System.Drawing.Size(500, 29);
			this.RankPointsTextBox.Name = "RankPointsTextBox";
			this.RankPointsTextBox.Size = new System.Drawing.Size(300, 24);
			this.RankPointsTextBox.TabIndex = 0;
			this.RankPointsTextBox.Value = null;
			// 
			// ModScoreTextBox
			// 
			this.ModScoreTextBox.Caption = "Mod Score:";
			this.ModScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSource, "ModScore", true));
			this.ModScoreTextBox.Location = new System.Drawing.Point(108, 118);
			this.ModScoreTextBox.MaximumSize = new System.Drawing.Size(500, 29);
			this.ModScoreTextBox.Name = "ModScoreTextBox";
			this.ModScoreTextBox.Size = new System.Drawing.Size(300, 24);
			this.ModScoreTextBox.TabIndex = 0;
			this.ModScoreTextBox.Value = null;
			// 
			// GemsTextBox
			// 
			this.GemsTextBox.Caption = "Gems:";
			this.GemsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSource, "Gems", true));
			this.GemsTextBox.Location = new System.Drawing.Point(135, 148);
			this.GemsTextBox.MaximumSize = new System.Drawing.Size(500, 29);
			this.GemsTextBox.Name = "GemsTextBox";
			this.GemsTextBox.Size = new System.Drawing.Size(300, 24);
			this.GemsTextBox.TabIndex = 0;
			this.GemsTextBox.Value = null;
			// 
			// CPTextBox
			// 
			this.CPTextBox.Caption = "Challenge Points:";
			this.CPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BindingSource, "ChallengePoints", true));
			this.CPTextBox.Location = new System.Drawing.Point(76, 178);
			this.CPTextBox.MaximumSize = new System.Drawing.Size(500, 29);
			this.CPTextBox.Name = "CPTextBox";
			this.CPTextBox.Size = new System.Drawing.Size(300, 24);
			this.CPTextBox.TabIndex = 0;
			this.CPTextBox.Value = null;
			// 
			// NameLabel
			// 
			this.NameLabel.Caption = "Name:";
			this.NameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Name", true));
			this.NameLabel.Location = new System.Drawing.Point(133, 28);
			this.NameLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(300, 24);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RankLabel
			// 
			this.RankLabel.Caption = "Rank:";
			this.RankLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Rank", true));
			this.RankLabel.Location = new System.Drawing.Point(139, 58);
			this.RankLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.RankLabel.Name = "RankLabel";
			this.RankLabel.Size = new System.Drawing.Size(300, 24);
			this.RankLabel.TabIndex = 0;
			this.RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RankPointsLabel
			// 
			this.RankPointsLabel.Caption = "Rank Points:";
			this.RankPointsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "RankPoints", true));
			this.RankPointsLabel.Location = new System.Drawing.Point(103, 88);
			this.RankPointsLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.RankPointsLabel.Name = "RankPointsLabel";
			this.RankPointsLabel.Size = new System.Drawing.Size(300, 24);
			this.RankPointsLabel.TabIndex = 0;
			this.RankPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ModScoreLabel
			// 
			this.ModScoreLabel.Caption = "Mod Score:";
			this.ModScoreLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ModScore", true));
			this.ModScoreLabel.Location = new System.Drawing.Point(108, 118);
			this.ModScoreLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.ModScoreLabel.Name = "ModScoreLabel";
			this.ModScoreLabel.Size = new System.Drawing.Size(300, 24);
			this.ModScoreLabel.TabIndex = 0;
			this.ModScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GemsLabel
			// 
			this.GemsLabel.Caption = "Gems:";
			this.GemsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "Gems", true));
			this.GemsLabel.Location = new System.Drawing.Point(135, 148);
			this.GemsLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.GemsLabel.Name = "GemsLabel";
			this.GemsLabel.Size = new System.Drawing.Size(300, 24);
			this.GemsLabel.TabIndex = 0;
			this.GemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CPLabel
			// 
			this.CPLabel.Caption = "Challenge Points:";
			this.CPLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "ChallengePoints", true));
			this.CPLabel.Location = new System.Drawing.Point(76, 178);
			this.CPLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.CPLabel.Name = "CPLabel";
			this.CPLabel.Size = new System.Drawing.Size(300, 24);
			this.CPLabel.TabIndex = 0;
			this.CPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EditPanel
			// 
			this.EditPanel.Controls.Add(this.NameTextBox);
			this.EditPanel.Controls.Add(this.RankDropBox);
			this.EditPanel.Controls.Add(this.RankPointsTextBox);
			this.EditPanel.Controls.Add(this.ModScoreTextBox);
			this.EditPanel.Controls.Add(this.GemsTextBox);
			this.EditPanel.Controls.Add(this.CPTextBox);
			this.EditPanel.Location = new System.Drawing.Point(0, 30);
			this.EditPanel.Name = "EditPanel";
			this.EditPanel.Size = new System.Drawing.Size(400, 400);
			this.EditPanel.TabIndex = 1;
			this.EditPanel.Visible = false;
			// 
			// ReadonlyPanel
			// 
			this.ReadonlyPanel.Controls.Add(this.NameLabel);
			this.ReadonlyPanel.Controls.Add(this.RankLabel);
			this.ReadonlyPanel.Controls.Add(this.RankPointsLabel);
			this.ReadonlyPanel.Controls.Add(this.ModScoreLabel);
			this.ReadonlyPanel.Controls.Add(this.GemsLabel);
			this.ReadonlyPanel.Controls.Add(this.CPLabel);
			this.ReadonlyPanel.Location = new System.Drawing.Point(0, 30);
			this.ReadonlyPanel.Name = "ReadonlyPanel";
			this.ReadonlyPanel.Size = new System.Drawing.Size(400, 400);
			this.ReadonlyPanel.TabIndex = 2;
			// 
			// SaveEditButton
			// 
			this.SaveEditButton.Location = new System.Drawing.Point(275, 22);
			this.SaveEditButton.Name = "SaveEditButton";
			this.SaveEditButton.Size = new System.Drawing.Size(75, 23);
			this.SaveEditButton.TabIndex = 0;
			this.SaveEditButton.Text = "Edit";
			this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
			// 
			// ProfileControl
			// 
			this.Controls.Add(this.SaveEditButton);
			this.Controls.Add(this.EditPanel);
			this.Controls.Add(this.ReadonlyPanel);
			this.Name = "ProfileControl";
			this.Size = new System.Drawing.Size(400, 400);
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
		private VLabel RankPointsLabel;
		private VLabel ModScoreLabel;
		private VLabel GemsLabel;
		private VLabel CPLabel;
		private Button SaveEditButton;
	}
}
