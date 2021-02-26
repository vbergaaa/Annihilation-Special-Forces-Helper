﻿using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public class RankZ : UnitRank
	{
		public RankZ(VUnit unit) : base(unit)
		{
		}

		public override VEntityFramework.Model.UnitRank Rank => VEntityFramework.Model.UnitRank.Z;

		public override double DamageIncrease => 57;

		public override double DamageReduction => 32;

		public override double AttackSpeed => 15;

		public override double Attack => 20;

		public override double Speed => 10;

		public override double Vitals => 10;

		public override double Armor => 10;
	}
}
