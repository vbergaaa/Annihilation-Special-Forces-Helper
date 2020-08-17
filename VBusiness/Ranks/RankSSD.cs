using System;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSD : Rank
	{
		public RankSSD(VUnitConfiguration config) : base(config)
		{
		}

		public override UnitRank Rank => UnitRank.SSD;

		public override double DamageIncrease => 22;

		public override double DamageReduction => 11;

		public override double AttackSpeed => 10;

		public override double Attack => 10;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
