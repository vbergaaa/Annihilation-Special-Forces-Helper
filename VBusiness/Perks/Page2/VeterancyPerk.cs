using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class VeterancyPerk : Perk
	{
		public VeterancyPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Units start with +10 kills";

		public override byte Page => 2;

		public override byte Position => 4;

		public override int StartingCost => 60;

		public override int IncrementCost => 20;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Veterancy";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.Veterancy += difference * 10;
		}
	}
}
