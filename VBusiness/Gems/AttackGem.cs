using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class AttackGem : Gem
	{
		public AttackGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Attack";

		protected override decimal IncrementCost => 0.2m;

		protected override decimal BaseCost => 1.4m;

		protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.Attack += difference;
	}
}
