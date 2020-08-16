using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class DemolitionSoul : TormentedSoul
	{
		public DemolitionSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Demolition;

		protected override int MinCriticalChance => 6;
		protected override int MaxCriticalChance => 10;
	}
}
