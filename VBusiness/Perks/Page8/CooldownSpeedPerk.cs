using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CooldownSpeedPerk : Perk
	{
		public CooldownSpeedPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+2% Cooldown Speed";

		public override byte Page => 8;

		public override byte Position => 4;

		public override int StartingCost => 1000;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Cooldown Speed";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			PerkCollection.Loadout.Stats.CooldownReduction += 2 * difference;

			var perks = PerkCollection as PerkCollection;
			if (DesiredLevel == MaxLevel && perks.UpgradeCache.DesiredLevel == 1)
			{
				PerkCollection.Loadout.Stats.CooldownReduction += 20;
			}
			else if (DesiredLevel - difference == MaxLevel && perks.UpgradeCache.DesiredLevel == 1)
			{
				PerkCollection.Loadout.Stats.CooldownReduction -= 20;
			}
		}
	}
}
