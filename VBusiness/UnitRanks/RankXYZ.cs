using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankXYZ : UnitRank
	{
		public RankXYZ(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.XYZ;

		public override double DamageIncrease => 120;

		public override double DamageReduction => 53;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
