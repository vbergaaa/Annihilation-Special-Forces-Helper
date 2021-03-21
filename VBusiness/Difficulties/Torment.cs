using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Torment : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Torment;

		public override int TormentReduction => 5;

		public override double Health => 1.4;

		public override double Damage => 1.4;

		public override double Armor => 1.4;

		public override int DamageIncrease => 110;

		public override int DamageReduction => 45;

		public override double AttackSpeed => 1.4;

		public override int RoomToClear => 23;

		public override int FearChance => 6;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
