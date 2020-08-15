using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalChance3Perk : Perk
	{
		public CriticalChance3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants 1% chance to critical hit with any attack";

		public override byte Page => 11;

		public override byte Position => 1;

		public override int StartingCost => 1000;

		public override int IncrementCost => 200;

		public override short MaxLevel => 30;

		protected override string PerkName => "Critical Chance III";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.CriticalChance += 1 * difference;
		}
	}
}
