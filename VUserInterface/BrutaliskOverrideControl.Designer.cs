
using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class BrutaliskOverrideControl
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CheckBox1 = new VCheckBox();
			this.CheckBox2 = new VCheckBox();
			this.CheckBox3 = new VCheckBox();
			this.CheckBox4 = new VCheckBox();
			this.CheckBox5 = new VCheckBox();
			this.CheckBox6 = new VCheckBox();
			this.bindingSource = new VBindingSource();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(VBrutaliskOverride);
			//
			// CheckBox1
			//
			this.CheckBox1.AutoSize = false;
			this.CheckBox1.DataBindings.Add("CheckState", bindingSource, "Bruta1", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox1.Location = DPIScalingHelper.GetScaledPoint(0, 0);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CheckBox2
			//
			this.CheckBox2.AutoSize = false;
			this.CheckBox2.DataBindings.Add("CheckState", bindingSource, "Bruta2", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox2.Location = DPIScalingHelper.GetScaledPoint(20, 0);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CheckBox3
			//
			this.CheckBox3.AutoSize = false;
			this.CheckBox3.DataBindings.Add("CheckState", bindingSource, "Bruta3", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox3.Location = DPIScalingHelper.GetScaledPoint(40, 0);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CheckBox4
			//
			this.CheckBox4.AutoSize = false;
			this.CheckBox4.DataBindings.Add("CheckState", bindingSource, "Bruta4", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox4.Location = DPIScalingHelper.GetScaledPoint(60, 0);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CheckBox5
			//
			this.CheckBox5.AutoSize = false;
			this.CheckBox5.DataBindings.Add("CheckState", bindingSource, "Bruta5", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox5.Location = DPIScalingHelper.GetScaledPoint(80, 0);
			this.CheckBox5.Name = "CheckBox5";
			this.CheckBox5.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CheckBox6
			//
			this.CheckBox6.AutoSize = false;
			this.CheckBox6.DataBindings.Add("CheckState", bindingSource, "Bruta6", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
			this.CheckBox6.Location = DPIScalingHelper.GetScaledPoint(100, 0);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = DPIScalingHelper.GetScaledSize(20, 20);
			//
			// CoreControl
			//
			this.CoreControl.Controls.Add(CheckBox1);
			this.CoreControl.Controls.Add(CheckBox2);
			this.CoreControl.Controls.Add(CheckBox3);
			this.CoreControl.Controls.Add(CheckBox4);
			this.CoreControl.Controls.Add(CheckBox5);
			this.CoreControl.Controls.Add(CheckBox6);
			//
			// BrutaliskOverrideControl
			//
			this.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
			this.Size = DPIScalingHelper.GetScaledSize(121, 21);
		}

		#endregion

		private BindingSource bindingSource;
		private CheckBox CheckBox1;
		private CheckBox CheckBox2;
		private CheckBox CheckBox3;
		private CheckBox CheckBox4;
		private CheckBox CheckBox5;
		private CheckBox CheckBox6;
	}
}
