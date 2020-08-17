using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSX : Rank
	{
		public RankSX(VUnitConfiguration config) : base(config)
		{
		}

		public override UnitRank Rank => UnitRank.SX;

		public override double DamageIncrease => 34;

		public override double DamageReduction => 19;

		public override double AttackSpeed => 15;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
