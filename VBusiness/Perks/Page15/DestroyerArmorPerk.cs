using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DestroyerArmorPerk : Perk
	{
		public DestroyerArmorPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => @"+1% Shields Armor
+1% Health Armor";

		public override byte Page => 15;

		public override byte Position => 2;

		public override int StartingCost => 4000;

		public override int IncrementCost => 2500;

		protected override string PerkName => "Destroyer Armor";

		protected override short MaxLevelCore => 100;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.Stats.UpdateHealthArmor("Core", difference);
			PerkCollection.Loadout.Stats.UpdateShieldsArmor("Core", difference);
		}
	}
}
