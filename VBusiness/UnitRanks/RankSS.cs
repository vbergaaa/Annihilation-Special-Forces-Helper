using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSS : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SS;

		public override double DamageIncrease => 20;

		public override double DamageReduction => 10;

		public override double AttackSpeed => 10;

		public override double Attack => 5;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
