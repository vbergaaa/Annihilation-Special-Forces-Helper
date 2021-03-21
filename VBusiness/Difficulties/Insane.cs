using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Insane : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.Insane;

		public override int TormentReduction => 0;

		public override double Health => 1.1;

		public override double Damage => 1.1;

		public override double Armor => 1.1;

		public override int DamageIncrease => 35;

		public override int DamageReduction => 18;

		public override double AttackSpeed => 1.1;

		public override int RoomToClear => 19;

		public override int FearChance => 0;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
