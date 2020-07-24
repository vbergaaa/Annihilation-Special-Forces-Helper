using System;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public abstract class Perk : VPerk
	{
		public Perk() { }

		#region Cost

		public override int RemainingCost
		{
			get => this.GetRemainingCost();
		}

		public override int CurrentCost
		{
			get => this.GetCurrentCost();
		}

		public override int TotalCost
		{
			get => this.GetTotalCost();
		}

		#endregion

		#region Stats

		protected override Action<VStats> GetStatsModifier(int levelDifference)
		{
			return null;
		}

		#endregion
	}
}
