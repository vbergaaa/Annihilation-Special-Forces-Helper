using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankXDZ : UnitRank
	{
		public RankXDZ(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.XDZ;

		public override double DamageIncrease => 102;

		public override double DamageReduction => 47;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
