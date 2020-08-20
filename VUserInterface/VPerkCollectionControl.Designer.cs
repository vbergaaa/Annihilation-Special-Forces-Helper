using System;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VEntityFramework;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class VPerkCollectionControl
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
			this.Perk1Control = new VPerkControl();
			this.Perk2Control = new VPerkControl();
			this.Perk3Control = new VPerkControl();
			this.Perk4Control = new VPerkControl();
			this.Perk5Control = new VPerkControl();
			this.Perk6Control = new VPerkControl();
			this.perksBindingSource = new System.Windows.Forms.BindingSource();
			this.page1Button = new System.Windows.Forms.Button();
			this.page2Button = new System.Windows.Forms.Button();
			this.page3Button = new System.Windows.Forms.Button();
			this.page4Button = new System.Windows.Forms.Button();
			this.page5Button = new System.Windows.Forms.Button();
			this.page6Button = new System.Windows.Forms.Button();
			this.page7Button = new System.Windows.Forms.Button();
			this.page8Button = new System.Windows.Forms.Button();
			this.page9Button = new System.Windows.Forms.Button();
			this.page10Button = new System.Windows.Forms.Button();
			this.page11Button = new System.Windows.Forms.Button();
			this.previousPageButton = new System.Windows.Forms.Button();
			this.nextPageButton = new System.Windows.Forms.Button();
			this.remainingCostCaption = new VLabel();
			this.remainingCostLabel = new VLabel();
			((System.ComponentModel.ISupportInitialize)(this.perksBindingSource)).BeginInit();
			//
			// Perk1Control
			//
			this.Perk1Control.Location = new System.Drawing.Point(35, 40);
			this.Perk1Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk1");
			this.Perk1Control.TabIndex = 2;
			//
			// Perk2Control
			//
			this.Perk2Control.Location = new System.Drawing.Point(208, 40);
			this.Perk2Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk2");
			this.Perk2Control.TabIndex = 3;
			//
			// Perk3Control
			//
			this.Perk3Control.Location = new System.Drawing.Point(381, 40);
			this.Perk3Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk3");
			this.Perk3Control.TabIndex = 4;
			//
			// Perk4Control
			//
			this.Perk4Control.Location = new System.Drawing.Point(35, 147);
			this.Perk4Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk4");
			this.Perk4Control.TabIndex = 5;
			//
			// Perk5Control
			//
			this.Perk5Control.Location = new System.Drawing.Point(208, 147);
			this.Perk5Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk5");
			this.Perk5Control.TabIndex = 6;
			//
			// Perk6Control
			//
			this.Perk6Control.Location = new System.Drawing.Point(381, 147);
			this.Perk6Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk6");
			this.Perk6Control.TabIndex = 7;
			// 
			// perksBindingSource
			// 
			this.perksBindingSource.DataSource = typeof(PerkCollection);
			//
			// remainingCostLabel
			//
			this.remainingCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perksBindingSource, "RemainingCost"));
			this.remainingCostLabel.Location = new System.Drawing.Point(301, 20);
			this.remainingCostLabel.Size = new System.Drawing.Size(70, 20);
			this.remainingCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// remainingCostCaption
			//
			this.remainingCostCaption.Location = new System.Drawing.Point(200, 20);
			this.remainingCostCaption.Size = new System.Drawing.Size(100, 20);
			this.remainingCostCaption.Text = "Total Cost:";
			this.remainingCostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// page1Button
			//
			this.page1Button.Click += UpdatePage;
			this.page1Button.Location = new System.Drawing.Point(96, 254);
			this.page1Button.Size = new System.Drawing.Size(27, 27);
			this.page1Button.Text = "1";
			//
			// page2Button
			//
			this.page2Button.Click += UpdatePage;
			this.page2Button.Location = new System.Drawing.Point(132, 254);
			this.page2Button.Size = new System.Drawing.Size(27, 27);
			this.page2Button.Text = "2";
			//
			// page3Button
			//
			this.page3Button.Click += UpdatePage;
			this.page3Button.Location = new System.Drawing.Point(168, 254);
			this.page3Button.Size = new System.Drawing.Size(27, 27);
			this.page3Button.Text = "3";
			//
			// page4Button
			//
			this.page4Button.Click += UpdatePage;
			this.page4Button.Location = new System.Drawing.Point(204, 254);
			this.page4Button.Size = new System.Drawing.Size(27, 27);
			this.page4Button.Text = "4";
			//
			// page5Button
			//
			this.page5Button.Click += UpdatePage;
			this.page5Button.Location = new System.Drawing.Point(240, 254);
			this.page5Button.Size = new System.Drawing.Size(27, 27);
			this.page5Button.Text = "5";
			//
			// page6Button
			//
			this.page6Button.Click += UpdatePage;
			this.page6Button.Location = new System.Drawing.Point(276, 254);
			this.page6Button.Size = new System.Drawing.Size(27, 27);
			this.page6Button.Text = "6";
			//
			// page7Button
			//
			this.page7Button.Click += UpdatePage;
			this.page7Button.Location = new System.Drawing.Point(312, 254);
			this.page7Button.Size = new System.Drawing.Size(27, 27);
			this.page7Button.Text = "7";
			//
			// page8Button
			//
			this.page8Button.Click += UpdatePage;
			this.page8Button.Location = new System.Drawing.Point(348, 254);
			this.page8Button.Size = new System.Drawing.Size(27, 27);
			this.page8Button.Text = "8";
			//
			// page9Button
			//
			this.page9Button.Click += UpdatePage;
			this.page9Button.Location = new System.Drawing.Point(384, 254);
			this.page9Button.Size = new System.Drawing.Size(27, 27);
			this.page9Button.Text = "9";
			//
			// page10Button
			//
			this.page10Button.Click += UpdatePage;
			this.page10Button.Location = new System.Drawing.Point(420, 254);
			this.page10Button.Size = new System.Drawing.Size(27, 27);
			this.page10Button.Text = "10";
			//
			// page11Button
			//
			this.page11Button.Click += UpdatePage;
			this.page11Button.Location = new System.Drawing.Point(456, 254);
			this.page11Button.Size = new System.Drawing.Size(27, 27);
			this.page11Button.Text = "11";
			//
			// previousPageButton
			//
			this.previousPageButton.Click += UpdatePage;
			this.previousPageButton.Location = new System.Drawing.Point(3, 90);
			this.previousPageButton.Size = new System.Drawing.Size(27, 90);
			this.previousPageButton.TabIndex = 1;
			this.previousPageButton.Text = "<";
			//
			// nextPageButton
			//
			this.nextPageButton.Click += UpdatePage;
			this.nextPageButton.Location = new System.Drawing.Point(554, 90);
			this.nextPageButton.Size = new System.Drawing.Size(27, 90);
			this.nextPageButton.TabIndex = 8;
			this.nextPageButton.Text = ">";
			//
			// VPerkPageControl
			//
			this.Controls.Add(Perk1Control);
			this.Controls.Add(Perk2Control);
			this.Controls.Add(Perk3Control);
			this.Controls.Add(Perk4Control);
			this.Controls.Add(Perk5Control);
			this.Controls.Add(Perk6Control);
			this.Controls.Add(remainingCostLabel);
			this.Controls.Add(remainingCostCaption);
			this.Controls.Add(page1Button);
			this.Controls.Add(page2Button);
			this.Controls.Add(page3Button);
			this.Controls.Add(page4Button);
			this.Controls.Add(page5Button);
			this.Controls.Add(page6Button);
			this.Controls.Add(page7Button);
			this.Controls.Add(page8Button);
			this.Controls.Add(page9Button);
			this.Controls.Add(page10Button);
			this.Controls.Add(page11Button);
			this.Controls.Add(previousPageButton);
			this.Controls.Add(nextPageButton);
			this.Size = new System.Drawing.Size(589, 292);
			((System.ComponentModel.ISupportInitialize)(this.perksBindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.BindingSource perksBindingSource;
		private VPerkControl Perk1Control;
		private VPerkControl Perk2Control;
		private VPerkControl Perk3Control;
		private VPerkControl Perk4Control;
		private VPerkControl Perk5Control;
		private VPerkControl Perk6Control;
		private System.Windows.Forms.Label remainingCostLabel;
		private System.Windows.Forms.Label remainingCostCaption;
		private System.Windows.Forms.Button page1Button;
		private System.Windows.Forms.Button page2Button;
		private System.Windows.Forms.Button page3Button;
		private System.Windows.Forms.Button page4Button;
		private System.Windows.Forms.Button page5Button;
		private System.Windows.Forms.Button page6Button;
		private System.Windows.Forms.Button page7Button;
		private System.Windows.Forms.Button page8Button;
		private System.Windows.Forms.Button page9Button;
		private System.Windows.Forms.Button page10Button;
		private System.Windows.Forms.Button page11Button;
		private System.Windows.Forms.Button previousPageButton;
		private System.Windows.Forms.Button nextPageButton;
	}
}
