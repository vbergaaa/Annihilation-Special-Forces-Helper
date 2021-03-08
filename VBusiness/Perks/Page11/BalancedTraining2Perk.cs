using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class BalancedTraining2Perk : Perk
	{
		public BalancedTraining2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Damage\r\n+1% Attack Speed\r\n+1% Vitals\r\n+1% Armor";

		public override byte Page => 11;

		public override byte Position => 3;

		public override int StartingCost => 2500;

		public override int IncrementCost => 500;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Balanced Training II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Attack += 1 * difference;
			PerkCollection.Loadout.Stats.UpdateAttackSpeed("Core", difference);
			PerkCollection.Loadout.Stats.UpdateHealth("Core", 1 * difference);
			PerkCollection.Loadout.Stats.HealthArmor += 1 * difference;
			PerkCollection.Loadout.Stats.UpdateShields("Core", 1 * difference);
			PerkCollection.Loadout.Stats.ShieldsArmor += 1 * difference;
		}
	}
}
