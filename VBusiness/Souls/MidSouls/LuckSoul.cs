using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Souls
{
	public sealed class LuckSoul : MidSoul
	{
		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Luck;
		protected override int MaxCriticalChance => 2;
	}
}
