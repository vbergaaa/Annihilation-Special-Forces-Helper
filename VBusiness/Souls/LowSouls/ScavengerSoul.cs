using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Souls
{
	public sealed class ScavengerSoul : LowSoul
	{
		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Scavenger;
	}
}
