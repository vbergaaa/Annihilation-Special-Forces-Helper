using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSC : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SSC;

		public override double DamageIncrease => 24;

		public override double DamageReduction => 12;

		public override double AttackSpeed => 10;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
