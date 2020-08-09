using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSA : Rank
	{
		public override UnitRank Rank => UnitRank.SSA;

		public override double DamageIncrease => 28;

		public override double DamageReduction => 14;

		public override double AttackSpeed => 10;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
