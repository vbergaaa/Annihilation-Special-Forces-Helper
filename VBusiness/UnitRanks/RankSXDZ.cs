﻿using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankSXDZ : UnitRank
	{
		public RankSXDZ(VUnitConfiguration config) : base(config)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.SXDZ;

		public override double DamageIncrease => 111;

		public override double DamageReduction => 50;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}