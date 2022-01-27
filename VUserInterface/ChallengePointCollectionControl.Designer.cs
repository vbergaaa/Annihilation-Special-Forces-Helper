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
			this.bindingSource = new VBindingSource();
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
			this.AvailableChallengePointsLabel = new VLabel();
			this.RemainingChallengePointsLabel = new VLabel();
			this.OptimiseForDamageButton = new VButton();
			this.OptimiseForToughnessButton = new VButton();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(ChallengePointCollection);
			//
			// AvailableChallengePointsLabel
			//
			this.AvailableChallengePointsLabel.Caption = "Available CP:";
			this.AvailableChallengePointsLabel.DataBindings.Add("Text", bindingSource, "TotalCost");
			this.AvailableChallengePointsLabel.Location = DPIScalingHelper.GetScaledPoint(200, 0);
			this.AvailableChallengePointsLabel.Name = "AvailableChallengePointsLabel";
			this.AvailableChallengePointsLabel.Size = DPIScalingHelper.GetScaledSize(100, 25);
			//
			// RemainingChallengePointsLabel
			//
			this.RemainingChallengePointsLabel.Caption = "Remaining CP:";
			this.RemainingChallengePointsLabel.DataBindings.Add("Text", bindingSource, "RemainingCP");
			this.RemainingChallengePointsLabel.Location = DPIScalingHelper.GetScaledPoint(450, 0);
			this.RemainingChallengePointsLabel.Name = "RemainingChallengePointsLabel";
			this.RemainingChallengePointsLabel.Size = DPIScalingHelper.GetScaledSize(100, 25);
			//
			// AttackCPControl
			//
			this.AttackCPControl.Caption = "Attack";
			this.AttackCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Attack");
			this.AttackCPControl.Location = DPIScalingHelper.GetScaledPoint(35, 50);
			//
			// CriticalDamageCPControl
			//
			this.CriticalDamageCPControl.Caption = "Crit Dmg";
			this.CriticalDamageCPControl.DataBindings.Add("ChallengePoint", bindingSource, "CriticalDamage");
			this.CriticalDamageCPControl.Location = DPIScalingHelper.GetScaledPoint(30, 110);
			//
			// CriticalChanceCPControl
			//
			this.CriticalChanceCPControl.Caption = "Crit Chance";
			this.CriticalChanceCPControl.DataBindings.Add("ChallengePoint", bindingSource, "CriticalChance");
			this.CriticalChanceCPControl.Location = DPIScalingHelper.GetScaledPoint(30, 170);
			//
			// AttackSpeedCPControl
			//
			this.AttackSpeedCPControl.Caption = "Atk Speed";
			this.AttackSpeedCPControl.DataBindings.Add("ChallengePoint", bindingSource, "AttackSpeed");
			this.AttackSpeedCPControl.Location = DPIScalingHelper.GetScaledPoint(30, 230);
			//
			// HealthCPControl
			//
			this.HealthCPControl.Caption = "Health";
			this.HealthCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Health");
			this.HealthCPControl.Location = DPIScalingHelper.GetScaledPoint(208, 50);
			//
			// ShieldsCPControl
			//
			this.ShieldsCPControl.Caption = "Shields";
			this.ShieldsCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Shields");
			this.ShieldsCPControl.Location = DPIScalingHelper.GetScaledPoint(208, 110);
			//
			// DefensiveEssenceCPControl
			//
			this.DefensiveEssenceCPControl.Caption = "Def Ess";
			this.DefensiveEssenceCPControl.DataBindings.Add("ChallengePoint", bindingSource, "DefensiveEssence");
			this.DefensiveEssenceCPControl.Location = DPIScalingHelper.GetScaledPoint(208, 170);
			//
			// DamageReductionCPControl
			//
			this.DamageReductionCPControl.Caption = "Dmg Rdct";
			this.DamageReductionCPControl.DataBindings.Add("ChallengePoint", bindingSource, "DamageReduction");
			this.DamageReductionCPControl.Location = DPIScalingHelper.GetScaledPoint(208, 230);
			//
			// MiningCPControl
			//
			this.MiningCPControl.Caption = "Mining";
			this.MiningCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Mining");
			this.MiningCPControl.Location = DPIScalingHelper.GetScaledPoint(381, 50);
			//
			// KillsCPControl
			//
			this.KillsCPControl.Caption = "Kills";
			this.KillsCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Kills");
			this.KillsCPControl.Location = DPIScalingHelper.GetScaledPoint(381, 110);
			//
			// VeterancyCPControl
			//
			this.VeterancyCPControl.Caption = "Vet";
			this.VeterancyCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Veterancy");
			this.VeterancyCPControl.Location = DPIScalingHelper.GetScaledPoint(381, 170);
			//
			// AccelCPControl
			//
			this.AccelCPControl.Caption = "Accel";
			this.AccelCPControl.DataBindings.Add("ChallengePoint", bindingSource, "Acceleration");
			this.AccelCPControl.Location = DPIScalingHelper.GetScaledPoint(381, 230);
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
			// ChallengePointCollectionControl
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScaleDimensions = DPIScalingHelper.AutoSizeDimensions;
			this.Controls.Add(AvailableChallengePointsLabel);
			this.Controls.Add(RemainingChallengePointsLabel);
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
			this.Controls.Add(OptimiseForDamageButton);
			this.Controls.Add(OptimiseForToughnessButton);
			this.Size = DPIScalingHelper.GetScaledSize(589, 292);
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
		private VButton OptimiseForDamageButton;
		private VButton OptimiseForToughnessButton;
		VLabel AvailableChallengePointsLabel;
		VLabel RemainingChallengePointsLabel;
	}
}
