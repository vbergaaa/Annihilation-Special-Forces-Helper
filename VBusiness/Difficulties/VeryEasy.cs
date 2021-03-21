using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class VeryEasy : Difficulty
	{
		public override DifficultyLevel Difficulty => DifficultyLevel.VeryEasy;

		public override int TormentReduction => 0;

		public override double Health => 0.66;

		public override double Damage => 0.66;

		public override double Armor => 0.66;

		public override int DamageIncrease => 0;

		public override int DamageReduction => 0;

		public override double AttackSpeed => 1;

		public override int RoomToClear => 6;

		public override int FearChance => 0;

		public override int StartingUpgrades => 0;

		public override int TitanChance => 0;

		public override int MythicBoss => 0;

		public override int CritReduction => 0;

		public override int UnitTierIncrease => 0;
	}
}
