using System;
using System.ComponentModel;

namespace VEntityFramework.Model
{
	public abstract class VDifficulty
	{
		#region Properties

		#region Difficulty

		public abstract DifficultyLevel Difficulty { get; }

		#endregion

		#region TormentReduction

		public abstract int TormentReduction { get; }

		#endregion

		#endregion
	}

	public enum DifficultyLevel
	{
		None,
		[Description("Very Easy")]
		VeryEasy,
		Easy,
		Normal,
		Hard,
		[Description("Very Hard")]
		VeryHard,
		Insane,
		Brutal,
		Nightmare,
		Torment,
		Hell,
		Titanic,
		Mythic,
		Divine,
	}
}
