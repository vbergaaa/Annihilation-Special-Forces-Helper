namespace VBusiness.Perks
{
    public class UnitSpecializationPerk : Perk
    {
        public override string Description => "A random unit (excluding probes) cost 2% * L less, and it as well as any unit formed from it gain 2% * L Damage Increase and 1% * L Damage Reduction, but all other units cost 100% - 10% * L more";

        public override byte Page => 4;

        public override byte Position => 5;

        public override int StartingCost => 500;

        public override int IncrementCost => 100;

        public override short MaxLevel => 10;

        protected override string name => "Unit Specialization";
    }
}
