using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class VeryHard : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.VeryHard;

		public override int TormentReduction => 0;
	}
}
