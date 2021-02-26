﻿using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankX : UnitRank
	{
		public RankX(VUnit unit) : base(unit)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.X;

		public override double DamageIncrease => 32;

		public override double DamageReduction => 17;

		public override double AttackSpeed => 15;

		public override double Attack => 10;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
