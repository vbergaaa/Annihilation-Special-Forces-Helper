using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DestroyerVitalsPerk : Perk
	{
		public DestroyerVitalsPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => @"+1% Shields
+1% Health
+1% Sheild Regen
+1% Health Regen";

		public override byte Page => 15;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 1000;

		protected override string PerkName => "Destroyer Vitals";

		protected override short MaxLevelCore => 200;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.Stats.UpdateHealth("Core", difference);
			PerkCollection.Loadout.Stats.UpdateShields("Core", difference);
		}
	}
}
