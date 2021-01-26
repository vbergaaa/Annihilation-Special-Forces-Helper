using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LuckyStatusSoul : DivineSoul
	{
		public LuckyStatusSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.LuckyStatus;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance += (int)(rank * 0.7);
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance -= (int)(rank * 0.7);
		}
	}
}
