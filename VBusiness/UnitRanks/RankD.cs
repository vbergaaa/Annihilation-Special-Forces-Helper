using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankD : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.D;

		public override double DamageIncrease => 2;

		public override double DamageReduction => 1;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;
	}
}
