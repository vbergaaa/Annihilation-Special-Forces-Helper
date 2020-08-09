using System;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSS : Rank
	{
		public override UnitRank Rank => UnitRank.SS;

		public override double DamageIncrease => 20;

		public override double DamageReduction => 10;

		public override double AttackSpeed => 10;

		public override double Attack => 5;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
