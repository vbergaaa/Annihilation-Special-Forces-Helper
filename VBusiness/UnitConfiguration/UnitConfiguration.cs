using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;
using VBusiness.Ranks;

namespace VBusiness
{
	public class UnitConfiguration : VUnitConfiguration
	{
		public override UnitRank UnitRank
		{
			get => base.UnitRank;
			set
			{
				base.UnitRank = value;
				Rank = Ranks.Rank.New(UnitRank);
			}
		}
	}
}
