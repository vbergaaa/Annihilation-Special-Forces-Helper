using VEntityFramework.Model;
using VBusiness.Perks;
using VBusiness.HelperClasses;
using VBusiness.Difficulties;

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
				Loadout.Stats.UpdateHealth("Core", 25);
				Loadout.Stats.HealthArmor += 20;
				Loadout.Stats.UpdateShields("Core", 25);
				Loadout.Stats.ShieldsArmor += 20;
			}
			else
			{
				Loadout.Stats.Attack -= 30;
				Loadout.Stats.UpdateAttackSpeed("Core", -20);
				Loadout.Stats.UpdateHealth("Core", 25);
				Loadout.Stats.HealthArmor -= 20;
				Loadout.Stats.UpdateShields("Core", -25);
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

					Difficulty = value != DifficultyLevel.None
						? Difficulty = DifficultyHelper.New(value)
						: null;
					Loadout.Stats.RefreshPropertyBinding("Toughness");
					Loadout.Stats.RefreshPropertyBinding("Damage");
				}
			}
		}

		#endregion

		#region Difficulty

		public override VDifficulty Difficulty
		{
			get => base.Difficulty ?? new Normal(); //TODO: make this default to recommended from player rank
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
			UpdateCritReduction(oldDiff);
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
				Loadout.Stats.UpdateHealth("Core", -difference);
				Loadout.Stats.HealthArmor -= difference;
				Loadout.Stats.UpdateHealth("Core", -difference);
				Loadout.Stats.ShieldsArmor -= difference;
				Loadout.Stats.Acceleration -= difference;
			}
		}

		void UpdateCritReduction(VDifficulty oldDiff)
		{
			var oldCritReduction = oldDiff?.CritReduction ?? 0;
			var newCritReduction = Difficulty.CritReduction;
			var difference = newCritReduction - oldCritReduction;

			if (difference != 0)
			{
				Loadout.Stats.CriticalDamage -= difference;
			}
		}

		#endregion

		#endregion

		#region Methods

		#endregion
	}
}