using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class RedCritsPerk : Perk
	{
		public RedCritsPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Your critical hits have a 50% chance to deal double damage";

		public override byte Page => 8;

		public override byte Position => 6;

		public override int StartingCost => 25000;

		public override int IncrementCost => 0;

		protected override short MaxLevelCore => 1;

		protected override string PerkName => "Red Crits";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.HasRedCrits = difference > 0 ? true : false;
		}
	}
}
