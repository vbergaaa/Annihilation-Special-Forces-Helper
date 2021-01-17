using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Brutal : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Brutal;

		public override int TormentReduction => 0;
	}
}
