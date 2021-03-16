using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankXX : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.XX;

		public override double DamageIncrease => 40;

		public override double DamageReduction => 25;

		public override double AttackSpeed => 15;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
