using System;
using System.Collections.Generic;
using VBusiness.Difficulties;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class DifficultyHelper
	{
		public static VDifficulty New(DifficultyLevel level)
		{
			return level switch
			{
				DifficultyLevel.None => new EmptyDifficulty(),
				DifficultyLevel.VeryEasy => new VeryEasy(),
				DifficultyLevel.Easy => new Easy(),
				DifficultyLevel.Normal => new Normal(),
				DifficultyLevel.Hard => new Hard(),
				DifficultyLevel.VeryHard => new VeryHard(),
				DifficultyLevel.Insane => new Insane(),
				DifficultyLevel.Brutal => new Brutal(),
				DifficultyLevel.Nightmare => new Nightmare(),
				DifficultyLevel.Torment => new Torment(),
				DifficultyLevel.Hell => new Hell(),
				DifficultyLevel.Titanic => new Titanic(),
				DifficultyLevel.Mythic => new Mythic(),
				DifficultyLevel.Divine => new Divine(),
				_ => throw new ApplicationException(level.ToString() + " has not yet been implemented into the application")
			};
		}

		public static List<DifficultyLevel> GetDifficulties()
		{
			if (fDifficulties == null)
			{
				fDifficulties = new List<DifficultyLevel>
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
			return fDifficulties;
		}
		static List<DifficultyLevel> fDifficulties;
	}
}
