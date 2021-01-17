using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Nightmare : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Nightmare;

		public override int TormentReduction => 0;
	}
}
