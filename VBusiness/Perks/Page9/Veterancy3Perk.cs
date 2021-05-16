using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class Veterancy3Perk : Perk
	{
		public Veterancy3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Units start with +10 kills";

		public override byte Page => 9;

		public override byte Position => 5;

		public override int StartingCost => 1000;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Veterancy III";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.Veterancy += difference * 10;
		}
	}
}
