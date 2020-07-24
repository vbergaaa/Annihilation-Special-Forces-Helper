using System;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class AttackPerk : Perk
	{
		protected override string name => "Attack";

		public override string Description => "Increased Damage of your units by 3%";

		public override byte Page => 1;

		public override byte Position => 1;

		public override int StartingCost => 10;

		public override int IncrementCost => 10;

		public override short MaxLevel => 10;

		protected override Action<VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => { stats.Attack += 3 * levelDifference; };
		}
	}
}
