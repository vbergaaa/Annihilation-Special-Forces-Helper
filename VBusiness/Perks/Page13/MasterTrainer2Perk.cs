using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MasterTrainer2Perk : Perk
	{
		public MasterTrainer2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 200 kills";

		public override byte Page => 13;

		public override byte Position => 5;

		public override int StartingCost => 1500;

		public override int IncrementCost => 650;

		protected override string PerkName => "Master Trainer II";

		protected override short MaxLevelCore => 20;
	}
}
