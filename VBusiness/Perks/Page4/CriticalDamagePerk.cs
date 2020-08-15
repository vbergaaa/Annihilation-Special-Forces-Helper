using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalDamagePerk : Perk
	{
		public CriticalDamagePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 1% Critical Damage";

		public override byte Page => 4;

		public override byte Position => 2;

		public override int StartingCost => 60;

		public override int IncrementCost => 20;

		public override short MaxLevel => 15;

		protected override string PerkName => "Critical Damage";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.CriticalDamage += 1 * difference;
		}
	}
}
