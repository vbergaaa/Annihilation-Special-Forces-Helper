using System;
using System.ComponentModel;
using VBusiness.Rooms;

namespace VEntityFramework.Model
{
	public abstract class VDifficulty
	{
		#region Properties

		#region Difficulty

		public abstract DifficultyLevel Difficulty { get; }

		#endregion

		#region TormentReduction

		public abstract int TormentReduction { get; }

		#endregion

		#region Health

		public abstract double Health { get; }

		#endregion

		#region Damage

		public abstract double Damage { get; }

		#endregion

		#region Armor

		public abstract double Armor { get; }

		#endregion

		#region DamageIncrease

		public abstract int DamageIncrease { get; }

		#endregion

		#region DamageReduction

		public abstract int DamageReduction { get; }

		#endregion

		#region AttackSpeed

		public abstract double AttackSpeed { get; }

		#endregion

		#region FearChance

		public abstract int FearChance { get; }

		#endregion

		#region StartingUpgrades

		public abstract int StartingUpgrades { get; }

		#endregion

		#region TitanChance

		public abstract int TitanChance { get; }

		#endregion

		#region MythicBoss

		public abstract int MythicBoss { get; }

		#endregion

		#region CritReduction

		public abstract int CritReduction { get; }

		#endregion

		#region UnitTierIncrease

		public abstract int UnitTierIncrease { get; }

		#endregion

		#region RoomToClear

		public abstract RoomNumber RoomToClear { get; }

		#endregion

		#endregion
	}

	public enum DifficultyLevel
	{
		None,
		[Description("Very Easy")]
		VeryEasy,
		Easy,
		Normal,
		Hard,
		[Description("Very Hard")]
		VeryHard,
		Insane,
		Brutal,
		Nightmare,
		Torment,
		Hell,
		Titanic,
		Mythic,
		Divine,
		Impossible,
		ZeroV,
	}
}
