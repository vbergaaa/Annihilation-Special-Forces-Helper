using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Titanic : VDifficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Titanic;

		public override int TormentReduction => throw new NotImplementedException();
	}
}
