using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DominatorSpeedPerk : Perk
	{
		public DominatorSpeedPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase Attack Speed of your units by 1%";

		public override byte Page => 14;

		public override byte Position => 2;

		public override int StartingCost => 3000;

		public override int IncrementCost => 1500;

		protected override string PerkName => "Dominator Attack Speed";

		protected override short MaxLevelCore => 150;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.AttackSpeed += difference;
		}
	}
}
