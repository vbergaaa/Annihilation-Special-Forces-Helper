using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Easy : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Easy;

		public override int TormentReduction => 0;

		public override double Health => 0.85;

		public override double Damage => 0.85;

		public override double Armor => 0.85;

		public override int DamageIncrease => 0;

		public override int DamageReduction => 0;

		public override double AttackSpeed => 1;

		public override int RoomToClear => 9;

		public override int FearChance => 0;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
