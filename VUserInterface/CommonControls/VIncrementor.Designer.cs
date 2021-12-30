using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	partial class VIncrementor
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
			this.DecrementButton = new VUserInterface.CommonControls.VButton();
			this.IncrementButton = new VUserInterface.CommonControls.VButton();
			this.IncrementToolTip = new ToolTip();
			this.DecrementToolTip = new ToolTip();
			this.ValueLabel = new VUserInterface.CommonControls.VLabel();
			this.SuspendLayout();
			// 
			// DecrementButton
			// 
			this.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementButton.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.DecrementButton.Name = "DecrementButton";
			this.DecrementButton.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.DecrementButton.TabIndex = 1;
			this.DecrementButton.Text = "-";
			this.DecrementButton.Click += new System.EventHandler(this.DecrementButton_Click);
			// 
			// IncrementButton
			// 
			this.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncrementButton.Location = DPIScalingHelper.GetScaledPoint(80, 0);
			this.IncrementButton.Name = "IncrementButton";
			this.IncrementButton.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.IncrementButton.TabIndex = 2;
			this.IncrementButton.Text = "+";
			this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
			//
			// IncrementToolTip
			//
			this.IncrementToolTip.SetToolTip(this.IncrementButton, "Test");
			this.IncrementToolTip.Popup += IncrementToolTip_Popup;
			//
			// DecrementToolTip
			//
			this.DecrementToolTip.SetToolTip(this.DecrementButton, "Test");
			this.DecrementToolTip.Popup += DecrementToolTip_Popup;
			// 
			// ValueLabel
			// 
			this.ValueLabel.Caption = null;
			this.ValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "Value", true));
			this.ValueLabel.Location = DPIScalingHelper.GetScaledPoint(32, 0);
			this.ValueLabel.MaximumSize = DPIScalingHelper.GetScaledSize(500, 29);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = DPIScalingHelper.GetScaledSize(43, 23);
			this.ValueLabel.TabIndex = 0;
			this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// CaptionLabel
			//
			this.CaptionLabel.Top = 5;
			//
			// CoreControl
			//
			this.CoreControl.Controls.Add(this.DecrementButton);
			this.CoreControl.Controls.Add(this.IncrementButton);
			this.CoreControl.Controls.Add(this.ValueLabel);
			this.CoreControl.Height = 28;
			// 
			// VIncrementor
			// 
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.DataBindings.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
			this.Name = "VIncrementor";
			this.Size = DPIScalingHelper.GetScaledSize(109, 28);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VButton DecrementButton;
		private VButton IncrementButton;
		private VLabel ValueLabel;
		private ToolTip IncrementToolTip;
		private ToolTip DecrementToolTip;
	}
}
