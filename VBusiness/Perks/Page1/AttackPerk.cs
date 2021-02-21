using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class AttackPerk : Perk
	{
		public AttackPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Attack";

		public override string Description => "+3% Damage";

		public override byte Page => 1;

		public override byte Position => 1;

		public override int StartingCost => 10;

		public override int IncrementCost => 10;

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Attack += 3 * difference;
		}
	}
}
