﻿using System;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankC : Rank
	{
		public override UnitRank Rank => UnitRank.C;

		public override double DamageIncrease => 4;

		public override double DamageReduction => 2;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;
	}
}
