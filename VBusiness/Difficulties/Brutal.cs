using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Brutal : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Brutal;

		public override int TormentReduction => 0;

		public override double Health => 1.2;

		public override double Damage => 1.2;

		public override double Armor => 1.2;

		public override int DamageIncrease => 43;

		public override int DamageReduction => 22;

		public override double AttackSpeed => 1.2;

		public override VBusiness.Rooms.RoomNumber RoomToClear => VBusiness.Rooms.RoomNumber.Room19;

		public override int FearChance => 0;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
