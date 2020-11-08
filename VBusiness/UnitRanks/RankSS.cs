using System;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSS : UnitRank
	{
		public RankSS(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.SS;

		public override double DamageIncrease => 20;

		public override double DamageReduction => 10;

		public override double AttackSpeed => 10;

		public override double Attack => 5;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
