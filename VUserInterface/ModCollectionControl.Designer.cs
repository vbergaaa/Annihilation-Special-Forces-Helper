
using EnumsNET;
using System.Linq;
using System.Windows.Forms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	partial class ModCollectionControl
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
			this.TotalModScoreLabel = new VLabel();
			this.DifficultyDropBox = new VDropBox();
			this.BindingSource = new VBindingSource();
			this.DamageIncrementor = new VIncrementor();
			this.HealthIncrementor = new VIncrementor();
			this.ArmorIncrementor = new VIncrementor();
			this.SelfMitigationIncrementor = new VIncrementor();
			this.SpeedIncrementor = new VIncrementor();
			this.DamageReductionIncrementor = new VIncrementor();
			this.DifficultyIncrementor = new VIncrementor();
			this.PotencyIncrementor = new VIncrementor();
			this.TaxesIncrementor = new VIncrementor();
			this.RankIncrementor = new VIncrementor();
			this.TierIncrementor = new VIncrementor();
			this.ScarcityIncrementor = new VIncrementor();
			this.BountylessIncrementor = new VIncrementor();
			this.UnwellIncrementor = new VIncrementor();
			this.RankReversionIncrementor = new VIncrementor();
			this.BossPowerIncrementor = new VIncrementor();
			this.CriticalMiscalculationIncrementor = new VIncrementor();
			this.GlassCannonIncrementor = new VIncrementor();
			this.SupplyIncrementor = new VIncrementor();
			this.VolatileDeadIncrementor = new VIncrementor();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			//
			// BindingSource
			//
			this.BindingSource.DataSource = typeof(VModsCollection);
			//
			// TotalModScoreLabel
			//
			this.TotalModScoreLabel.DataBindings.Add("Text", BindingSource, "TotalModScore", true, DataSourceUpdateMode.OnPropertyChanged);
			this.TotalModScoreLabel.Caption = "Score";
			this.TotalModScoreLabel.Name = "TotalModScoreLabel";
			this.TotalModScoreLabel.Location = DPIScalingHelper.GetScaledPoint(100, 30);
			this.TotalModScoreLabel.Size = DPIScalingHelper.GetScaledSize(29, 50);
			//
			// DifficultyDropBox
			//
			this.DifficultyDropBox.DataBindings.Add("SelectedValue", BindingSource, "Loadout.UnitConfiguration.DifficultyLevel");
			this.DifficultyDropBox.Caption = "Difficulty";
			this.DifficultyDropBox.Name = "DifficultyDropBox";
			this.DifficultyDropBox.List = Enums.GetValues<DifficultyLevel>().Cast<object>().ToList();
			this.DifficultyDropBox.Location = DPIScalingHelper.GetScaledPoint(300, 30);
			//
			// DamageIncrementor
			//
			this.DamageIncrementor.DataBindings.Add("Caption", BindingSource, "Damage.Name");
			this.DamageIncrementor.DataBindings.Add("Value", BindingSource, "Damage.CurrentLevel");
			this.DamageIncrementor.DataBindings.Add("MaxValue", BindingSource, "Damage.MaxValue");
			this.DamageIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.DamageIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 70);
			this.DamageIncrementor.Name = "DamageIncrementor";
			this.DamageIncrementor.TabIndex = 1;
			//
			// HealthIncrementor
			//
			this.HealthIncrementor.DataBindings.Add("Caption", BindingSource, "Health.Name");
			this.HealthIncrementor.DataBindings.Add("Value", BindingSource, "Health.CurrentLevel");
			this.HealthIncrementor.DataBindings.Add("MaxValue", BindingSource, "Health.MaxValue");
			this.HealthIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.HealthIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 70);
			this.HealthIncrementor.Name = "HealthIncrementor";
			this.HealthIncrementor.TabIndex = 1;
			//
			// ArmorIncrementor
			//
			this.ArmorIncrementor.DataBindings.Add("Caption", BindingSource, "Armor.Name");
			this.ArmorIncrementor.DataBindings.Add("Value", BindingSource, "Armor.CurrentLevel");
			this.ArmorIncrementor.DataBindings.Add("MaxValue", BindingSource, "Armor.MaxValue");
			this.ArmorIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.ArmorIncrementor.Location = DPIScalingHelper.GetScaledPoint(500, 70);
			this.ArmorIncrementor.Name = "ArmorIncrementor";
			this.ArmorIncrementor.TabIndex = 1;
			//
			// SelfMitigationIncrementor
			//
			this.SelfMitigationIncrementor.DataBindings.Add("Caption", BindingSource, "SelfMitigation.Name");
			this.SelfMitigationIncrementor.DataBindings.Add("Value", BindingSource, "SelfMitigation.CurrentLevel");
			this.SelfMitigationIncrementor.DataBindings.Add("MaxValue", BindingSource, "SelfMitigation.MaxValue");
			this.SelfMitigationIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.SelfMitigationIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 100);
			this.SelfMitigationIncrementor.Name = "SelfMitigationIncrementor";
			this.SelfMitigationIncrementor.TabIndex = 1;
			//
			// SpeedIncrementor
			//
			this.SpeedIncrementor.DataBindings.Add("Caption", BindingSource, "Speed.Name");
			this.SpeedIncrementor.DataBindings.Add("Value", BindingSource, "Speed.CurrentLevel");
			this.SpeedIncrementor.DataBindings.Add("MaxValue", BindingSource, "Speed.MaxValue");
			this.SpeedIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.SpeedIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 100);
			this.SpeedIncrementor.Name = "SpeedIncrementor";
			this.SpeedIncrementor.TabIndex = 1;
			//
			// DamageReductionIncrementor
			//
			this.DamageReductionIncrementor.DataBindings.Add("Caption", BindingSource, "DamageReduction.Name");
			this.DamageReductionIncrementor.DataBindings.Add("Value", BindingSource, "DamageReduction.CurrentLevel");
			this.DamageReductionIncrementor.DataBindings.Add("MaxValue", BindingSource, "DamageReduction.MaxValue");
			this.DamageReductionIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.DamageReductionIncrementor.Location = DPIScalingHelper.GetScaledPoint(500, 100);
			this.DamageReductionIncrementor.Name = "DamageReductionIncrementor";
			this.DamageReductionIncrementor.TabIndex = 1;
			//
			// DifficultyIncrementor
			//
			this.DifficultyIncrementor.DataBindings.Add("Caption", BindingSource, "Difficulty.Name");
			this.DifficultyIncrementor.DataBindings.Add("Value", BindingSource, "Difficulty.CurrentLevel");
			this.DifficultyIncrementor.DataBindings.Add("MaxValue", BindingSource, "Difficulty.MaxValue");
			this.DifficultyIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.DifficultyIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 130);
			this.DifficultyIncrementor.Name = "DifficultyIncrementor";
			this.DifficultyIncrementor.TabIndex = 1;
			//
			// PotencyIncrementor
			//
			this.PotencyIncrementor.DataBindings.Add("Caption", BindingSource, "Potency.Name");
			this.PotencyIncrementor.DataBindings.Add("Value", BindingSource, "Potency.CurrentLevel");
			this.PotencyIncrementor.DataBindings.Add("MaxValue", BindingSource, "Potency.MaxValue");
			this.PotencyIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.PotencyIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 130);
			this.PotencyIncrementor.Name = "PotencyIncrementor";
			this.PotencyIncrementor.TabIndex = 1;
			//
			// TaxesIncrementor
			//
			this.TaxesIncrementor.DataBindings.Add("Caption", BindingSource, "Taxes.Name");
			this.TaxesIncrementor.DataBindings.Add("Value", BindingSource, "Taxes.CurrentLevel");
			this.TaxesIncrementor.DataBindings.Add("MaxValue", BindingSource, "Taxes.MaxValue");
			this.TaxesIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.TaxesIncrementor.Location = DPIScalingHelper.GetScaledPoint(500, 130);
			this.TaxesIncrementor.Name = "TaxesIncrementor";
			this.TaxesIncrementor.TabIndex = 1;
			//
			// RankIncrementor
			//
			this.RankIncrementor.DataBindings.Add("Caption", BindingSource, "Rank.Name");
			this.RankIncrementor.DataBindings.Add("Value", BindingSource, "Rank.CurrentLevel");
			this.RankIncrementor.DataBindings.Add("MaxValue", BindingSource, "Rank.MaxValue");
			this.RankIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.RankIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 160);
			this.RankIncrementor.Name = "RankIncrementor";
			this.RankIncrementor.TabIndex = 1;
			//
			// TierIncrementor
			//
			this.TierIncrementor.DataBindings.Add("Caption", BindingSource, "Tier.Name");
			this.TierIncrementor.DataBindings.Add("Value", BindingSource, "Tier.CurrentLevel");
			this.TierIncrementor.DataBindings.Add("MaxValue", BindingSource, "Tier.MaxValue");
			this.TierIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.TierIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 160);
			this.TierIncrementor.Name = "TierIncrementor";
			this.TierIncrementor.TabIndex = 1;
			//
			// ScarcityIncrementor
			//
			this.ScarcityIncrementor.DataBindings.Add("Caption", BindingSource, "Scarcity.Name");
			this.ScarcityIncrementor.DataBindings.Add("Value", BindingSource, "Scarcity.CurrentLevel");
			this.ScarcityIncrementor.DataBindings.Add("MaxValue", BindingSource, "Scarcity.MaxValue");
			this.ScarcityIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.ScarcityIncrementor.Location = DPIScalingHelper.GetScaledPoint(500, 160);
			this.ScarcityIncrementor.Name = "ScarcityIncrementor";
			this.ScarcityIncrementor.TabIndex = 1;
			//
			// BountylessIncrementor
			//
			this.BountylessIncrementor.DataBindings.Add("Caption", BindingSource, "Bountyless.Name");
			this.BountylessIncrementor.DataBindings.Add("Value", BindingSource, "Bountyless.CurrentLevel");
			this.BountylessIncrementor.DataBindings.Add("MaxValue", BindingSource, "Bountyless.MaxValue");
			this.BountylessIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.BountylessIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 190);
			this.BountylessIncrementor.Name = "BountylessIncrementor";
			this.BountylessIncrementor.TabIndex = 1;
			//
			// UnwellIncrementor
			//
			this.UnwellIncrementor.DataBindings.Add("Caption", BindingSource, "Unwell.Name");
			this.UnwellIncrementor.DataBindings.Add("Value", BindingSource, "Unwell.CurrentLevel");
			this.UnwellIncrementor.DataBindings.Add("MaxValue", BindingSource, "Unwell.MaxValue");
			this.UnwellIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.UnwellIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 190);
			this.UnwellIncrementor.Name = "UnwellIncrementor";
			this.UnwellIncrementor.TabIndex = 1;
			//
			// RankReversionIncrementor
			//
			this.RankReversionIncrementor.DataBindings.Add("Caption", BindingSource, "RankReversion.Name");
			this.RankReversionIncrementor.DataBindings.Add("Value", BindingSource, "RankReversion.CurrentLevel");
			this.RankReversionIncrementor.DataBindings.Add("MaxValue", BindingSource, "RankReversion.MaxValue");
			this.RankReversionIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.RankReversionIncrementor.Location = DPIScalingHelper.GetScaledPoint(500, 190);
			this.RankReversionIncrementor.Name = "RankReversionIncrementor";
			this.RankReversionIncrementor.TabIndex = 1;
			//
			// BossPowerIncrementor
			//
			this.BossPowerIncrementor.DataBindings.Add("Caption", BindingSource, "BossPower.Name");
			this.BossPowerIncrementor.DataBindings.Add("Value", BindingSource, "BossPower.CurrentLevel");
			this.BossPowerIncrementor.DataBindings.Add("MaxValue", BindingSource, "BossPower.MaxValue");
			this.BossPowerIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.BossPowerIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 220);
			this.BossPowerIncrementor.Name = "BossPowerIncrementor";
			this.BossPowerIncrementor.TabIndex = 1;
			//
			// CriticalMiscalculationIncrementor
			//
			this.CriticalMiscalculationIncrementor.DataBindings.Add("Caption", BindingSource, "CriticalMiscalculation.Name");
			this.CriticalMiscalculationIncrementor.DataBindings.Add("Value", BindingSource, "CriticalMiscalculation.CurrentLevel");
			this.CriticalMiscalculationIncrementor.DataBindings.Add("MaxValue", BindingSource, "CriticalMiscalculation.MaxValue");
			this.CriticalMiscalculationIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.CriticalMiscalculationIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 220);
			this.CriticalMiscalculationIncrementor.Name = "CriticalMiscalculationIncrementor";
			this.CriticalMiscalculationIncrementor.TabIndex = 1;
			//
			// GlassCannonIncrementor
			//
			this.GlassCannonIncrementor.DataBindings.Add("Caption", BindingSource, "GlassCannon.Name");
			this.GlassCannonIncrementor.DataBindings.Add("Value", BindingSource, "GlassCannon.CurrentLevel");
			this.GlassCannonIncrementor.DataBindings.Add("MaxValue", BindingSource, "GlassCannon.MaxValue");
			this.GlassCannonIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.GlassCannonIncrementor.Location = DPIScalingHelper.GetScaledPoint(500, 220);
			this.GlassCannonIncrementor.Name = "GlassCannonIncrementor";
			this.GlassCannonIncrementor.TabIndex = 1;
			//
			// SupplyIncrementor
			//
			this.SupplyIncrementor.DataBindings.Add("Caption", BindingSource, "Supply.Name");
			this.SupplyIncrementor.DataBindings.Add("Value", BindingSource, "Supply.CurrentLevel");
			this.SupplyIncrementor.DataBindings.Add("MaxValue", BindingSource, "Supply.MaxValue");
			this.SupplyIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.SupplyIncrementor.Location = DPIScalingHelper.GetScaledPoint(100, 250);
			this.SupplyIncrementor.Name = "SupplyIncrementor";
			this.SupplyIncrementor.TabIndex = 1;
			//
			// VolatileDeadIncrementor
			//
			this.VolatileDeadIncrementor.DataBindings.Add("Caption", BindingSource, "VolatileDead.Name");
			this.VolatileDeadIncrementor.DataBindings.Add("Value", BindingSource, "VolatileDead.CurrentLevel");
			this.VolatileDeadIncrementor.DataBindings.Add("MaxValue", BindingSource, "VolatileDead.MaxValue");
			this.VolatileDeadIncrementor.IncrementorStyle = IncrementorStyle.Compact;
			this.VolatileDeadIncrementor.Location = DPIScalingHelper.GetScaledPoint(300, 250);
			this.VolatileDeadIncrementor.Name = "VolatileDeadIncrementor";
			this.VolatileDeadIncrementor.TabIndex = 1;
			//
			// ModCollectionControl
			//
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(TotalModScoreLabel);
			this.Controls.Add(DifficultyDropBox);
			this.Controls.Add(DamageIncrementor);
			this.Controls.Add(HealthIncrementor);
			this.Controls.Add(ArmorIncrementor);
			this.Controls.Add(SelfMitigationIncrementor);
			this.Controls.Add(SpeedIncrementor);
			this.Controls.Add(DamageReductionIncrementor);
			this.Controls.Add(DifficultyIncrementor);
			this.Controls.Add(PotencyIncrementor);
			this.Controls.Add(TaxesIncrementor);
			this.Controls.Add(RankIncrementor);
			this.Controls.Add(TierIncrementor);
			this.Controls.Add(ScarcityIncrementor);
			this.Controls.Add(BountylessIncrementor);
			this.Controls.Add(UnwellIncrementor);
			this.Controls.Add(RankReversionIncrementor);
			this.Controls.Add(BossPowerIncrementor);
			this.Controls.Add(CriticalMiscalculationIncrementor);
			this.Controls.Add(GlassCannonIncrementor);
			this.Controls.Add(SupplyIncrementor);
			this.Controls.Add(VolatileDeadIncrementor);
		}

		#endregion

		VLabel TotalModScoreLabel;
		VDropBox DifficultyDropBox;
		BindingSource BindingSource;
		VIncrementor DamageIncrementor;
		VIncrementor HealthIncrementor;
		VIncrementor ArmorIncrementor;
		VIncrementor SelfMitigationIncrementor;
		VIncrementor SpeedIncrementor;
		VIncrementor DamageReductionIncrementor;
		VIncrementor DifficultyIncrementor;
		VIncrementor PotencyIncrementor;
		VIncrementor TaxesIncrementor;
		VIncrementor RankIncrementor;
		VIncrementor TierIncrementor;
		VIncrementor ScarcityIncrementor;
		VIncrementor BountylessIncrementor;
		VIncrementor UnwellIncrementor;
		VIncrementor RankReversionIncrementor;
		VIncrementor BossPowerIncrementor;
		VIncrementor CriticalMiscalculationIncrementor;
		VIncrementor GlassCannonIncrementor;
		VIncrementor SupplyIncrementor;
		VIncrementor VolatileDeadIncrementor;
	}
}
