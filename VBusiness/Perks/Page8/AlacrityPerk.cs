using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class AlacrityPerk : Perk
	{
		public AlacrityPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Acceleration";

		public override byte Page => 8;

		public override byte Position => 5;

		public override int StartingCost => 2000;

		public override int IncrementCost => 250;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Alacrity";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Acceleration += difference;
		}
	}
}
