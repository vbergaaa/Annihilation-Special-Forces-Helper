using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class TrifectaPowerPerk : Perk
	{
		public TrifectaPowerPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases stats by 1.5% and armor by 1% while unit is at or above SSS";

		public override byte Page => 7;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 500;

		public override short MaxLevel => 10;

		protected override string PerkName => "Trifecta Power";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.TrifectaStacks += difference;
		}
	}
}
