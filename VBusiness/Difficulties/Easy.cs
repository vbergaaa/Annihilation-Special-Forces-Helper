using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Easy : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Easy;

		public override int TormentReduction => 0;
	}
}
