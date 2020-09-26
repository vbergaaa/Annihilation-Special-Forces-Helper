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
			components = new System.ComponentModel.Container();
			this.DecrementButton = new VButton();
			this.IncrementButton = new VButton();
			this.ValueLabel = new VLabel();
			this.CaptionLabel = new VLabel();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//
			// this.DecrementButton
			//
			this.DecrementButton.Click += DecrementButton_Click;
			this.DecrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecrementButton.Location = new System.Drawing.Point(1, 1);
			this.DecrementButton.Name = "DecrementButton";
			this.DecrementButton.Size = new System.Drawing.Size(27, 27);
			this.DecrementButton.TabIndex = 1;
			this.DecrementButton.Text = "-";
			//
			// this.IncrementButton
			//
			this.IncrementButton.Click += IncrementButton_Click;
			this.IncrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncrementButton.Location = new System.Drawing.Point(81, 1);
			this.IncrementButton.Name = "IncrementButton";
			this.IncrementButton.Size = new System.Drawing.Size(27, 27);
			this.IncrementButton.TabIndex = 2;
			this.IncrementButton.Text = "+";
			//
			// this.ValueLabel
			//
			this.ValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "Value"));
			this.ValueLabel.Location = new System.Drawing.Point(33, 1);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(43, 23);
			this.ValueLabel.TabIndex = 0;
			this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// this.CaptionLabel
			//
			this.CaptionLabel.AutoSize = true;
			this.CaptionLabel.Location = new System.Drawing.Point(0, 7);
			this.CaptionLabel.Name = "CaptionLabel";
			this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CaptionLabel.Visible = false;
			//
			// VIncrementor
			//
			this.Controls.Add(DecrementButton);
			this.Controls.Add(IncrementButton);
			this.Controls.Add(ValueLabel);
			this.Controls.Add(CaptionLabel);
			this.DataBindings.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
			this.Size = new System.Drawing.Size(109, 29);
		}

		#endregion

		private System.Windows.Forms.Button DecrementButton;
		private System.Windows.Forms.Button IncrementButton;
		private System.Windows.Forms.Label ValueLabel;
		private System.Windows.Forms.Label CaptionLabel;
	}
}
