using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	// don't add anything to this. 
	// it no longer makes sense
	// if you find yourself changing this file, see if you can move the logic you're writing into VLoadout.cs
	public abstract class VUnitConfiguration : BusinessObject
	{
		#region Constructor

		public VUnitConfiguration(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout => Parent as VLoadout;

		#endregion

		#region HasSoloBonus

		[VXML(true)]
		public virtual bool HasSoloBonus
		{
			get => fHasSoloBonus;
			set
			{
				if (fHasSoloBonus != value)
				{
					fHasSoloBonus = value;
					HasChanges = true;
					OnPropertyChanged(nameof(HasSoloBonus));
				}
			}
		}
		bool fHasSoloBonus;

		#endregion

		#region DifficultyLevel

		[VXML(true)]
		public virtual DifficultyLevel DifficultyLevel
		{
			get => fDifficultyLevel;
			set
			{
				if (fDifficultyLevel != value)
				{
					fDifficultyLevel = value;
					HasChanges = true;
					OnPropertyChanged(nameof(DifficultyLevel));
					Loadout?.IncomeManager?.RefreshPropertyBinding(nameof(Loadout.IncomeManager.MineralsPerMinute));
					Loadout?.IncomeManager?.RefreshPropertyBinding(nameof(Loadout.IncomeManager.KillsPerMinute));
				}
			}
		}
		DifficultyLevel fDifficultyLevel;

		#endregion

		#region Difficulty

		public virtual VDifficulty Difficulty
		{
			get => fDifficulty;
			set
			{
				if (fDifficulty != value)
				{
					fDifficulty = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Difficulty));
				}
			}
		}
		VDifficulty fDifficulty;

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "UnitConfiguration";

		#endregion
	}
}
