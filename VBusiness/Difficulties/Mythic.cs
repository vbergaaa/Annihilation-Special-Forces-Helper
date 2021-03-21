using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Mythic : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Mythic;

		public override int TormentReduction => 13;

		public override double Health => 1.6;

		public override double Damage => 1.6;

		public override double Armor => 1.6;

		public override int DamageIncrease => 170;

		public override int DamageReduction => 62;

		public override double AttackSpeed => 1.6;

		public override int RoomToClear => 27;

		public override int FearChance => 11;

		public override int StartingUpgrades => 7;

		public override int TitanChance => 8;

		public override int MythicBoss => 30;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
