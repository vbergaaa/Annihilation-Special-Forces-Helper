using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DamageReduction2Perk : Perk
	{
		public DamageReduction2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Reduce damage taken by your units by 1% (additive with itself)";

		public override byte Page => 11;

		public override byte Position => 5;

		public override int StartingCost => 2000;

		public override int IncrementCost => 1000;

		public override short MaxLevel => 10;

		protected override string PerkName => "Damage Reduction II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.DamageReduction += 1 * difference;
		}
	}
}
