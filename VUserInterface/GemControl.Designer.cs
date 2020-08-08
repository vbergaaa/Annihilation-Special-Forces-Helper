using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	partial class GemControl
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
			this.CostCaption = new System.Windows.Forms.Label();
			this.CostLabel = new System.Windows.Forms.Label();
			this.CurrentLevelLabel = new System.Windows.Forms.Label();
			this.CurrentLevelCaption = new Label();
			this.IncrementCurrentButton = new System.Windows.Forms.Button();
			this.DecrementCurrentButton = new System.Windows.Forms.Button();
			this.gemBindingSource = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.gemBindingSource)).BeginInit();
			// 
			// CostCaption
			// 
			this.CostCaption.Location = new System.Drawing.Point(5, 50);
			this.CostCaption.Name = "CostCaption";
			this.CostCaption.Size = new System.Drawing.Size(110, 23);
			this.CostCaption.TabIndex = 6;
			this.CostCaption.Text = "Next Lvl Cost:";
			this.CostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CostLabel
			// 
			this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gemBindingSource, "NextLevelCost"));
			this.CostLabel.Location = new System.Drawing.Point(116, 50);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = new System.Drawing.Size(40, 23);
			this.CostLabel.TabIndex = 6;
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
			this.CurrentLevelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gemBindingSource, "CurrentLevel"));
			this.CurrentLevelLabel.Location = new System.Drawing.Point(67, 21);
			this.CurrentLevelLabel.Name = "CurrentLevelLabel";
			this.CurrentLevelLabel.Size = new System.Drawing.Size(23, 23);
			this.CurrentLevelLabel.TabIndex = 2;
			this.CurrentLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IncrementCurrentButton
			// 
			this.IncrementCurrentButton.Click += IncrementCurrentButton_Click;
			this.IncrementCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncrementCurrentButton.Location = new System.Drawing.Point(96, 20);
			this.IncrementCurrentButton.Name = "IncrementCurrentButton";
			this.IncrementCurrentButton.Size = new System.Drawing.Size(23, 23);
			this.IncrementCurrentButton.TabIndex = 5;
			this.IncrementCurrentButton.Text = "+";
			// 
			// DecrementCurrentButton
			// 
			this.DecrementCurrentButton.Click += DecrementCurrentButton_Click;
			this.DecrementCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementCurrentButton.Location = new System.Drawing.Point(38, 20);
			this.DecrementCurrentButton.Name = "DecrementCurrentButton";
			this.DecrementCurrentButton.Size = new System.Drawing.Size(23, 23);
			this.DecrementCurrentButton.TabIndex = 4;
			this.DecrementCurrentButton.Text = "-";
			// 
			// perkBindingSource
			// 
			this.gemBindingSource.DataSource = typeof(VGem);
			// 
			// VPerkControl
			// 
			this.Controls.Add(this.CostLabel);
			this.Controls.Add(this.CostCaption);
			this.Controls.Add(this.CurrentLevelLabel);
			this.Controls.Add(this.IncrementCurrentButton);
			this.Controls.Add(this.DecrementCurrentButton);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gemBindingSource, "Name"));
			this.Size = new System.Drawing.Size(160, 75);
			((System.ComponentModel.ISupportInitialize)(this.gemBindingSource)).EndInit();
		}

		#endregion

		private BindingSource gemBindingSource;
		private Label CostCaption;
		private Label CostLabel;
		private Label CurrentLevelCaption;
		private Label CurrentLevelLabel;
		private Button DecrementCurrentButton;
		private Button IncrementCurrentButton;
	}
}
