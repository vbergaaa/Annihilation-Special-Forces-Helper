using System;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Divine : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Divine;

		public override int TormentReduction => 15;
	}
}
