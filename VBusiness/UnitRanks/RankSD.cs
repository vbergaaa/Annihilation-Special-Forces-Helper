using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSD : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SD;

		public override double DamageIncrease => 12;

		public override double DamageReduction => 6;

		public override double AttackSpeed => 5;

		public override double Attack => 5;

		public override double Speed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;
	}
}
