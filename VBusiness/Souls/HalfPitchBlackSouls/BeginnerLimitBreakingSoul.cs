using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class BeginnerLimitBreakingSoul : HalfPitchBlackSoul
	{
		public BeginnerLimitBreakingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.BeginnerLimitBreaking;
	}
}
