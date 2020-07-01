using System.Reflection.Emit;
using System.Windows.Forms.VisualStyles;
using VBusiness.Perks;
using VModel;

namespace ASF_Planner
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
			this.DesiredLevelLabel = new System.Windows.Forms.Label();
			this.IncrementButton = new System.Windows.Forms.Button();
			this.DecrementButton = new System.Windows.Forms.Button();
			this.CostLabel = new System.Windows.Forms.Label();
			this.perkBindingSource = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.perkBindingSource)).BeginInit();
			//
			// DesiredLevelTextBox
			//
			this.DesiredLevelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "DesiredLevel"));
			this.DesiredLevelLabel.DataBindings.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
			this.DesiredLevelLabel.Location = new System.Drawing.Point(69, 20);
			this.DesiredLevelLabel.Name = "DesiredLevelTextBox";
			this.DesiredLevelLabel.Size = new System.Drawing.Size(23, 23);
			this.DesiredLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// DecrementButton
			//
			this.DecrementButton.Click += DecrementButton_Click;
			this.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementButton.Location = new System.Drawing.Point(45, 20);
			this.DecrementButton.Name = "DecrementButton";
			this.DecrementButton.Size = new System.Drawing.Size(23, 23);
			this.DecrementButton.Text = "-";
			this.DecrementButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// IncrementButton
			//
			this.IncrementButton.Click += IncrementButton_Click;
			this.IncrementButton.Location = new System.Drawing.Point(93, 20);
			this.IncrementButton.Name = "IncrementButton";
			this.IncrementButton.Size = new System.Drawing.Size(23, 23);
			this.IncrementButton.Text = "+";
			this.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// CostLabel
			//
			this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "Cost"));
			this.CostLabel.Location = new System.Drawing.Point(1, 45);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = new System.Drawing.Size(161, 14);
			this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// perkBindingSource
			// 
			this.perkBindingSource.DataSource = typeof(VPerk);
			//
			// VPerkControl
			//
			this.Controls.Add(DesiredLevelLabel);
			this.Controls.Add(DecrementButton);
			this.Controls.Add(IncrementButton);
			this.Controls.Add(CostLabel);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perkBindingSource, "Name"));
			this.Size = new System.Drawing.Size(163, 67);
			((System.ComponentModel.ISupportInitialize)(this.perkBindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.Label DesiredLevelLabel;
		private System.Windows.Forms.Button DecrementButton;
		private System.Windows.Forms.Button IncrementButton;
		private System.Windows.Forms.Label CostLabel;
		private System.Windows.Forms.BindingSource perkBindingSource;
	}
}
