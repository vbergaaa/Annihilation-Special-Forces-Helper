using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Normal : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Normal;

		public override int TormentReduction => 0;

		public override double Health => 1;

		public override double Damage => 1;

		public override double Armor => 1;

		public override int DamageIncrease => 0;

		public override int DamageReduction => 0;

		public override double AttackSpeed => 1;

		public override int RoomToClear => 12;

		public override int FearChance => 0;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}

