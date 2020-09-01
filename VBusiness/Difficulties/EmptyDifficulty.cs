using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class EmptyDifficulty : VDifficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.None;
	}
}
