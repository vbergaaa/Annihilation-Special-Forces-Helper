using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankA : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.A;

		public override double DamageIncrease => 8;

		public override double DamageReduction => 4;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;
	}
}
