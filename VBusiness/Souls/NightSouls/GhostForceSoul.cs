using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GhostForceSoul : NightSoul
	{
		public GhostForceSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.GhostForce;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			SoulCollection.Loadout.UnitConfiguration.MaximumKills += 200;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			SoulCollection.Loadout.UnitConfiguration.MaximumKills -= 200;
		}
	}
}
