
namespace VUserInterface
{
	partial class SingleSoulControl
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
			// 
			// SingleSoulControl
			// 
			this.DataBindings.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Name = "SingleSoulControl";
			this.Click += OnClick;
			this.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.ResumeLayout(false);
		}

		#endregion
	}
}
