using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class ShieldsArmorPerk : Perk
	{
		public ShieldsArmorPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Shields Armor";
		
		public override string Description => "+2% Shield Armor";

		public override byte Page => 1;

		public override byte Position => 4;

		public override int StartingCost => 20;

		public override int IncrementCost => 20;

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.UpdateShieldsArmor("Core", 2 * difference);
		}
	}
}
