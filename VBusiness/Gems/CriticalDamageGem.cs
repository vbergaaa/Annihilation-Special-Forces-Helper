using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class CriticalDamageGem : Gem
	{
		public CriticalDamageGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Crit Damage";

		protected override decimal BaseCost => 2.5m;

		protected override decimal IncrementCost => .35m;

		protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.CriticalDamage += difference;
	}
}
