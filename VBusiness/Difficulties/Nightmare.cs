using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Nightmare : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Nightmare;

		public override int TormentReduction => 0;

		public override double Health => 1.3;

		public override double Damage => 1.3;

		public override double Armor => 1.3;

		public override int DamageIncrease => 80;

		public override int DamageReduction => 35;

		public override double AttackSpeed => 1.3;

		public override VBusiness.Rooms.RoomNumber RoomToClear => VBusiness.Rooms.RoomNumber.Room22;

		public override int FearChance => 5;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
