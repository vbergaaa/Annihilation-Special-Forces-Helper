using System.ComponentModel;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VUserInterface;

namespace VUserInterface
{
	partial class VLoadoutForm
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
			this.LoadoutBindingSource = new System.Windows.Forms.BindingSource();
			this.LoadoutNameLabel = new Label();
			this.LoadoutNameTextBox = new TextBox();
			this.SlotNumberLabel = new Label();
			this.SlotNumberTextBox = new TextBox();
			((ISupportInitialize)this.LoadoutBindingSource).BeginInit();
			//
			// LoadoutBindingSource
			//
			this.LoadoutBindingSource.DataSource = typeof(Loadout);
			//
			// LoadoutNameLabel
			//
			this.LoadoutNameLabel.Location = new System.Drawing.Point(350, 60);
			this.LoadoutNameLabel.Size = new System.Drawing.Size(120, 20);
			this.LoadoutNameLabel.Text = "Loadout Name";
			//
			// LoadoutNameTextBox
			//
			this.LoadoutNameTextBox.DataBindings.Add("Text", this.LoadoutBindingSource, "Name");
			this.LoadoutNameTextBox.Location = new System.Drawing.Point(470, 60);
			this.LoadoutNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.LoadoutNameTextBox.TextAlign = HorizontalAlignment.Center;
			//
			// SlotNumberLabel
			//
			this.SlotNumberLabel.Location = new System.Drawing.Point(200, 60);
			this.SlotNumberLabel.Size = new System.Drawing.Size(70, 20);
			this.SlotNumberLabel.Text = "Save Slot";
			//
			// SlotNumberTextBox
			//
			this.SlotNumberTextBox.DataBindings.Add("Text", this.LoadoutBindingSource, "Slot");
			this.SlotNumberTextBox.Location = new System.Drawing.Point(271, 60);
			this.SlotNumberTextBox.Size = new System.Drawing.Size(30, 20);
			this.SlotNumberTextBox.TextAlign = HorizontalAlignment.Center;
			//
			// PerkPageControl
			//
			this.PerkPageControl.Location = new System.Drawing.Point(105, 90);
			this.PerkPageControl.DataBindings.Add("Perks", this.LoadoutBindingSource, "Perks");
			this.PerkPageControl.DataBindings.Add("Text", this.LoadoutBindingSource, "Perks.PageTitle");
			//
			// PerkPlanningForm
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(LoadoutNameLabel);
			this.Controls.Add(LoadoutNameTextBox);
			this.Controls.Add(PerkPageControl);
			this.Controls.Add(SlotNumberLabel);
			this.Controls.Add(SlotNumberTextBox);
			this.Text = "Create/Edit Loadout";
			((ISupportInitialize)this.LoadoutBindingSource).EndInit();
		}

		#endregion

		private System.Windows.Forms.Label SlotNumberLabel;
		private System.Windows.Forms.Label LoadoutNameLabel;
		private System.Windows.Forms.TextBox SlotNumberTextBox;
		private System.Windows.Forms.TextBox LoadoutNameTextBox;
		private VUserInterface.VPerkCollectionControl PerkPageControl;
		private System.Windows.Forms.BindingSource LoadoutBindingSource;
	}
}