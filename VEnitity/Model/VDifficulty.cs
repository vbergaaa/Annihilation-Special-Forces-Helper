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
