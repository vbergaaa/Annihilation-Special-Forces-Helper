using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankB : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.B;

		public override double DamageIncrease => 6;

		public override double DamageReduction => 3;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;
	}
}
