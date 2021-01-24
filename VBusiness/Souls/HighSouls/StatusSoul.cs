using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class StatusSoul : HighSoul
	{
		public StatusSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Status;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			var rank = (int)SoulCollection.Loadout.Profile.Rank;
			SoulCollection.Loadout.Stats.CriticalChance += (int)(rank * 0.5);
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			var rank = (int)SoulCollection.Loadout.Profile.Rank;
			SoulCollection.Loadout.Stats.CriticalChance -= (int)(rank * 0.5);
		}
	}
}
