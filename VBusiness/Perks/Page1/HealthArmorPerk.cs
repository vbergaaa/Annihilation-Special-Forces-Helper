using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class HealthArmorPerk : Perk
	{
		public HealthArmorPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Health Armor";

		public override string Description => "Increase Health Armor by 2%";

		public override byte Page => 1;

		public override byte Position => 6;

		public override int StartingCost => 20;

		public override int IncrementCost => 20;

		public override short MaxLevel => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.HealthArmor += 2 * difference;
		}
	}
}
