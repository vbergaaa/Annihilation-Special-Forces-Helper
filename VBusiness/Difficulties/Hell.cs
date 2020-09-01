using System;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Hell : VDifficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Hell;

		public override int TormentReduction => throw new NotImplementedException();
	}
}
