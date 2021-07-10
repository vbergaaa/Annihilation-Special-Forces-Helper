using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class ExperimentalRankingSoul : HalfPitchBlackSoul
	{
		public ExperimentalRankingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.ExperimentalRanking;
	}
}
