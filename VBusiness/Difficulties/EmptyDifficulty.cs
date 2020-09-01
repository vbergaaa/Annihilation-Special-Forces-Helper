using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class EmptyDifficulty : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.None;
	}
}
