using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DamageReductionPerk : Perk
	{
		public DamageReductionPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Reduce damage taken by your units by 1% (additive with itself)";

		public override byte Page => 4;

		public override byte Position => 6;

		public override int StartingCost => 150;

		public override int IncrementCost => 50;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Damage Reduction";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.DamageReductionFromStats += 1 * difference;
		}
	}
}
