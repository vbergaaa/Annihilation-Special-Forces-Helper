using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Hell : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Hell;

		public override int TormentReduction => 7;

		public override double Health => 1.4;

		public override double Damage => 1.4;

		public override double Armor => 1.4;

		public override int DamageIncrease => 130;

		public override int DamageReduction => 50;

		public override double AttackSpeed => 1.4;

		public override int RoomToClear => 23;

		public override int FearChance => 7;

		public override int StartingUpgrades => 5;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
