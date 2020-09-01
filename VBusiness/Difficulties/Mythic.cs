using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Mythic : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Mythic;

		public override int TormentReduction => 13;
	}
}
