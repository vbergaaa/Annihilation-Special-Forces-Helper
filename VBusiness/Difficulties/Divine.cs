using System;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Divine : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Divine;

		public override int TormentReduction => 15;

		public override double Health => 1.8;

		public override double Damage => 1.8;

		public override double Armor => 1.8;

		public override int DamageIncrease => 200;

		public override int DamageReduction => 70;

		public override double AttackSpeed => 1.8;

		public override int RoomToClear => 30;

		public override int FearChance => 13;

		public override int StartingUpgrades => 8;

		public override int TitanChance => 10;

		public override int MythicBoss => 40;

		public override int CritReduction => 10;

		public override int UnitTierIncrease => throw new NotImplementedException();
	}
}
