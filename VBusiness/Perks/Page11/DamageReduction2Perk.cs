using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DamageReduction2Perk : Perk
	{
		public DamageReduction2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "1% Damage Reduction";

		public override byte Page => 11;

		public override byte Position => 5;

		public override int StartingCost => 2000;

		public override int IncrementCost => 1000;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Damage Reduction II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.UpdateDamageReduction("Core", 1 * difference);
		}
	}
}
