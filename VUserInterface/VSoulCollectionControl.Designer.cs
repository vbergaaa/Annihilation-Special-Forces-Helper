﻿using System.Windows.Forms;
using VBusiness.Souls;
using VEntityFramework.Model;

namespace VUserInterface
{
	partial class VSoulCollectionControl
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
			this.bindingSource = new BindingSource();
			this.Soul1Control = new SoulControl();
			this.Soul2Control = new SoulControl();
			this.Soul3Control = new SoulControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(VSoulCollection);
			//
			// Soul1Control
			//
			this.Soul1Control.DataBindings.Add("Soul", bindingSource, "Soul1");
			this.Soul1Control.Location = new System.Drawing.Point(35, 40);
			this.Soul1Control.OnSoulChanged += Soul1Control_OnSoulChanged;
			//
			// Soul2Control
			//
			this.Soul2Control.DataBindings.Add("Soul", bindingSource, "Soul2");
			this.Soul2Control.Location = new System.Drawing.Point(208, 40);
			this.Soul2Control.OnSoulChanged += Soul2Control_OnSoulChanged;
			//
			// Soul3Control
			//
			this.Soul3Control.DataBindings.Add("Soul", bindingSource, "Soul3");
			this.Soul3Control.Location = new System.Drawing.Point(381, 40);
			this.Soul3Control.OnSoulChanged += Soul3Control_OnSoulChanged;
			//
			// VSoulCollectionControl
			//
			this.Controls.Add(Soul1Control);
			this.Controls.Add(Soul2Control);
			this.Controls.Add(Soul3Control);
			this.Size = new System.Drawing.Size(589, 292);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		BindingSource bindingSource;
		SoulControl Soul1Control;
		SoulControl Soul2Control;
		SoulControl Soul3Control;
	}
}
