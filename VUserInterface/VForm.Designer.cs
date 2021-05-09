using System.Windows.Forms;
using VEntityFramework.Data;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	abstract partial class VForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VForm));
			this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.SaveButton = new VUserInterface.CommonControls.VButton();
			this.CancelButton = new VUserInterface.CommonControls.VButton();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// BindingSource
			// 
			this.BindingSource.DataSource = typeof(VEntityFramework.Data.BusinessObject);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Click += SaveButton_Click; 
			this.SaveButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.BindingSource, "HasChanges", true));
			this.SaveButton.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = DPIScalingHelper.GetScaledSize(80, 25);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.Text = "Save";
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.Click += CancelButton_Click; 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CancelButton.Location = new System.Drawing.Point(0, 0);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = DPIScalingHelper.GetScaledSize(80, 25);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Close";
			// 
			// VForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = DPIScalingHelper.GetScaledSize(331, 301);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CancelButton);
			this.DataBindings.Add("BizoHasChanges", BindingSource, "HasChanges");
			this.Icon = Properties.Resources.asflogo;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "VForm";
			this.Text = "Annihilation Special Forces Companion App";
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		protected VButton SaveButton;
		protected new VButton CancelButton;
		private BindingSource BindingSource;
	}
}