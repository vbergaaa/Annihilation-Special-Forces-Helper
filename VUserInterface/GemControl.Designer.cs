﻿using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class GemControl
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
			this.CostCaption = new VLabel();
			this.CostLabel = new VLabel();
			this.CurrentLevelCaption = new VLabel();
			this.CurrentLevelIncrementor = new VIncrementor();
			this.gemBindingSource = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.gemBindingSource)).BeginInit();
			// 
			// CostCaption
			// 
			this.CostCaption.Location = new System.Drawing.Point(5, 50);
			this.CostCaption.Name = "CostCaption";
			this.CostCaption.Size = new System.Drawing.Size(110, 23);
			this.CostCaption.TabIndex = 6;
			this.CostCaption.Text = "Next Lvl Cost:";
			this.CostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CostLabel
			// 
			this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gemBindingSource, "NextLevelCost"));
			this.CostLabel.Location = new System.Drawing.Point(116, 50);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Size = new System.Drawing.Size(40, 23);
			this.CostLabel.TabIndex = 6;
			this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CurrentLevelCaption
			// 
			this.CurrentLevelCaption.Location = new System.Drawing.Point(1, 17);
			this.CurrentLevelCaption.Name = "CurrentLevelCaption";
			this.CurrentLevelCaption.Size = new System.Drawing.Size(70, 23);
			this.CurrentLevelCaption.TabIndex = 3;
			this.CurrentLevelCaption.Text = "Current:";
			this.CurrentLevelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// this.CurrentLevelIncrementor
			//
			this.CurrentLevelIncrementor.Location = new System.Drawing.Point(27, 20);
			this.CurrentLevelIncrementor.DataBindings.Add("Value", gemBindingSource, "CurrentLevel");
			this.CurrentLevelIncrementor.DataBindings.Add("MaxValue", gemBindingSource, "MaxValue");
			this.CurrentLevelIncrementor.MinValue = 0;
			// 
			// perkBindingSource
			// 
			this.gemBindingSource.DataSource = typeof(VGem);
			// 
			// VPerkControl
			// 
			this.Controls.Add(this.CostLabel);
			this.Controls.Add(this.CostCaption);
			this.Controls.Add(this.CurrentLevelIncrementor);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gemBindingSource, "Name"));
			this.Size = new System.Drawing.Size(160, 75);
			((System.ComponentModel.ISupportInitialize)(this.gemBindingSource)).EndInit();
		}

		#endregion

		private BindingSource gemBindingSource;
		private VLabel CostCaption;
		private VLabel CostLabel;
		private VLabel CurrentLevelCaption;
		private VIncrementor CurrentLevelIncrementor;
	}
}
