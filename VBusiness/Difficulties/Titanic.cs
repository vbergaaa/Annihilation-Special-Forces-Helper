using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Titanic : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Titanic;

		public override int TormentReduction => 10;
	}
}
