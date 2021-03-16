using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class EmptyRank : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.None;

		public override double DamageIncrease => 0;

		public override double DamageReduction => 0;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;

		public override void ActivateRank()
		{
			// do nothing as empty rank
		}

		public override void DeactivateRank()
		{
			// do nothing as empty rank
		}
	}
}
