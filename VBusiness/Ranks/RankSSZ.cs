﻿using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSSZ : Rank
	{
		public override UnitRank Rank => UnitRank.SSZ;

		public override double DamageIncrease => 75;

		public override double DamageReduction => 38;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}