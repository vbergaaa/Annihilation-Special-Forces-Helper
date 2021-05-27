using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class KillRecyclePerk : Perk
	{
		public KillRecyclePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Store 5% of kills from units that die. Has a 6 second cooldown";

		public override byte Page => 2;

		public override byte Position => 2;

		public override int StartingCost => 100;

		public override int IncrementCost => 25;

		protected override short MaxLevelCore => 5;

		protected override string PerkName => "Kill Recycle";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.KillRecycle += difference * 5;
		}
	}
}
