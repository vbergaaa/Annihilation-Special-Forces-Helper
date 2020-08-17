using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;
using VBusiness.Ranks;

namespace VBusiness
{
	public class UnitConfiguration : VUnitConfiguration
	{
		#region Constructor

		public UnitConfiguration(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region Unit Configuration

		public override UnitRank UnitRank
		{
			get => base.UnitRank;
			set
			{
				base.UnitRank = value;
				Rank = Ranks.Rank.New(UnitRank, this);
			}
		}

		#endregion

		#endregion
	}
}
