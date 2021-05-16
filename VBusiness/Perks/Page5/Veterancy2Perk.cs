using VEntityFramework.Model;

namespace VBusiness.Perks

{
	public class Veterancy2Perk : Perk
	{
		public Veterancy2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Units start with +10 kills";

		public override byte Page => 5;

		public override byte Position => 5;

		public override int StartingCost => 250;

		public override int IncrementCost => 75;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Veterancy II";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.Veterancy += difference * 10;
		}
	}
}
