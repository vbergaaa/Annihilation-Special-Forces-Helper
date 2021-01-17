using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Insane : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Insane;

		public override int TormentReduction => 0;
	}
}
