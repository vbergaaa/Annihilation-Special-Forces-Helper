using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSZ : UnitRank
	{
		public RankSZ(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.SZ;

		public override double DamageIncrease => 66;

		public override double DamageReduction => 35;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
