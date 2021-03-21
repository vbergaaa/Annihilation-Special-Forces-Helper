using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Impossible : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Impossible;

		public override int TormentReduction => 17;

		public override double Health => 2;

		public override double Damage => 2;

		public override double Armor => 2;

		public override int DamageIncrease => 225;

		public override int DamageReduction => 75;

		public override double AttackSpeed => 1.8;

		public override int RoomToClear => 33;

		public override int FearChance => 15;

		public override int StartingUpgrades => 9;

		public override int TitanChance => 12;

		public override int MythicBoss => 50;

		public override int CritReduction => 15;

		public override int UnitTierIncrease => 1;
	}
}
