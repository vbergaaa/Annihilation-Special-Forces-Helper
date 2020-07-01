namespace VBusiness.Perks
{
    public class ShieldsPerk : Perk
    {
        protected override string name => "Shields";
        
        public override string Description => "Increase Shields and Shields Regen of all your units by 2.5%";

        public override byte Page => 1;

        public override byte Position => 3;

        public override int StartingCost => 15;

        public override int IncrementCost => 15;

        public override short MaxLevel => 10;
    }
}
