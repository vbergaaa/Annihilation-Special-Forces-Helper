using System;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankS : Rank
	{
		public RankS(VUnitConfiguration config) : base(config)
		{
		}

		public override UnitRank Rank => UnitRank.S;

		public override double DamageIncrease => 10;

		public override double DamageReduction => 5;

		public override double AttackSpeed => 5;

		public override double Attack => 0;

		public override double Speed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;
	}
}
