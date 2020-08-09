using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSX : Rank
	{
		public override UnitRank Rank => UnitRank.SSX;

		public override double DamageIncrease => 36;

		public override double DamageReduction => 21;

		public override double AttackSpeed => 15;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
