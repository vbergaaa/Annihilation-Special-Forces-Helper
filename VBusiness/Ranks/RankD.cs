﻿using System;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankD : Rank
	{
		public override UnitRank Rank => UnitRank.D;

		public override double DamageIncrease => 2;

		public override double DamageReduction => 1;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;
	}
}