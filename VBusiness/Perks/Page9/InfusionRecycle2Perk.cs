using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class InfusionRecycle2Perk : Perk
	{
		public InfusionRecycle2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Infusing a unit stores +5 kills";

		public override byte Page => 9;

		public override byte Position => 2;

		public override int StartingCost => 500;

		public override int IncrementCost => 125;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Infusion Recycle II";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.InfuseRecycle += difference * 5;
		}
	}
}
