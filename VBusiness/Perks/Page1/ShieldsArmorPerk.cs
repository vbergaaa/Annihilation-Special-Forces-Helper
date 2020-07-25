namespace VBusiness.Perks
{
	public class ShieldsArmorPerk : Perk
	{
		protected override string name => "Shields Armor";
		
		public override string Description => "Increase Shields Armor of all units by 2%";

		public override byte Page => 1;

		public override byte Position => 4;

		public override int StartingCost => 20;

		public override int IncrementCost => 20;

		public override short MaxLevel => 10;

		protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => { stats.ShieldsArmor += 2 * levelDifference; };
		}
	}
}
