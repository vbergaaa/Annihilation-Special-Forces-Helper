using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class ShieldsArmorPerk : Perk
	{
		public ShieldsArmorPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Shields Armor";
		
		public override string Description => "Increase Shields Armor of all units by 2%";

		public override byte Page => 1;

		public override byte Position => 4;

		public override int StartingCost => 20;

		public override int IncrementCost => 20;

		public override short MaxLevel => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.ShieldsArmor += 2 * difference;
		}
	}
}
