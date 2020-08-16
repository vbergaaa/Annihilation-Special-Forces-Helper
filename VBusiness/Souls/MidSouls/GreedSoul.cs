using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GreedSoul : MidSoul
	{
		public GreedSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Greed;

		protected override int MinMinerals => 3000;

		protected override int MaxMinerals => 4000;
	}
}
