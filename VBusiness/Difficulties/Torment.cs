using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Torment : VDifficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Torment;

		public override int TormentReduction => 5;
	}
}
