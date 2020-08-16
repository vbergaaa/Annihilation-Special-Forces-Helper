﻿
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class BronzeSoul : LowestSoul
	{
		public BronzeSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Bronze;

		// Starting mining ups +3
	}
}
