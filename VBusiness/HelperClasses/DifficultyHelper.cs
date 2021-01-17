using System;
using System.Collections.Generic;
using System.Text;
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
	}
}
