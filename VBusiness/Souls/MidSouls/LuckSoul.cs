using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class LuckSoul : MidSoul
	{
		public LuckSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Luck;
		public override int MaxCriticalChance => 2;
	}
}
