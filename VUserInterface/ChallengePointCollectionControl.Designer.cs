using System.Security.AccessControl;
using System.Windows.Forms;
using VBusiness.ChallengePoints;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class ChallengePointCollectionControl
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
			this.AttackCPControl = new ChallengePointControl();
			this.CriticalChanceCPControl = new ChallengePointControl();
			this.CriticalDamageCPControl = new ChallengePointControl();
			this.AttackSpeedCPControl = new ChallengePointControl();
			this.HealthCPControl = new ChallengePointControl();
			this.ShieldsCPControl = new ChallengePointControl();
			this.DefensiveEssenceCPControl = new ChallengePointControl();
			this.DamageReductionCPControl = new ChallengePointControl();
			this.MiningCPControl = new ChallengePointControl();
			this.KillsCPControl = new ChallengePointControl();
			this.VeterancyCPControl = new ChallengePointControl();
			this.AccelCPControl = new ChallengePointControl();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(ChallengePointCollection);
			//
			// AttackCPControl
			//
			this.AttackCPControl.Caption = "Attack";
			this.AttackCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Attack");
			this.AttackCPControl.Location = new System.Drawing.Point(35, 20);
			//
			// CriticalDamageCPControl
			//
			this.CriticalDamageCPControl.Caption = "Crit Dmg";
			this.CriticalDamageCPControl.DataBindings.Add("ChallengePoint", bindingSource, "CriticalDamage");
			this.CriticalDamageCPControl.Location = new System.Drawing.Point(30, 80);
			//
			// CriticalChanceCPControl
			//
			this.CriticalChanceCPControl.Caption = "Crit Chance";
			this.CriticalChanceCPControl.DataBindings.Add("ChallengePoint", bindingSource, "CriticalChance");
			this.CriticalChanceCPControl.Location = new System.Drawing.Point(30, 140);
			//
			// AttackSpeedCPControl
			//
			this.AttackSpeedCPControl.Caption = "Atk Speed";
			this.AttackSpeedCPControl.DataBindings.Add("ChallengePoint", bindingSource, "AttackSpeed");
			this.AttackSpeedCPControl.Location = new System.Drawing.Point(30, 200);
			//
			// HealthCPControl
			//
			this.HealthCPControl.Caption = "Health";
			this.HealthCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Health");
			this.HealthCPControl.Location = new System.Drawing.Point(208, 20);
			//
			// ShieldsCPControl
			//
			this.ShieldsCPControl.Caption = "Shields";
			this.ShieldsCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Shields");
			this.ShieldsCPControl.Location = new System.Drawing.Point(208, 80);
			//
			// DefensiveEssenceCPControl
			//
			this.DefensiveEssenceCPControl.Caption = "Def Ess";
			this.DefensiveEssenceCPControl.DataBindings.Add("ChallengePoint", bindingSource, "DefensiveEssence");
			this.DefensiveEssenceCPControl.Location = new System.Drawing.Point(208, 140);
			//
			// DamageReductionCPControl
			//
			this.DamageReductionCPControl.Caption = "Dmg Rdct";
			this.DamageReductionCPControl.DataBindings.Add("ChallengePoint", bindingSource, "DamageReduction");
			this.DamageReductionCPControl.Location = new System.Drawing.Point(208, 200);
			//
			// MiningCPControl
			//
			this.MiningCPControl.Caption = "Mining";
			this.MiningCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Mining");
			this.MiningCPControl.Location = new System.Drawing.Point(381, 20);
			//
			// KillsCPControl
			//
			this.KillsCPControl.Caption = "Kills";
			this.KillsCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Kills");
			this.KillsCPControl.Location = new System.Drawing.Point(381, 80);
			//
			// VeterancyCPControl
			//
			this.VeterancyCPControl.Caption = "Vet";
			this.VeterancyCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Veterancy");
			this.VeterancyCPControl.Location = new System.Drawing.Point(381, 140);
			//
			// AccelCPControl
			//
			this.AccelCPControl.Caption = "Accel";
			this.AccelCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Acceleration");
			this.AccelCPControl.Location = new System.Drawing.Point(381, 200);
			//
			// ChallengePointCollectionControl
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.Controls.Add(AttackCPControl);
			this.Controls.Add(CriticalChanceCPControl);
			this.Controls.Add(CriticalDamageCPControl);
			this.Controls.Add(AttackSpeedCPControl);
			this.Controls.Add(HealthCPControl);
			this.Controls.Add(ShieldsCPControl);
			this.Controls.Add(DefensiveEssenceCPControl);
			this.Controls.Add(DamageReductionCPControl);
			this.Controls.Add(MiningCPControl);
			this.Controls.Add(KillsCPControl);
			this.Controls.Add(VeterancyCPControl);
			this.Controls.Add(AccelCPControl);
			this.Size = new System.Drawing.Size(589, 292);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
		}

		#endregion

		private BindingSource bindingSource;
		private ChallengePointControl AttackCPControl;
		private ChallengePointControl CriticalChanceCPControl;
		private ChallengePointControl CriticalDamageCPControl;
		private ChallengePointControl AttackSpeedCPControl;
		private ChallengePointControl HealthCPControl;
		private ChallengePointControl ShieldsCPControl;
		private ChallengePointControl DefensiveEssenceCPControl;
		private ChallengePointControl DamageReductionCPControl;
		private ChallengePointControl MiningCPControl;
		private ChallengePointControl KillsCPControl;
		private ChallengePointControl VeterancyCPControl;
		private ChallengePointControl AccelCPControl;
	}
}
