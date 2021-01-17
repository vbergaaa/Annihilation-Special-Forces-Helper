using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Hell : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Hell;

		public override int TormentReduction => 7;
	}
}
