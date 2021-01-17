using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class EmptyDifficulty : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.None;

		public override int TormentReduction => 0;
	}
}
