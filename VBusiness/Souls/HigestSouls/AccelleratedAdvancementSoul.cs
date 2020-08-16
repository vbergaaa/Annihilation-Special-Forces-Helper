using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class AccelleratedAdvancementSoul : HighestSoul
	{
		public AccelleratedAdvancementSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.AccelleratedAdvancement;
	}
}
