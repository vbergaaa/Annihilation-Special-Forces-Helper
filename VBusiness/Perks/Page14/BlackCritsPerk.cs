using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class BlackCritsPerk : Perk
	{
		public BlackCritsPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Your critical hits have a 33% chance to deal 350% damage";

		public override byte Page => 14;

		public override byte Position => 3;

		public override int StartingCost => 150000;

		public override int IncrementCost => 0;

		protected override string PerkName => "Black Crits";

		protected override short MaxLevelCore => 1;
	}
}
