using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class StatusSoul : HighSoul
	{
		public StatusSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Status;

		public override void ActivateUniqueEffect()
		{
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance += (int)(rank * 0.5);
		}

		public override void DeactivateUniqueEffect()
		{
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance -= (int)(rank * 0.5);
		}
	}
}
