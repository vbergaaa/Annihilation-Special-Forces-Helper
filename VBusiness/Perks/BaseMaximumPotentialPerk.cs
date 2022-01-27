using VBusiness.Units;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public abstract class BaseMaximumPotentialPerk : Perk
	{
		protected BaseMaximumPotentialPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override void OnLevelChanged(int difference)
		{
			var unit = Loadout.CurrentUnit as Unit;
			var existingMaxKills = unit.MaximumKills;
			var existingMaxEssence = existingMaxKills / 100;
			var existingMaxInfusion = unit.GetMaxInfusion(existingMaxKills);

			PerkCollection.Loadout.Stats.MaximumPotientialStacks += difference;

			if (existingMaxEssence * 100 == Loadout.CurrentUnit.CurrentKills)
			{
				unit.CurrentKills = unit.MaximumKills;
			}

			if (Loadout.CurrentUnit.CurrentInfusion == existingMaxInfusion)
			{
				unit.CurrentInfusion = unit.MaximumInfusion;
			}

			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumInfusion");
			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumEssence");
		}

		public override int MinimumIncreaseForOptimise => 2;
	}
}
