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
			this.ValueLabel = new VUserInterface.CommonControls.VLabel();
			this.SuspendLayout();
			// 
			// DecrementButton
			// 
			this.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementButton.Location = new System.Drawing.Point(0, 0);
			this.DecrementButton.Name = "DecrementButton";
			this.DecrementButton.Size = new System.Drawing.Size(27, 27);
			this.DecrementButton.TabIndex = 1;
			this.DecrementButton.Text = "-";
			this.DecrementButton.Click += new System.EventHandler(this.DecrementButton_Click);
			// 
			// IncrementButton
			// 
			this.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncrementButton.Location = new System.Drawing.Point(80, 0);
			this.IncrementButton.Name = "IncrementButton";
			this.IncrementButton.Size = new System.Drawing.Size(27, 27);
			this.IncrementButton.TabIndex = 2;
			this.IncrementButton.Text = "+";
			this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
			// 
			// ValueLabel
			// 
			this.ValueLabel.Caption = null;
			this.ValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "Value", true));
			this.ValueLabel.Location = new System.Drawing.Point(32, 0);
			this.ValueLabel.MaximumSize = new System.Drawing.Size(500, 29);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(43, 23);
			this.ValueLabel.TabIndex = 0;
			this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// CaptionLabel
			//
			this.CaptionLabel.Top = 5;
			// 
			// VIncrementor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CoreControl.Controls.Add(this.DecrementButton);
			this.CoreControl.Controls.Add(this.IncrementButton);
			this.CoreControl.Controls.Add(this.ValueLabel);
			this.DataBindings.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
			this.Name = "VIncrementor";
			this.Size = new System.Drawing.Size(109, 29);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VButton DecrementButton;
		private VButton IncrementButton;
		private VLabel ValueLabel;
	}
}
