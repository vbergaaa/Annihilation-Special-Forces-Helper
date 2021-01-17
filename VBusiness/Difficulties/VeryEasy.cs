using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class VeryEasy : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.VeryEasy;

		public override int TormentReduction => 0;
	}
}
