using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalDamage3Perk : Perk
	{
		public CriticalDamage3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Critical Damage";

		public override byte Page => 11;

		public override byte Position => 2;

		public override int StartingCost => 750;

		public override int IncrementCost => 160;

		protected override short MaxLevelCore => 45;

		protected override string PerkName => "Critical Damage III";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.CriticalDamage += 1 * difference;
		}
	}
}
