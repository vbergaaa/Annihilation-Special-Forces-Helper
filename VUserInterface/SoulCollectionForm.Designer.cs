
namespace VUserInterface
{
	partial class SoulCollectionForm
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
		void InitializeComponent()
		{
			this.SoulCollectionControl = new SoulCollectionControl();
			this.SuspendLayout();
			//
			// SoulCollectionControl
			//
			this.SoulCollectionControl.Location = DPIScalingHelper.GetScaledPoint(0, 5);
			// 
			// SoulCollectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(SoulCollectionControl);
			this.ClientSize = DPIScalingHelper.GetScaledSize(585, 362);
			this.Name = "SoulCollectionForm";
			this.Text = "Soul Collection";
			this.ResumeLayout(false);
		}

		#endregion

		SoulCollectionControl SoulCollectionControl;
	}
}