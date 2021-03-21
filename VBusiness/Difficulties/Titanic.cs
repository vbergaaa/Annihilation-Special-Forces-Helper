using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Titanic : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Titanic;

		public override int TormentReduction => 10;

		public override double Health => 1.5;

		public override double Damage => 1.5;

		public override double Armor => 1.5;

		public override int DamageIncrease => 155;

		public override int DamageReduction => 56;

		public override double AttackSpeed => 1.5;

		public override int RoomToClear => 25;

		public override int FearChance => 9;

		public override int StartingUpgrades => 6;

		public override int TitanChance => 6;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
