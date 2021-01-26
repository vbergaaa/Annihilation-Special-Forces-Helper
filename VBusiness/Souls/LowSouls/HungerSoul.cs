using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class HungerSoul : LowSoul
	{
		public HungerSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Hunger;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			Loadout.UnitConfiguration.MaximumKills += 200;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			Loadout.UnitConfiguration.MaximumKills -= 200;
		}
	}
}
