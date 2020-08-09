﻿using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class EmptyRank : Rank
	{
		public override UnitRank Rank => UnitRank.None;

		public override double DamageIncrease => 0;

		public override double DamageReduction => 0;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Vitals => 0;

		public override double Armor => 0;

		public override double Speed => 0;
	}
}
