using System.ComponentModel;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class SoulControl
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
			this.AddNewSoulButton = new DPIButton();
			this.SoulComboBox = new System.Windows.Forms.ComboBox();
			this.BindingSource = new VBindingSource();
			((ISupportInitialize)this.BindingSource).BeginInit();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(VSoul);
			//
			// AddNewSoulButton
			//
			this.AddNewSoulButton.Click += AddNewSoulButton_Click;
			this.AddNewSoulButton.Location = DPIScalingHelper.GetScaledPoint(375, 20);
			this.AddNewSoulButton.Name = "AddNewSoulButton";
			this.AddNewSoulButton.Size = DPIScalingHelper.GetScaledSize(25, 25);
			this.AddNewSoulButton.Text = "+";
			//
			// SoulComboBox
			//
			this.SoulComboBox.Location = DPIScalingHelper.GetScaledPoint(15, 20);
			this.SoulComboBox.Size = DPIScalingHelper.GetScaledSize(350, 25);
			this.SoulComboBox.DataSource = SoulList;
			this.SoulComboBox.SelectedValueChanged += SoulChanged;
			// 
			// SoulControl
			// 
			this.Controls.Add(this.SoulComboBox);
			this.Controls.Add(this.AddNewSoulButton);
			this.Name = "SoulForm";
			this.Size = DPIScalingHelper.GetScaledSize(410, 55);
			((ISupportInitialize)this.BindingSource).EndInit();
		}

		#endregion

		private DPIButton AddNewSoulButton;
		private System.Windows.Forms.ComboBox SoulComboBox;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}
