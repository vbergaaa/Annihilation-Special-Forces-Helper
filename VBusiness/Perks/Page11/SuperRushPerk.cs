using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class SuperRushPerk : Perk
	{
		public SuperRushPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases Adrenaline Rush bonus by 10%";

		public override byte Page => 11;

		public override byte Position => 4;

		public override int StartingCost => 2000;

		public override int IncrementCost => 300;

		public override short MaxLevel => 10;

		protected override string PerkName => "Super Rush";

		protected override void OnLevelChanged(int difference)
		{
				PerkCollection.Loadout.Stats.Attack += 1 * difference;
				PerkCollection.Loadout.Stats.AttackSpeed += 1 * difference;
				PerkCollection.Loadout.Stats.CriticalChance += 0.5 * difference;
		}
	}
}
