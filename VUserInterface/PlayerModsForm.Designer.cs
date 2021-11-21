namespace VUserInterface
{
	partial class PlayerModsForm
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
            this.SuspendLayout();
			this.playerModsControl = new PlayerModsControl();
			//
			// playerModsControl
			//
			this.playerModsControl.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.playerModsControl.Name = "PlayerMods";
			this.playerModsControl.PlayerMods = PlayerMods; 
            // 
            // PlayerModsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.playerModsControl);
            this.Name = "PlayerModsForm";
            this.Size = new System.Drawing.Size(300, 525);
            this.ResumeLayout(false);

		}

		#endregion

		private PlayerModsControl playerModsControl;
	}
}
