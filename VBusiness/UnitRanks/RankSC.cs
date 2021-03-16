using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSC : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SC;

		public override double DamageIncrease => 14;

		public override double DamageReduction => 7;

		public override double AttackSpeed => 5;

		public override double Attack => 5;

		public override double Speed => 5;

		public override double Vitals => 0;

		public override double Armor => 0;
	}
}
