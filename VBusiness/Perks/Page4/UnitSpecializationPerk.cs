using Microsoft.VisualBasic;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class UnitSpecializationPerk : Perk
	{
		public UnitSpecializationPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "A random unit (excluding probes) cost 2% * L less, and it as well as any unit formed from it gain 2% * L Damage Increase and 1% * L Damage Reduction, but all other units cost 100% - 10% * L more";

		public override byte Page => 4;

		public override byte Position => 5;

		public override int StartingCost => 500;

		public override int IncrementCost => 100;

		public override short MaxLevel => 10;

		protected override string PerkName => "Unit Specialization";

		protected override void OnLevelChanged(int difference)
		{
			if (PerkCollection.Loadout.UnitConfiguration.HasUnitSpec)
			{
				PerkCollection.Loadout.Stats.DamageIncrease += 2 * difference;
				PerkCollection.Loadout.Stats.DamageReduction += 1 * difference;
			}
		}
	}
}
