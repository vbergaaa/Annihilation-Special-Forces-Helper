using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class CriticalChanceGem : Gem
	{
		public CriticalChanceGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Crit Chance";

		protected override decimal BaseCost => 4.49m;

		protected override decimal IncrementCost => .45m;

		protected override void OnPerkLevelChanged(int difference)
		{
			GemCollection.Loadout.Stats.CriticalChance += difference;
		}
	}
}
