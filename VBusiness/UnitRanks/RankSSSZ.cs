using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSSZ : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SSSZ;

		public override double DamageIncrease => 84;

		public override double DamageReduction => 41;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
