using System;
using VBusiness.Rooms;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	class ZeroV : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.ZeroV;

		public override int TormentReduction => 19;

		public override double Health => 2.2;

		public override double Damage => 2.2;

		public override double Armor => 2.2;

		public override int DamageIncrease => 250;

		public override int DamageReduction => 80;

		public override double AttackSpeed => 2;

		public override int FearChance => 17;

		public override int StartingUpgrades => 9;

		public override int TitanChance => 14;

		public override int MythicBoss => 60;

		public override int CritReduction => 20;

		public override int UnitTierIncrease => 1;

		public override RoomNumber RoomToClear => throw new NotImplementedException();
	}
}
