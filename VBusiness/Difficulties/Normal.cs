using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Normal : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Normal;

		public override int TormentReduction => 0;
	}
}

