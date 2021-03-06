﻿using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSA : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SA;

		public override double DamageIncrease => 18;

		public override double DamageReduction => 9;

		public override double AttackSpeed => 5;

		public override double Attack => 5;

		public override double Speed => 5;

		public override double Vitals => 5;

		public override double Armor => 5;
	}
}
