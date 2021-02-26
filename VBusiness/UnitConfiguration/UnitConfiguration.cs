using VEntityFramework.Model;
using VBusiness.Perks;
using VBusiness.HelperClasses;

namespace VBusiness
{
	public class UnitConfiguration : VUnitConfiguration
	{
		// Torment Reduction

		// toggle adrenaline rush

		#region Constructor

		public UnitConfiguration(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region HasSoloBonus

		public override bool HasSoloBonus
		{
			get => base.HasSoloBonus;
			set
			{
				if (base.HasSoloBonus != value)
				{
					base.HasSoloBonus = value;
					TriggerSoloBonus();
				}
			}
		} 

		void TriggerSoloBonus()
		{
			if (HasSoloBonus)
			{
				Loadout.Stats.Attack += 30;
				Loadout.Stats.UpdateAttackSpeed("Core", 20);
				Loadout.Stats.Health += 25;
				Loadout.Stats.HealthArmor += 20;
				Loadout.Stats.Shields += 25;
				Loadout.Stats.ShieldsArmor += 20;
			}
			else
			{
				Loadout.Stats.Attack -= 30;
				Loadout.Stats.UpdateAttackSpeed("Core", -20);
				Loadout.Stats.Health -= 25;
				Loadout.Stats.HealthArmor -= 20;
				Loadout.Stats.Shields -= 25;
				Loadout.Stats.ShieldsArmor -= 20;
			}
		}

		#endregion

		#region DifficultyLevel

		public override DifficultyLevel DifficultyLevel
		{
			get => base.DifficultyLevel;
			set
			{
				if (base.DifficultyLevel != value)
				{
					base.DifficultyLevel = value;
					Difficulty = DifficultyHelper.New(value);
				}
			}
		}

		#endregion

		#region Difficulty

		public override VDifficulty Difficulty
		{
			get => base.Difficulty;
			set
			{
				if (base.Difficulty != value)
				{
					var oldDiff = base.Difficulty;
					base.Difficulty = value;
					UpdateDifficulty(oldDiff);
				}
			}
		}

		void UpdateDifficulty(VDifficulty oldDiff)
		{
			UpdateTormentReduction(oldDiff);
		}

		void UpdateTormentReduction(VDifficulty oldDiff)
		{
			var oldTormentReduction = oldDiff?.TormentReduction ?? 0;
			var newTormentReduction = Difficulty.TormentReduction;
			var difference = newTormentReduction - oldTormentReduction;

			if (difference != 0)
			{
				Loadout.Stats.Attack -= difference;
				Loadout.Stats.UpdateAttackSpeed("Core", -difference);
				Loadout.Stats.Health -= difference;
				Loadout.Stats.HealthArmor -= difference;
				Loadout.Stats.Shields -= difference;
				Loadout.Stats.ShieldsArmor -= difference;
				Loadout.Stats.Acceleration -= difference;
			}
		}

		#endregion

		#endregion

		#region Methods

		#endregion
	}
}