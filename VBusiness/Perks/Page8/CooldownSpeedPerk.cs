using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class CooldownSpeedPerk : Perk
    {
		public CooldownSpeedPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases Cooldown speed by 2%";

        public override byte Page => 8;

        public override byte Position => 4;

        public override int StartingCost => 1000;

        public override int IncrementCost => 100;

        public override short MaxLevel => 10;

        protected override string PerkName => "Cooldown Speed";
    }
}
