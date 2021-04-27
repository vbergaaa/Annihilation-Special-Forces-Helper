using System.Windows.Forms;
using VEntityFramework.Interfaces;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class SoulCollectionControl
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
			this.TitleLabel = new VLabel();
			this.TotalUniquesLabel = new VLabel();
			this.RemainingPowerSoulsLabel = new VLabel();
			this.SoulControl1 = new VUserInterface.SingleSoulControl();
			this.SoulControl2 = new VUserInterface.SingleSoulControl();
			this.SoulControl3 = new VUserInterface.SingleSoulControl();
			this.SoulControl4 = new VUserInterface.SingleSoulControl();
			this.SoulControl5 = new VUserInterface.SingleSoulControl();
			this.SoulControl6 = new VUserInterface.SingleSoulControl();
			this.SoulControl7 = new VUserInterface.SingleSoulControl();
			this.SoulControl8 = new VUserInterface.SingleSoulControl();
			this.SoulControl9 = new VUserInterface.SingleSoulControl();
			this.SoulControl10 = new VUserInterface.SingleSoulControl();
			this.SoulControl11 = new VUserInterface.SingleSoulControl();
			this.SoulControl12 = new VUserInterface.SingleSoulControl();
			this.SoulControl13 = new VUserInterface.SingleSoulControl();
			this.SoulControl14 = new VUserInterface.SingleSoulControl();
			this.SoulControl15 = new VUserInterface.SingleSoulControl();
			this.Page1Button = new VUserInterface.CommonControls.DPIButton();
			this.Page2Button = new VUserInterface.CommonControls.DPIButton();
			this.Page3Button = new VUserInterface.CommonControls.DPIButton();
			this.BindingSource = new BindingSource();
			this.SuspendLayout();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(ISoulCollectable);
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleLabel.Location = DPIScalingHelper.GetScaledPoint(235, 13);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = DPIScalingHelper.GetScaledSize(130, 25);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Soul Collection";
			// 
			// TotalUniquesLabel
			// 
			this.TotalUniquesLabel.AutoSize = true;
			this.TotalUniquesLabel.Caption = "Uniques";
			this.TotalUniquesLabel.DataBindings.Add("Text", BindingSource, "TotalUniques");
			this.TotalUniquesLabel.Location = DPIScalingHelper.GetScaledPoint(200, 42);
			this.TotalUniquesLabel.Name = "TotalUniquesLabel";
			this.TotalUniquesLabel.Size = DPIScalingHelper.GetScaledSize(50, 15);
			this.TotalUniquesLabel.TabIndex = 1;
			// 
			// RemainingPowerSoulsLabel
			// 
			this.RemainingPowerSoulsLabel.AutoSize = true;
			this.RemainingPowerSoulsLabel.Caption = "PowerSouls";
			this.RemainingPowerSoulsLabel.DataBindings.Add("Text", BindingSource, "PowerSouls");
			this.RemainingPowerSoulsLabel.Location = DPIScalingHelper.GetScaledPoint(445, 42);
			this.RemainingPowerSoulsLabel.Name = "RemainingPowerSoulsLabel";
			this.RemainingPowerSoulsLabel.Size = DPIScalingHelper.GetScaledSize(68, 15);
			this.RemainingPowerSoulsLabel.TabIndex = 2;
			// 
			// SoulControl1
			// 
			this.SoulControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl1.Location = DPIScalingHelper.GetScaledPoint(37, 69);
			this.SoulControl1.Name = "SoulControl1";
			this.SoulControl1.Selected = false;
			this.SoulControl1.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl1.TabIndex = 3;
			this.SoulControl1.UseVisualStyleBackColor = true;
			this.SoulControl1.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl2
			// 
			this.SoulControl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl2.Location = DPIScalingHelper.GetScaledPoint(37, 146);
			this.SoulControl2.Name = "SoulControl2";
			this.SoulControl2.Selected = false;
			this.SoulControl2.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl2.TabIndex = 4;
			this.SoulControl2.UseVisualStyleBackColor = true;
			this.SoulControl2.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl3
			// 
			this.SoulControl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl3.Location = DPIScalingHelper.GetScaledPoint(37, 222);
			this.SoulControl3.Name = "SoulControl3";
			this.SoulControl3.Selected = false;
			this.SoulControl3.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl3.TabIndex = 5;
			this.SoulControl3.UseVisualStyleBackColor = true;
			this.SoulControl3.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl4
			// 
			this.SoulControl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl4.Location = DPIScalingHelper.GetScaledPoint(143, 69);
			this.SoulControl4.Name = "SoulControl4";
			this.SoulControl4.Selected = false;
			this.SoulControl4.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl4.TabIndex = 11;
			this.SoulControl4.UseVisualStyleBackColor = true;
			this.SoulControl4.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl5
			// 
			this.SoulControl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl5.Location = DPIScalingHelper.GetScaledPoint(143, 146);
			this.SoulControl5.Name = "SoulControl5";
			this.SoulControl5.Selected = false;
			this.SoulControl5.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl5.TabIndex = 10;
			this.SoulControl5.UseVisualStyleBackColor = true;
			this.SoulControl5.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl6
			// 
			this.SoulControl6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl6.Location = DPIScalingHelper.GetScaledPoint(143, 222);
			this.SoulControl6.Name = "SoulControl6";
			this.SoulControl6.Selected = false;
			this.SoulControl6.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl6.TabIndex = 9;
			this.SoulControl6.UseVisualStyleBackColor = true;
			this.SoulControl6.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl7
			// 
			this.SoulControl7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl7.Location = DPIScalingHelper.GetScaledPoint(249, 69);
			this.SoulControl7.Name = "SoulControl7";
			this.SoulControl7.Selected = false;
			this.SoulControl7.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl7.TabIndex = 14;
			this.SoulControl7.UseVisualStyleBackColor = true;
			this.SoulControl7.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl8
			// 
			this.SoulControl8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl8.Location = DPIScalingHelper.GetScaledPoint(249, 146);
			this.SoulControl8.Name = "SoulControl8";
			this.SoulControl8.Selected = false;
			this.SoulControl8.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl8.TabIndex = 13;
			this.SoulControl8.UseVisualStyleBackColor = true;
			this.SoulControl8.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl9
			// 
			this.SoulControl9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl9.Location = DPIScalingHelper.GetScaledPoint(249, 222);
			this.SoulControl9.Name = "SoulControl9";
			this.SoulControl9.Selected = false;
			this.SoulControl9.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl9.TabIndex = 12;
			this.SoulControl9.UseVisualStyleBackColor = true;
			this.SoulControl9.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl10
			// 
			this.SoulControl10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl10.Location = DPIScalingHelper.GetScaledPoint(355, 69);
			this.SoulControl10.Name = "SoulControl10";
			this.SoulControl10.Selected = false;
			this.SoulControl10.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl10.TabIndex = 17;
			this.SoulControl10.UseVisualStyleBackColor = true;
			this.SoulControl10.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl11
			// 
			this.SoulControl11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl11.Location = DPIScalingHelper.GetScaledPoint(355, 146);
			this.SoulControl11.Name = "SoulControl11";
			this.SoulControl11.Selected = false;
			this.SoulControl11.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl11.TabIndex = 16;
			this.SoulControl11.UseVisualStyleBackColor = true;
			this.SoulControl11.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl12
			// 
			this.SoulControl12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl12.Location = DPIScalingHelper.GetScaledPoint(355, 222);
			this.SoulControl12.Name = "SoulControl12";
			this.SoulControl12.Selected = false;
			this.SoulControl12.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl12.TabIndex = 15;
			this.SoulControl12.UseVisualStyleBackColor = true;
			this.SoulControl12.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl13
			// 
			this.SoulControl13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl13.Location = DPIScalingHelper.GetScaledPoint(461, 69);
			this.SoulControl13.Name = "SoulControl13";
			this.SoulControl13.Selected = false;
			this.SoulControl13.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl13.TabIndex = 20;
			this.SoulControl13.UseVisualStyleBackColor = true;
			this.SoulControl13.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl14
			// 
			this.SoulControl14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl14.Location = DPIScalingHelper.GetScaledPoint(461, 146);
			this.SoulControl14.Name = "SoulControl14";
			this.SoulControl14.Selected = false;
			this.SoulControl14.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl14.TabIndex = 19;
			this.SoulControl14.UseVisualStyleBackColor = true;
			this.SoulControl14.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// SoulControl15
			// 
			this.SoulControl15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SoulControl15.Location = DPIScalingHelper.GetScaledPoint(461, 222);
			this.SoulControl15.Name = "SoulControl15";
			this.SoulControl15.Selected = false;
			this.SoulControl15.Size = DPIScalingHelper.GetScaledSize(100, 70);
			this.SoulControl15.TabIndex = 18;
			this.SoulControl15.UseVisualStyleBackColor = true;
			this.SoulControl15.SelectedChanged += SoulControl_SelectedChanged;
			// 
			// button1
			// 
			this.Page1Button.Click += OnPageButtonClick;
			this.Page1Button.Location = DPIScalingHelper.GetScaledPoint(143, 298);
			this.Page1Button.Name = "Page1Button";
			this.Page1Button.Size = DPIScalingHelper.GetScaledSize(100, 24);
			this.Page1Button.TabIndex = 6;
			this.Page1Button.Text = "1";
			this.Page1Button.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.Page2Button.Click += OnPageButtonClick;
			this.Page2Button.Location = DPIScalingHelper.GetScaledPoint(249, 298);
			this.Page2Button.Name = "Page2Button";
			this.Page2Button.Size = DPIScalingHelper.GetScaledSize(100, 24);
			this.Page2Button.TabIndex = 7;
			this.Page2Button.Text = "2";
			this.Page2Button.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.Page3Button.Click += OnPageButtonClick;
			this.Page3Button.Location = DPIScalingHelper.GetScaledPoint(355, 298);
			this.Page3Button.Name = "Page3Button";
			this.Page3Button.Size = DPIScalingHelper.GetScaledSize(100, 24);
			this.Page3Button.TabIndex = 8;
			this.Page3Button.Text = "3";
			this.Page3Button.UseVisualStyleBackColor = true;
			// 
			// VCommonSoulCollectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SoulControl13);
			this.Controls.Add(this.SoulControl14);
			this.Controls.Add(this.SoulControl15);
			this.Controls.Add(this.SoulControl10);
			this.Controls.Add(this.SoulControl11);
			this.Controls.Add(this.SoulControl12);
			this.Controls.Add(this.SoulControl7);
			this.Controls.Add(this.SoulControl8);
			this.Controls.Add(this.SoulControl9);
			this.Controls.Add(this.SoulControl4);
			this.Controls.Add(this.SoulControl5);
			this.Controls.Add(this.SoulControl6);
			this.Controls.Add(this.Page3Button);
			this.Controls.Add(this.Page2Button);
			this.Controls.Add(this.Page1Button);
			this.Controls.Add(this.SoulControl3);
			this.Controls.Add(this.SoulControl2);
			this.Controls.Add(this.SoulControl1);
			this.Controls.Add(this.RemainingPowerSoulsLabel);
			this.Controls.Add(this.TotalUniquesLabel);
			this.Controls.Add(this.TitleLabel);
			this.Name = "VCommonSoulCollectionControl";
			this.Size = DPIScalingHelper.GetScaledSize(575, 342);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		protected BindingSource BindingSource;
		private VLabel TitleLabel;
		private VLabel TotalUniquesLabel;
		private VLabel RemainingPowerSoulsLabel;
		protected SingleSoulControl SoulControl1;
		protected SingleSoulControl SoulControl2;
		protected SingleSoulControl SoulControl3;
		protected SingleSoulControl SoulControl4;
		protected SingleSoulControl SoulControl5;
		protected SingleSoulControl SoulControl6;
		protected SingleSoulControl SoulControl7;
		protected SingleSoulControl SoulControl8;
		protected SingleSoulControl SoulControl9;
		protected SingleSoulControl SoulControl10;
		protected SingleSoulControl SoulControl11;
		protected SingleSoulControl SoulControl12;
		protected SingleSoulControl SoulControl13;
		protected SingleSoulControl SoulControl14;
		protected SingleSoulControl SoulControl15;
		protected DPIButton Page1Button;
		protected DPIButton Page2Button;
		protected DPIButton Page3Button;
	}
}
