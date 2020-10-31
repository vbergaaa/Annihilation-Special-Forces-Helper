using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSXD : UnitRank
	{
		public RankSXD(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.SXD;

		public override double DamageIncrease => 48;

		public override double DamageReduction => 29;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
