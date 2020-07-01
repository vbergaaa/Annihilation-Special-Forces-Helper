using System;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VModel;

namespace ASF_Planner
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
			this.costOfPageLabel = new System.Windows.Forms.Label();
			this.costOfPageCaptionLabel = new System.Windows.Forms.Label();
			this.totalCostCaptionLabel = new System.Windows.Forms.Label();
			this.totalCostValueLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.perksBindingSource)).BeginInit();
			//
			// Perk1Control
			//
			this.Perk1Control.Location = new System.Drawing.Point(5, 40);
			this.Perk1Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk1");
			//
			// Perk2Control
			//
			this.Perk2Control.Location = new System.Drawing.Point(178, 40);
			this.Perk2Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk2");
			//
			// Perk3Control
			//
			this.Perk3Control.Location = new System.Drawing.Point(351, 40);
			this.Perk3Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk3");
			//
			// Perk4Control
			//
			this.Perk4Control.Location = new System.Drawing.Point(5, 127);
			this.Perk4Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk4");
			//
			// Perk5Control
			//
			this.Perk5Control.Location = new System.Drawing.Point(178, 127);
			this.Perk5Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk5");
			//
			// Perk6Control
			//
			this.Perk6Control.Location = new System.Drawing.Point(351, 127);
			this.Perk6Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk6");
			// 
			// perksBindingSource
			// 
			this.perksBindingSource.DataSource = typeof(PerkCollection);
			//
			// costOfPageValueLabel
			//
			this.costOfPageLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perksBindingSource, "CostForPage"));
			this.costOfPageLabel.Location = new System.Drawing.Point(131, 20);
			this.costOfPageLabel.Size = new System.Drawing.Size(129, 20);
			this.costOfPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// costOfPageCaptionLabel
			//
			this.costOfPageCaptionLabel.Location = new System.Drawing.Point(1, 20);
			this.costOfPageCaptionLabel.Size = new System.Drawing.Size(129, 20);
			this.costOfPageCaptionLabel.Text = "Cost of Page:";
			this.costOfPageCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// totalCostValueLabel
			//
			this.totalCostValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perksBindingSource, "Cost"));
			this.totalCostValueLabel.Location = new System.Drawing.Point(391, 20);
			this.totalCostValueLabel.Size = new System.Drawing.Size(126, 20);
			this.totalCostValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// totalCostCaptionLabel
			//
			this.totalCostCaptionLabel.Location = new System.Drawing.Point(261, 20);
			this.totalCostCaptionLabel.Size = new System.Drawing.Size(129, 20);
			this.totalCostCaptionLabel.Text = "Total Cost:";
			this.totalCostCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// page1Button
			//
			this.page1Button.Click += UpdatePage;
			this.page1Button.Location = new System.Drawing.Point(6, 198);
			this.page1Button.Size = new System.Drawing.Size(23, 23);
			this.page1Button.Text = "1";
			//
			// page2Button
			//
			this.page2Button.Click += UpdatePage;
			this.page2Button.Location = new System.Drawing.Point(36, 198);
			this.page2Button.Size = new System.Drawing.Size(23, 23);
			this.page2Button.Text = "2";
			//
			// page3Button
			//
			this.page3Button.Click += UpdatePage;
			this.page3Button.Location = new System.Drawing.Point(66, 198);
			this.page3Button.Size = new System.Drawing.Size(23, 23);
			this.page3Button.Text = "3";
			//
			// page4Button
			//
			this.page4Button.Click += UpdatePage;
			this.page4Button.Location = new System.Drawing.Point(96, 198);
			this.page4Button.Size = new System.Drawing.Size(23, 23);
			this.page4Button.Text = "4";
			//
			// page5Button
			//
			this.page5Button.Click += UpdatePage;
			this.page5Button.Location = new System.Drawing.Point(126, 198);
			this.page5Button.Size = new System.Drawing.Size(23, 23);
			this.page5Button.Text = "5";
			//
			// page6Button
			//
			this.page6Button.Click += UpdatePage;
			this.page6Button.Location = new System.Drawing.Point(156, 198);
			this.page6Button.Size = new System.Drawing.Size(23, 23);
			this.page6Button.Text = "6";
			//
			// page7Button
			//
			this.page7Button.Click += UpdatePage;
			this.page7Button.Location = new System.Drawing.Point(186, 198);
			this.page7Button.Size = new System.Drawing.Size(23, 23);
			this.page7Button.Text = "7";
			//
			// page8Button
			//
			this.page8Button.Click += UpdatePage;
			this.page8Button.Location = new System.Drawing.Point(216, 198);
			this.page8Button.Size = new System.Drawing.Size(23, 23);
			this.page8Button.Text = "8";
			//
			// page9Button
			//
			this.page9Button.Click += UpdatePage;
			this.page9Button.Location = new System.Drawing.Point(246, 198);
			this.page9Button.Size = new System.Drawing.Size(23, 23);
			this.page9Button.Text = "9";
			//
			// page10Button
			//
			this.page10Button.Click += UpdatePage;
			this.page10Button.Location = new System.Drawing.Point(276, 198);
			this.page10Button.Size = new System.Drawing.Size(23, 23);
			this.page10Button.Text = "10";
			//
			// page11Button
			//
			this.page11Button.Click += UpdatePage;
			this.page11Button.Location = new System.Drawing.Point(306, 198);
			this.page11Button.Size = new System.Drawing.Size(23, 23);
			this.page11Button.Text = "11";
			//
			// VPerkPageControl
			//
			this.Controls.Add(Perk1Control);
			this.Controls.Add(Perk2Control);
			this.Controls.Add(Perk3Control);
			this.Controls.Add(Perk4Control);
			this.Controls.Add(Perk5Control);
			this.Controls.Add(Perk6Control);
			this.Controls.Add(costOfPageLabel);
			this.Controls.Add(costOfPageCaptionLabel);
			this.Controls.Add(totalCostValueLabel);
			this.Controls.Add(totalCostCaptionLabel);
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
			this.Size = new System.Drawing.Size(519, 227);
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
		private System.Windows.Forms.Label costOfPageLabel;
		private System.Windows.Forms.Label costOfPageCaptionLabel;
		private System.Windows.Forms.Label totalCostValueLabel;
		private System.Windows.Forms.Label totalCostCaptionLabel;
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
	}
}
