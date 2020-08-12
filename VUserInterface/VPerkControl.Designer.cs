using System.Reflection.Emit;
using System.Windows.Forms.VisualStyles;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Model;

namespace VUserInterface
{
	partial class VPerkControl
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
			components = new System.ComponentModel.Container();
			this.CostLabel = new System.Windows.Forms.Label();
			this.CurrentLevelCaption = new System.Windows.Forms.Label();
			this.CurrentLevelLabel = new System.Windows.Forms.Label();
			this.DecrementDesiredButton = new System.Windows.Forms.Button();
			this.DesiredLevelCaption = new System.Windows.Forms.Label();
			this.DesiredLevelLabel = new System.Windows.Forms.Label();
			this.IncrementCurrentButton = new System.Windows.Forms.Button();
			this.DecrementCurrentButton = new System.Windows.Forms.Button();
			this.IncrementDesiredButton = new System.Windows.Forms.Button();
			this.CostCaption = new System.Windows.Forms.Label();
			this.perkBindingSource = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.perkBindingSource)).BeginInit();
			// 
			// CostCaption
			// 
			this.CostCaption.Location = new System.Drawing.Point(10, 69);
			this.CostCaption.Name = "CostCaption";
			this.CostCaption.Size = new System.Drawing.Size(50, 23);
			this.CostCaption.TabIndex = 6;
			this.CostCaption.Text = "Cost";
			this.CostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CostLabel
			// 
			this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "RemainingCost"));
			this.CostLabel.Location = new System.Drawing.Point(80, 69);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = new System.Drawing.Size(50, 23);
			this.CostLabel.TabIndex = 6;
			this.CostLabel.Text = "aoeu";
			this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CurrentLevelCaption
			// 
			this.CurrentLevelCaption.Location = new System.Drawing.Point(1, 17);
			this.CurrentLevelCaption.Name = "CurrentLevelCaption";
			this.CurrentLevelCaption.Size = new System.Drawing.Size(70, 23);
			this.CurrentLevelCaption.TabIndex = 3;
			this.CurrentLevelCaption.Text = "Current:";
			this.CurrentLevelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CurrentLevelLabel
			// 
			this.CurrentLevelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "CurrentLevel"));
			this.CurrentLevelLabel.Location = new System.Drawing.Point(91 , 18);
			this.CurrentLevelLabel.Name = "CurrentLevelLabel";
			this.CurrentLevelLabel.Size = new System.Drawing.Size(23, 23);
			this.CurrentLevelLabel.TabIndex = 2;
			this.CurrentLevelLabel.Text = "aoeu";
			this.CurrentLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DecrementDesiredButton
			// 
			this.DecrementDesiredButton.Click += DecrementDesiredButton_Click;
			this.DecrementDesiredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementDesiredButton.Location = new System.Drawing.Point(60, 41);
			this.DecrementDesiredButton.Name = "DecrementDesiredButton";
			this.DecrementDesiredButton.Size = new System.Drawing.Size(27, 27);
			this.DecrementDesiredButton.TabIndex = 4;
			this.DecrementDesiredButton.Text = "-";
			// 
			// DesiredLevelCaption
			// 
			this.DesiredLevelCaption.Location = new System.Drawing.Point(1, 43);
			this.DesiredLevelCaption.Name = "DesiredLevelCaption";
			this.DesiredLevelCaption.Size = new System.Drawing.Size(70, 23);
			this.DesiredLevelCaption.TabIndex = 1;
			this.DesiredLevelCaption.Text = "Desired:";
			this.DesiredLevelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DesiredLevelLabel
			// 
			this.DesiredLevelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "DesiredLevel"));
			this.DesiredLevelLabel.Location = new System.Drawing.Point(91, 43);
			this.DesiredLevelLabel.Name = "DesiredLevelLabel";
			this.DesiredLevelLabel.Size = new System.Drawing.Size(23, 23);
			this.DesiredLevelLabel.TabIndex = 0;
			this.DesiredLevelLabel.Text = "aoeu";
			this.DesiredLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IncrementCurrentButton
			// 
			this.IncrementCurrentButton.Click += IncrementCurrentButton_Click;
			this.IncrementCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncrementCurrentButton.Location = new System.Drawing.Point(120, 17);
			this.IncrementCurrentButton.Name = "IncrementCurrentButton";
			this.IncrementCurrentButton.Size = new System.Drawing.Size(23, 23);
			this.IncrementCurrentButton.TabIndex = 5;
			this.IncrementCurrentButton.Text = "+";
			// 
			// DecrementCurrentButton
			// 
			this.DecrementCurrentButton.Click += DecrementCurrentButton_Click;
			this.DecrementCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementCurrentButton.Location = new System.Drawing.Point(62, 17);
			this.DecrementCurrentButton.Name = "DecrementCurrentButton";
			this.DecrementCurrentButton.Size = new System.Drawing.Size(23, 23);
			this.DecrementCurrentButton.TabIndex = 4;
			this.DecrementCurrentButton.Text = "-";
			// 
			// IncrementDesiredButton
			// 
			this.IncrementDesiredButton.Click += IncrementDesiredButton_Click;
			this.IncrementDesiredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncrementDesiredButton.Location = new System.Drawing.Point(118, 41);
			this.IncrementDesiredButton.Name = "IncrementDesiredButton";
			this.IncrementDesiredButton.Size = new System.Drawing.Size(27, 27);
			this.IncrementDesiredButton.TabIndex = 5;
			this.IncrementDesiredButton.Text = "+";
			// 
			// perkBindingSource
			// 
			this.perkBindingSource.DataSource = typeof(VPerk);
			// 
			// VPerkControl
			// 
			this.Controls.Add(this.CostLabel);
			this.Controls.Add(this.IncrementDesiredButton);
			this.Controls.Add(this.DesiredLevelLabel);
			this.Controls.Add(this.DecrementDesiredButton);
			this.Controls.Add(this.CostCaption);
			this.Controls.Add(this.DesiredLevelCaption);
			this.Controls.Add(this.CurrentLevelLabel);
			this.Controls.Add(this.IncrementCurrentButton);
			this.Controls.Add(this.DecrementCurrentButton);
			this.Controls.Add(this.CurrentLevelCaption);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "Name"));
			this.Size = new System.Drawing.Size(160, 100);
			((System.ComponentModel.ISupportInitialize)(this.perkBindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.Label CostLabel;
		private System.Windows.Forms.Label CurrentLevelCaption;
		private System.Windows.Forms.Label CurrentLevelLabel;
		private System.Windows.Forms.Button DecrementDesiredButton;
		private System.Windows.Forms.Label DesiredLevelCaption;
		private System.Windows.Forms.Label DesiredLevelLabel;
		private System.Windows.Forms.Button IncrementCurrentButton;
		private System.Windows.Forms.BindingSource perkBindingSource;
		private System.Windows.Forms.Button DecrementCurrentButton;
		private System.Windows.Forms.Button IncrementDesiredButton;
		private System.Windows.Forms.Label CostCaption;
	}
}
