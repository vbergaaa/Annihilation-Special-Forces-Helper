namespace VUserInterface.CommonControls
{
	partial class VLoadList
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
			this.ListBox = new System.Windows.Forms.ListBox();
			this.Label = new VLabel();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.NewButton = new System.Windows.Forms.Button();
			this.OpenButton = new System.Windows.Forms.Button();
			// 
			// ListBox
			// 
			this.ListBox.DataSource = this.Collection;
			this.ListBox.FormattingEnabled = true;
			this.ListBox.ItemHeight = 15;
			this.ListBox.Location = new System.Drawing.Point(2, 20);
			this.ListBox.Name = "ListBox";
			this.ListBox.Size = new System.Drawing.Size(275, 94);
			this.ListBox.TabIndex = 0;
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.Location = new System.Drawing.Point(4, 1);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(56, 15);
			this.Label.TabIndex = 1;
			// 
			// NewButton
			// 
			this.NewButton.Click += New_Click;
			this.NewButton.Location = new System.Drawing.Point(1, 131);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(85, 23);
			this.NewButton.TabIndex = 2;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			// 
			// OpenButton
			// 
			this.OpenButton.Click += Open_Click;
			this.OpenButton.Location = new System.Drawing.Point(96, 131);
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.Size = new System.Drawing.Size(85, 23);
			this.OpenButton.TabIndex = 2;
			this.OpenButton.Text = "Open";
			this.OpenButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Click += Delete_Click;
			this.DeleteButton.Location = new System.Drawing.Point(191, 131);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(85, 23);
			this.DeleteButton.TabIndex = 2;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			//
			// VLoadList
			//
			this.ClientSize = new System.Drawing.Size(280, 160);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.OpenButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.Label);
			this.Controls.Add(this.ListBox);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListBox ListBox;
		private VLabel Label;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button OpenButton;
	}
}
