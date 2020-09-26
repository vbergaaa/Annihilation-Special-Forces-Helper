using System.Reflection.Emit;
using System.Windows.Forms.VisualStyles;
using VBusiness.ChallengePoints;
using VEntityFramework;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class ChallengePointControl
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
			this.CostLabel = new VLabel();
			this.CurrentLevelIncrementor = new VIncrementor();
			this.CostCaption = new VLabel();
			this.bindingSource = new System.Windows.Forms.BindingSource();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			// 
			// CostCaption
			// 
			this.CostCaption.AutoSize = true;
			this.CostCaption.Location = new System.Drawing.Point(40, 29);
			this.CostCaption.Name = "CostCaption";
			this.CostCaption.TabIndex = 6;
			this.CostCaption.Text = "Cost";
			this.CostCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CostLabel
			// 
			this.CostLabel.AutoSize = true;
			this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "NextLevelCost"));
			this.CostLabel.Location = new System.Drawing.Point(110, 29);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.TabIndex = 6;
			this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// CurrentLevelIncrementor
			//
			this.CurrentLevelIncrementor.Location = new System.Drawing.Point(48, 1);
			this.CurrentLevelIncrementor.DataBindings.Add("Value", bindingSource, "CurrentLevel");
			this.CurrentLevelIncrementor.DataBindings.Add("MaxValue", bindingSource, "MaxValue");
			this.CurrentLevelIncrementor.DataBindings.Add("MinValue", bindingSource, "MinValue");
			this.CurrentLevelIncrementor.DisableShiftClick = true;
			this.CurrentLevelIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.CurrentLevelIncrementor.MinValue = 0;
			// 
			// ChallengePointBindingSource
			// 
			this.bindingSource.DataSource = typeof(ChallengePoint);
			// 
			// VChallengePointControl
			// 
			this.Controls.Add(this.CostLabel);
			this.Controls.Add(this.CurrentLevelIncrementor);
			this.Controls.Add(this.CostCaption);
			this.Size = new System.Drawing.Size(160, 50);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		private System.Windows.Forms.Label CostLabel;
		private VIncrementor CurrentLevelIncrementor;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.Label CostCaption;
	}
}
