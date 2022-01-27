using VBusiness.Units;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class OverInfusePerk : Perk
	{
		public OverInfusePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Allows an additional infusion on limit broken units";

		public override byte Page => 15;

		public override byte Position => 4;

		public override int StartingCost => 1000000;

		public override int IncrementCost => 1000000;

		protected override string PerkName => "Overinfuse";

		protected override short MaxLevelCore => 3;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			var unit = Loadout.CurrentUnit as Unit;
			var oldMaximumInfusion = unit.GetMaxInfusion(unit.MaximumKills);
			Loadout.Stats.OverInfuseStacks += difference;

			if (oldMaximumInfusion == Loadout.CurrentUnit.CurrentInfusion)
			{
				unit.CurrentInfusion = unit.MaximumInfusion;
			}

			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding(nameof(PerkCollection.Loadout.CurrentUnit.MaximumInfusion));
		}
	} 
}
