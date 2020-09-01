using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VDifficulty : VBusinessObject
	{
		#region Properties

		#region Difficulty

		public abstract DifficultyLevel Difficulty { get; }

		#endregion

		#region TormentReduction

		public virtual int TormentReduction => 0;

		#endregion

		#endregion

		#region Methods

		#region GetDifficultyLevelFromString

		public static DifficultyLevel GetDifficultyLevelFromString(string level)
		{
			return level switch
			{
				("None") => DifficultyLevel.None,
				("VeryEasy") => DifficultyLevel.VeryEasy,
				("Easy") => DifficultyLevel.Easy,
				("Medium") => DifficultyLevel.Medium,
				("Hard") => DifficultyLevel.Hard,
				("VeryHard") => DifficultyLevel.VeryHard,
				("Brutal") => DifficultyLevel.Brutal,
				("Insane") => DifficultyLevel.Insane,
				("Nightmare") => DifficultyLevel.Nightmare,
				("Torment") => DifficultyLevel.Torment,
				("Hell") => DifficultyLevel.Hell,
				("Titanic") => DifficultyLevel.Titanic,
				("Mythic") => DifficultyLevel.Mythic,
				_ => throw new NotImplementedException($"Cannot load {level} difficulty"),
			};
		}

		#endregion

		#endregion
		#region Implementation

		public override string BizoName => "Difficulty";

		#endregion
	}

	public enum DifficultyLevel
	{
		None,
		VeryEasy,
		Easy,
		Medium,
		Hard,
		VeryHard,
		Insane,
		Brutal,
		Nightmare,
		Torment,
		Hell,
		Titanic,
		Mythic
	}
}
