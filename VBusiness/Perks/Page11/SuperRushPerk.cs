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

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Super Rush";

		protected override void OnLevelChanged(int difference)
		{
			var perks = ((PerkCollection)PerkCollection);
			var currentLevel = perks.AdrenalineRush.DesiredLevel;

			var cacheModifier = perks.UpgradeCache.DesiredLevel > 0 && currentLevel == perks.AdrenalineRush.MaxLevel ? 2 : 1;

			PerkCollection.Loadout.Stats.Attack += 1.0 / 15 * currentLevel * difference;
			PerkCollection.Loadout.Stats.UpdateAttackSpeed("AdrenalineRush", 1.0 / 15 * currentLevel * difference);
			PerkCollection.Loadout.Stats.CriticalChance += 0.5 / 15 * currentLevel * difference * cacheModifier;
		}
	}
}
