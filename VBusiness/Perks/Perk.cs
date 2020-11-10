using System;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public abstract class Perk : VPerk
	{
		#region Constructor

		public Perk(VPerkCollection collection) : base(collection)
		{
		}

		#endregion

		#region Properties

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

		#region MaxLevel

		public override short MaxLevel
		{
			get
			{
				if (PerkCollection.Loadout.ShouldRestrict && DesiredLevel < MaxLevelCore)
				{
					return GetMaxLevel();
				}
				return MaxLevelCore;
			}
		}

		short GetMaxLevel()
		{
			var costToMax = VCalculator.Calculate(StartingCost, IncrementCost, DesiredLevel, MaxLevelCore);
			if (costToMax <= PerkCollection.Loadout.RemainingPerkPoints)
			{
				return MaxLevelCore;
			}

			return GetHighestLevelPPCanAfford();
		}

		short GetHighestLevelPPCanAfford()
		{
			var remainingPP = PerkCollection.Loadout.RemainingPerkPoints;
			for (var i = MaxLevelCore; i >= DesiredLevel; i--)
			{
				if (VCalculator.Calculate(StartingCost, IncrementCost, DesiredLevel, i) <= remainingPP)
				{
					return i;
				}
			}
			return DesiredLevel;
		}

		#endregion

		#region DesiredLevel

		public override short DesiredLevel
		{
			get => base.DesiredLevel;
			set
			{
				if (value > MaxLevel)
				{
					base.DesiredLevel = MaxLevel;
				}
				else if (value < 0)
				{
					base.DesiredLevel = 0;
				}
				else
				{
					base.DesiredLevel = value;
				}
			}
		}

		#endregion

		#endregion
	}
}
