using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class StatusSoul : HighSoul
	{
		public StatusSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Status;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance += (int)(rank * 0.5);
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			var rank = (int)Loadout.Profile.Rank;
			Loadout.Stats.CriticalChance -= (int)(rank * 0.5);
		}
	}
}
