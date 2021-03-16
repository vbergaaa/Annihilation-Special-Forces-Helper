using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSS : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SSS;

		public override double DamageIncrease => 30;

		public override double DamageReduction => 15;

		public override double AttackSpeed => 15;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
