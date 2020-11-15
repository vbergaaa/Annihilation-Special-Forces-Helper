using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class Alacrity2Perk : Perk
	{
		public Alacrity2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Accelerate units by 1%";

		public override byte Page => 11;

		public override byte Position => 6;

		public override int StartingCost => 3000;

		public override int IncrementCost => 400;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Alacrity II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Acceleration += difference;
		}
	}
}
