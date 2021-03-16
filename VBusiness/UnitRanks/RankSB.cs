using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSB : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SB;

		public override double DamageIncrease => 16;

		public override double DamageReduction => 8;

		public override double AttackSpeed => 5;

		public override double Attack => 5;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 0;
	}
}
