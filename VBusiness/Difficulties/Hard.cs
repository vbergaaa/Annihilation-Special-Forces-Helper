using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Hard : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Hard;

		public override int TormentReduction => 0;
	}
}
