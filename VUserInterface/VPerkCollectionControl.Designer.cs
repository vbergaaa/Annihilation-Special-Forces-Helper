﻿using System;
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
			this.OptimiseForDamageButton = new VButton();
			this.OptimiseForToughnessButton = new VButton();
			this.Perk1Control = new VPerkControl();
			this.Perk2Control = new VPerkControl();
			this.Perk3Control = new VPerkControl();
			this.Perk4Control = new VPerkControl();
			this.Perk5Control = new VPerkControl();
			this.Perk6Control = new VPerkControl();
			this.perksBindingSource = new VBindingSource();
			this.MainGroupBox = new DPIGroupBox();
			this.PageCostLabel = new VLabel();
			this.TotalCostLabel = new VLabel();
			this.RemainingCostLabel = new VLabel();
			this.page1Button = new VUserInterface.CommonControls.VButton();
			this.page2Button = new VUserInterface.CommonControls.VButton();
			this.page3Button = new VUserInterface.CommonControls.VButton();
			this.page4Button = new VUserInterface.CommonControls.VButton();
			this.page5Button = new VUserInterface.CommonControls.VButton();
			this.page6Button = new VUserInterface.CommonControls.VButton();
			this.page7Button = new VUserInterface.CommonControls.VButton();
			this.page8Button = new VUserInterface.CommonControls.VButton();
			this.page9Button = new VUserInterface.CommonControls.VButton();
			this.page10Button = new VUserInterface.CommonControls.VButton();
			this.page11Button = new VUserInterface.CommonControls.VButton();
			this.page12Button = new VUserInterface.CommonControls.VButton();
			this.page13Button = new VUserInterface.CommonControls.VButton();
			this.page14Button = new VUserInterface.CommonControls.VButton();
			this.page15Button = new VUserInterface.CommonControls.VButton();
			this.previousPageButton = new VUserInterface.CommonControls.VButton();
			this.nextPageButton = new VUserInterface.CommonControls.VButton();
			((System.ComponentModel.ISupportInitialize)(this.perksBindingSource)).BeginInit();
			//
			// OptimiseForDamageButton
			//
			this.OptimiseForDamageButton.Click += OptimiseForDamageButton_Click;
			this.OptimiseForDamageButton.Name = "OptimiseForDamageButton";
			this.OptimiseForDamageButton.Text = "Maximise Damage";
			this.OptimiseForDamageButton.Location = DPIScalingHelper.GetScaledPoint(70, 25);
			this.OptimiseForDamageButton.Size = DPIScalingHelper.GetScaledSize(150, 25);
			//
			// OptimiseForToughnessButton
			//
			this.OptimiseForToughnessButton.Click += OptimiseForToughnessButton_Click;
			this.OptimiseForToughnessButton.Name = "OptimiseForToughnessButton";
			this.OptimiseForToughnessButton.Text = "Maximise Toughness";
			this.OptimiseForToughnessButton.Location = DPIScalingHelper.GetScaledPoint(350, 25);
			this.OptimiseForToughnessButton.Size = DPIScalingHelper.GetScaledSize(150, 25);
			//
			// Perk1Control
			//
			this.Perk1Control.Location = DPIScalingHelper.GetScaledPoint(35, 20);
			this.Perk1Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk1");
			this.Perk1Control.TabIndex = 2;
			//
			// Perk2Control
			//
			this.Perk2Control.Location = DPIScalingHelper.GetScaledPoint(208, 20);
			this.Perk2Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk2");
			this.Perk2Control.TabIndex = 3;
			//
			// Perk3Control
			//
			this.Perk3Control.Location = DPIScalingHelper.GetScaledPoint(381, 20);
			this.Perk3Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk3");
			this.Perk3Control.TabIndex = 4;
			//
			// Perk4Control
			//
			this.Perk4Control.Location = DPIScalingHelper.GetScaledPoint(35, 127);
			this.Perk4Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk4");
			this.Perk4Control.TabIndex = 5;
			//
			// Perk5Control
			//
			this.Perk5Control.Location = DPIScalingHelper.GetScaledPoint(208, 127);
			this.Perk5Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk5");
			this.Perk5Control.TabIndex = 6;
			//
			// Perk6Control
			//
			this.Perk6Control.Location = DPIScalingHelper.GetScaledPoint(381, 127);
			this.Perk6Control.DataBindings.Add("Perk", this.perksBindingSource, "Perk6");
			this.Perk6Control.TabIndex = 7;
			// 
			// perksBindingSource
			// 
			this.perksBindingSource.DataSource = typeof(PerkCollection);
			//
			// PageCostLabel;
			//
			this.PageCostLabel.DataBindings.Add("Text", perksBindingSource, "PageCost");
			this.PageCostLabel.Caption = "Cost of Page:";
			this.PageCostLabel.Location = DPIScalingHelper.GetScaledPoint(100, 0);
			this.PageCostLabel.Name = "PageCostLabel";
			this.PageCostLabel.Size = DPIScalingHelper.GetScaledSize(100, 25);
			//
			// TotalCostLabel;
			//
			this.TotalCostLabel.DataBindings.Add("Text", perksBindingSource, "TotalCost");
			this.TotalCostLabel.Caption = "Total Cost:";
			this.TotalCostLabel.Location = DPIScalingHelper.GetScaledPoint(300, 0);
			this.TotalCostLabel.Name = "TotalCostLabel";
			this.TotalCostLabel.Size = DPIScalingHelper.GetScaledSize(100, 25);
			//
			// RemainingCostLabel;
			//
			this.RemainingCostLabel.DataBindings.Add("Text", perksBindingSource, "RemainingCost");
			this.RemainingCostLabel.Caption = "Available PP:";
			this.RemainingCostLabel.Location = DPIScalingHelper.GetScaledPoint(500, 0);
			this.RemainingCostLabel.Name = "RemainingCostLabel";
			this.TotalCostLabel.Size = DPIScalingHelper.GetScaledSize(100, 25);
			//
			// page1Button
			//
			this.page1Button.Click += UpdatePage;
			this.page1Button.DisableStyleChanging = true;
			this.page1Button.Location = DPIScalingHelper.GetScaledPoint(24, 234);
			this.page1Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page1Button.Text = "1";
			//
			// page2Button
			//
			this.page2Button.Click += UpdatePage;
			this.page2Button.DisableStyleChanging = true;
			this.page2Button.Location = DPIScalingHelper.GetScaledPoint(60, 234);
			this.page2Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page2Button.Text = "2";
			//
			// page3Button
			//
			this.page3Button.Click += UpdatePage;
			this.page3Button.DisableStyleChanging = true;
			this.page3Button.Location = DPIScalingHelper.GetScaledPoint(96, 234);
			this.page3Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page3Button.Text = "3";
			//
			// page4Button
			//
			this.page4Button.Click += UpdatePage;
			this.page4Button.DisableStyleChanging = true;
			this.page4Button.Location = DPIScalingHelper.GetScaledPoint(132, 234);
			this.page4Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page4Button.Text = "4";
			//
			// page5Button
			//
			this.page5Button.Click += UpdatePage;
			this.page5Button.DisableStyleChanging = true;
			this.page5Button.Location = DPIScalingHelper.GetScaledPoint(168, 234);
			this.page5Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page5Button.Text = "5";
			//
			// page6Button
			//
			this.page6Button.Click += UpdatePage;
			this.page6Button.DisableStyleChanging = true;
			this.page6Button.Location = DPIScalingHelper.GetScaledPoint(204, 234);
			this.page6Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page6Button.Text = "6";
			//
			// page7Button
			//
			this.page7Button.Click += UpdatePage;
			this.page7Button.DisableStyleChanging = true;
			this.page7Button.Location = DPIScalingHelper.GetScaledPoint(240, 234);
			this.page7Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page7Button.Text = "7";
			//
			// page8Button
			//
			this.page8Button.Click += UpdatePage;
			this.page8Button.DisableStyleChanging = true;
			this.page8Button.Location = DPIScalingHelper.GetScaledPoint(276, 234);
			this.page8Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page8Button.Text = "8";
			//
			// page9Button
			//
			this.page9Button.Click += UpdatePage;
			this.page9Button.DisableStyleChanging = true;
			this.page9Button.Location = DPIScalingHelper.GetScaledPoint(312, 234);
			this.page9Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page9Button.Text = "9";
			//
			// page10Button
			//
			this.page10Button.Click += UpdatePage;
			this.page10Button.DisableStyleChanging = true;
			this.page10Button.Location = DPIScalingHelper.GetScaledPoint(348, 234);
			this.page10Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page10Button.Text = "10";
			//
			// page11Button
			//
			this.page11Button.Click += UpdatePage;
			this.page11Button.DisableStyleChanging = true;
			this.page11Button.Location = DPIScalingHelper.GetScaledPoint(384, 234);
			this.page11Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page11Button.Text = "11";
			//
			// page12Button
			//
			this.page12Button.Click += UpdatePage;
			this.page12Button.DisableStyleChanging = true;
			this.page12Button.Location = DPIScalingHelper.GetScaledPoint(420, 234);
			this.page12Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page12Button.Text = "12";
			//
			// page13Button
			//
			this.page13Button.Click += UpdatePage;
			this.page13Button.DisableStyleChanging = true;
			this.page13Button.Location = DPIScalingHelper.GetScaledPoint(456, 234);
			this.page13Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page13Button.Text = "13";
			//
			// page14Button
			//
			this.page14Button.Click += UpdatePage;
			this.page14Button.DisableStyleChanging = true;
			this.page14Button.Location = DPIScalingHelper.GetScaledPoint(492, 234);
			this.page14Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page14Button.Text = "14";
			//
			// page15Button
			//
			this.page15Button.Click += UpdatePage;
			this.page15Button.DisableStyleChanging = true;
			this.page15Button.Location = DPIScalingHelper.GetScaledPoint(528, 234);
			this.page15Button.Size = DPIScalingHelper.GetScaledSize(27, 27);
			this.page15Button.Text = "15";
			//
			// previousPageButton
			//
			this.previousPageButton.Click += UpdatePage;
			this.previousPageButton.Location = DPIScalingHelper.GetScaledPoint(3, 70);
			this.previousPageButton.Size = DPIScalingHelper.GetScaledSize(27, 90);
			this.previousPageButton.TabIndex = 1;
			this.previousPageButton.Text = "<";
			//
			// nextPageButton
			//
			this.nextPageButton.Click += UpdatePage;
			this.nextPageButton.Location = DPIScalingHelper.GetScaledPoint(554, 70);
			this.nextPageButton.Size = DPIScalingHelper.GetScaledSize(27, 90);
			this.nextPageButton.TabIndex = 8;
			this.nextPageButton.Text = ">";
			//
			// MainGroupBox
			//
			this.MainGroupBox.Name = "MainGroupBox";
			this.MainGroupBox.Location = DPIScalingHelper.GetScaledPoint(0, 50);
			this.MainGroupBox.Text = "Perks";
			this.MainGroupBox.Controls.Add(Perk1Control);
			this.MainGroupBox.Controls.Add(Perk2Control);
			this.MainGroupBox.Controls.Add(Perk3Control);
			this.MainGroupBox.Controls.Add(Perk4Control);
			this.MainGroupBox.Controls.Add(Perk5Control);
			this.MainGroupBox.Controls.Add(Perk6Control);
			this.MainGroupBox.Controls.Add(page1Button);
			this.MainGroupBox.Controls.Add(page2Button);
			this.MainGroupBox.Controls.Add(page3Button);
			this.MainGroupBox.Controls.Add(page4Button);
			this.MainGroupBox.Controls.Add(page5Button);
			this.MainGroupBox.Controls.Add(page6Button);
			this.MainGroupBox.Controls.Add(page7Button);
			this.MainGroupBox.Controls.Add(page8Button);
			this.MainGroupBox.Controls.Add(page9Button);
			this.MainGroupBox.Controls.Add(page10Button);
			this.MainGroupBox.Controls.Add(page11Button);
			this.MainGroupBox.Controls.Add(page12Button);
			this.MainGroupBox.Controls.Add(page13Button);
			this.MainGroupBox.Controls.Add(page14Button);
			this.MainGroupBox.Controls.Add(page15Button);
			this.MainGroupBox.Controls.Add(previousPageButton);
			this.MainGroupBox.Controls.Add(nextPageButton);
			this.MainGroupBox.Size = DPIScalingHelper.GetScaledSize(589, 271);
			//
			// VPerkPageControl
			//
			this.Controls.Add(PageCostLabel);
			this.Controls.Add(TotalCostLabel);
			this.Controls.Add(OptimiseForDamageButton);
			this.Controls.Add(OptimiseForToughnessButton);
			this.Controls.Add(RemainingCostLabel);
			this.Controls.Add(MainGroupBox);
			this.Size = DPIScalingHelper.GetScaledSize(589, 322);
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
		private VButton page1Button;
		private VButton page2Button;
		private VButton page3Button;
		private VButton page4Button;
		private VButton page5Button;
		private VButton page6Button;
		private VButton page7Button;
		private VButton page8Button;
		private VButton page9Button;
		private VButton page10Button;
		private VButton page11Button;
		private VButton page12Button;
		private VButton page13Button;
		private VButton page14Button;
		private VButton page15Button;
		private VButton previousPageButton;
		private VButton nextPageButton;
		private VLabel PageCostLabel;
		private VLabel TotalCostLabel;
		private VLabel RemainingCostLabel;
		private DPIGroupBox MainGroupBox;
		private VButton OptimiseForDamageButton;
		private VButton OptimiseForToughnessButton;
	}
}
