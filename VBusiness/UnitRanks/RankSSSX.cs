using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSSX : UnitRank
	{
		public RankSSSX(VUnit unit) : base(unit)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.SSSX;

		public override double DamageIncrease => 38;

		public override double DamageReduction => 23;

		public override double AttackSpeed => 15;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
