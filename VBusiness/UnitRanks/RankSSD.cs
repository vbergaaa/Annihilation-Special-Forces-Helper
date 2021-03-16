using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSD : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SSD;

		public override double DamageIncrease => 22;

		public override double DamageReduction => 11;

		public override double AttackSpeed => 10;

		public override double Attack => 10;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
