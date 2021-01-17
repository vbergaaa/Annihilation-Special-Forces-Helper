using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class DifficultyLookup
	{
		public List<DifficultyLevel> GetDifficulties()
		{
			return new List<DifficultyLevel>
			{
				DifficultyLevel.None,
				DifficultyLevel.VeryEasy,
				DifficultyLevel.Easy,
				DifficultyLevel.Normal,
				DifficultyLevel.Hard,
				DifficultyLevel.VeryHard,
				DifficultyLevel.Insane,
				DifficultyLevel.Brutal,
				DifficultyLevel.Nightmare,
				DifficultyLevel.Torment,
				DifficultyLevel.Hell,
				DifficultyLevel.Titanic,
				DifficultyLevel.Mythic,
				DifficultyLevel.Divine,
			};
		}
	}
}
