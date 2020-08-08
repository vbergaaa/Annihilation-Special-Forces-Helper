using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Souls
{
	public sealed class GreedSoul : MidSoul
	{
		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Greed;

		protected override int MinMinerals => 3000;

		protected override int MaxMinerals => 4000;
	}
}
