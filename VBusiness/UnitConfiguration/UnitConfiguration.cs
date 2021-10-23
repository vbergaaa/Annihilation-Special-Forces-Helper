using VEntityFramework.Model;
using VBusiness.HelperClasses;
using System;
using VBusiness.Rooms;

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
				Loadout.Stats.UpdateHealthArmor("Core", 20);
				Loadout.Stats.UpdateShields("Core", 25);
				Loadout.Stats.UpdateShieldsArmor("Core", 20);
			}
			else
			{
				Loadout.Stats.Attack -= 30;
				Loadout.Stats.UpdateAttackSpeed("Core", -20);
				Loadout.Stats.UpdateHealth("Core", -25);
				Loadout.Stats.UpdateHealthArmor("Core", -20);
				Loadout.Stats.UpdateShields("Core", -25);
				Loadout.Stats.UpdateShieldsArmor("Core", -20);
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

					if (value != DifficultyLevel.None)
					{
						Difficulty = DifficultyHelper.New(value);

						if (!IsSettingDefaultValues)
						{
							Loadout.IncomeManager.FarmRoom = (RoomNumber)Math.Min((int)Loadout.IncomeManager.FarmRoom, (int)Difficulty.RoomToClear);
						}
					}
					else
					{
						Difficulty = null;
					}

					Loadout.Stats.RefreshPropertyBinding("Toughness");
					Loadout.Stats.RefreshPropertyBinding("Damage");
					Loadout.Mods.RefreshPropertyBinding(nameof(Loadout.Mods.TotalModScore));
				}
			}
		}

		#endregion

		#region Difficulty

		public override VDifficulty Difficulty
		{
			get => base.Difficulty ?? DifficultyHelper.New(Profile.Profile.GetProfile().GetRecommendedDifficulty());
			set
			{
				if (base.Difficulty != value)
				{
					var oldDiff = base.Difficulty;
					base.Difficulty = value;
					UpdateDifficulty(value, oldDiff);
				}
			}
		}

		void UpdateDifficulty(VDifficulty newDiff, VDifficulty oldDiff)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				UpdateTormentReduction(newDiff, oldDiff);
				UpdateCritReduction(newDiff, oldDiff);
			}
		}

		void UpdateTormentReduction(VDifficulty newDiff, VDifficulty oldDiff)
		{
			var oldTormentReduction = oldDiff?.TormentReduction ?? 0;
			var newTormentReduction = newDiff?.TormentReduction ?? 0;
			var difference = newTormentReduction - oldTormentReduction;
			difference *= 1 ;

			UpdateTormentReduction(difference * (1 + Loadout.Mods.Difficulty.CurrentLevel / 10.0));
		}

		internal void UpdateTormentReduction(double difference)
		{
			if (difference != 0)
			{
				Loadout.Stats.Attack -= difference;
				Loadout.Stats.UpdateAttackSpeed("Core", -difference);
				Loadout.Stats.UpdateHealth("Core", -difference);
				Loadout.Stats.UpdateHealthArmor("Core", -difference);
				Loadout.Stats.UpdateShields("Core", -difference);
				Loadout.Stats.UpdateShieldsArmor("Core", -difference);
				Loadout.Stats.UpdateAcceleration("Core", -difference);
				Loadout.Stats.CriticalDamage -= difference;
			}
		}

		void UpdateCritReduction(VDifficulty newDiff, VDifficulty oldDiff)
		{
			var oldCritReduction = oldDiff?.CritReduction ?? 0;
			var newCritReduction = newDiff?.CritReduction ?? 0;
			var difference = newCritReduction - oldCritReduction;

			UpdateCritReduction(difference * (1 + Loadout.Mods.Difficulty.CurrentLevel / 10.0));
		}

		internal void UpdateCritReduction(double difference)
		{
			if (difference != 0)
			{
				Loadout.Stats.CriticalDamage -= difference;
			}
		}

		#endregion

		#endregion

		#region Methods

		protected override void SetDefaultValuesCore()
		{
			base.SetDefaultValuesCore();

			DifficultyLevel = Profile.Profile.GetProfile().GetRecommendedDifficulty();
		}

		#endregion
	}
}