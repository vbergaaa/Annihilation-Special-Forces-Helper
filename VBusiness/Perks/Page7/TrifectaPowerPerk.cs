using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class TrifectaPowerPerk : Perk
	{
		public TrifectaPowerPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "When ranking to SSS, give units:\r\n+1.5% Damage\r\n+1.5% Attack Speed\r\n+1.5% Vitals\r\n+1.5% Acceleration\r\n+1% Armor";

		public override byte Page => 7;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 500;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Trifecta Power";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.TrifectaStacks += difference;
		}
	}
}
