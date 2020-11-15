using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class ShieldsPerk : Perk
	{
		public ShieldsPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Shields";
		
		public override string Description => "Increase Shields and Shields Regen of all your units by 2.5%";

		public override byte Page => 1;

		public override byte Position => 3;

		public override int StartingCost => 15;

		public override int IncrementCost => 15;

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Shields += 2.5 * difference;
		}
	}
}
