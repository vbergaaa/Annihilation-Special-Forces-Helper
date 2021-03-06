﻿using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSB : UnitRank
	{
		public override UnitRankType Rank => UnitRankType.SSB;

		public override double DamageIncrease => 26;

		public override double DamageReduction => 13;

		public override double AttackSpeed => 10;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 5;
	}
}
