using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness
{
	public class IncomeManager : VIncomeManager
	{
		public IncomeManager(VLoadout loadout) : base(loadout)
		{
		}

		#region Double Warp

		public override int DoubleWarp
		{
			get => Math.Min(base.DoubleWarp, 100);
			set
			{
				if (base.DoubleWarp < 100)
				{
					base.DoubleWarp = value;
				}
				else
				{
					var difference = value - 100;
					base.DoubleWarp += difference;
				}
			}
		}

		#endregion

		#region Triple Warp

		public override int TripleWarp
		{
			get => Math.Min(base.TripleWarp, 100);
			set
			{
				if (base.TripleWarp < 100)
				{
					base.TripleWarp = value;
				}
				else
				{
					var difference = value - 100;
					base.TripleWarp += difference;
				}
			}
		}

		#endregion
	}
}
