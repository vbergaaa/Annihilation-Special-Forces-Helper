using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LuckyStatusSoul : DivineSoul
	{
		public LuckyStatusSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.LuckyStatus;

		public override void ActivateUniqueEffect()
		{
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance += (int)(rank * 0.7);
		}

		public override void DeactivateUniqueEffect()
		{
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance -= (int)(rank * 0.7);
		}
	}
}
