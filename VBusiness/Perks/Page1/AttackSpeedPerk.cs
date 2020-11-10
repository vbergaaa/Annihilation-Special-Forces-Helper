
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class AttackSpeedPerk : Perk
	{
		public AttackSpeedPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Attack Speed";

		public override string Description => "Increase Attack Speed of all your units by 2%";

		public override byte Page => 1;

		public override byte Position => 2;

		public override int StartingCost => 15;

		public override int IncrementCost => 13;

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.AttackSpeed += 2 * difference;
		}
	}
}
