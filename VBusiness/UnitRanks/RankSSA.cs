using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSA : UnitRank
	{
		public RankSSA(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.SSA;

		public override double DamageIncrease => 28;

		public override double DamageReduction => 14;

		public override double AttackSpeed => 10;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
