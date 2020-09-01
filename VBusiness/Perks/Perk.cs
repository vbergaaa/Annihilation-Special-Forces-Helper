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

		#region CurrentLevel

		//public override short CurrentLevel
		//{
		//	get => base.CurrentLevel;
		//	set
		//	{
		//		if (value > MaxLevel)
		//		{
		//			base.CurrentLevel = MaxLevel;
		//		}
		//		else if (value < 0)
		//		{
		//			base.CurrentLevel = 0;
		//		}
		//		else
		//		{
		//			base.CurrentLevel = value;
		//		}
		//	}
		//}

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
