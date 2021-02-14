using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Impossible : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Impossible;

		public override int TormentReduction => 17;
	}
}
