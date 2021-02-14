using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalChancePerk : Perk
	{
		public CriticalChancePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Critical Chance";

		public override byte Page => 4;

		public override byte Position => 1;

		public override int StartingCost => 80;

		public override int IncrementCost => 20;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Critical Chance";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.CriticalChance += 1 * difference;
		}
	}
}
