using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankXZ : Rank
	{
		public RankXZ(VUnitConfiguration config) : base(config)
		{
		}

		public override UnitRank Rank => UnitRank.XZ;

		public override double DamageIncrease => 93;

		public override double DamageReduction => 44;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
