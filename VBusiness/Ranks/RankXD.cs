using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankXD : Rank
	{
		public RankXD(VUnitConfiguration config) : base(config)
		{
		}

		public override UnitRank Rank => UnitRank.XD;

		public override double DamageIncrease => 44;

		public override double DamageReduction => 27;

		public override double AttackSpeed => 15;

		public override double Attack => 15;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
