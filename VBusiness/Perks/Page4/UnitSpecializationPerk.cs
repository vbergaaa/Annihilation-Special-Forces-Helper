using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class UnitSpecializationPerk : Perk
	{
		public UnitSpecializationPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gives a random unit type +2% Damage Increase, +1% Damage Reduction, -2% Cost.\r\nAll other units cost (100-10*L)% more";

		public override byte Page => 4;

		public override byte Position => 5;

		public override int StartingCost => 500;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Unit Specialization";

		protected override void OnLevelChanged(int difference)
		{
			if (PerkCollection.Loadout.UnitConfiguration.HasUnitSpec)
			{
				PerkCollection.Loadout.Stats.DamageIncrease += 2 * difference;
				PerkCollection.Loadout.Stats.UpdateDamageReduction("Spec", difference);
			}
		}
	}
}
