using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VUserInterface;

namespace VUserInterface
{
	partial class PerkPlanningForm
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
			this.PerkPageControl = new VPerkCollectionControl();
			this.perkPageBindingSource = new System.Windows.Forms.BindingSource();
			((ISupportInitialize)this.perkPageBindingSource).BeginInit();
			//
			// PerkPageControl
			//
			this.PerkPageControl.Location = new System.Drawing.Point(10, 10);
			this.PerkPageControl.DataBindings.Add("Perks", this.perkPageBindingSource, "Perks");
			this.PerkPageControl.DataBindings.Add("Text", this.perkPageBindingSource, "Perks.PageTitle");
			//
			// perkPageBindingSource
			//
			this.perkPageBindingSource.DataSource = typeof(Loadout);
			//
			// PerkPlanningForm
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(PerkPageControl);
			((ISupportInitialize)this.perkPageBindingSource).EndInit();
		}

		#endregion

		private VUserInterface.VPerkCollectionControl PerkPageControl;
		private System.Windows.Forms.BindingSource perkPageBindingSource;
	}
}