﻿namespace VBusiness.Perks
{
    public class UnitStoragePerk : Perk
    {
        public override string Description => "Allows you to store units using @in. Stored units take up 1 less supply and are the priority material for infusing.";

        public override byte Page => 7;

        public override byte Position => 5;

        public override int StartingCost => 20000;

        public override int IncrementCost => 0;

        public override short MaxLevel => 1;

        protected override string name => "Unit Storage";
    }
}
