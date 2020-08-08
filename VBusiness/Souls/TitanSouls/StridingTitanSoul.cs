using System;
using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class StridingTitanSoul : TitanSoul
	{
		public override SoulType Type => SoulType.StridingTitan;

		public override Action<VStats> ActivateStats
		{
			get
			{
				return (stats) =>
				{
					base.ActivateStats(stats);
					stats.Attack += 20;
					stats.AttackSpeed += 20;
					stats.Health += 20;
					stats.Shields += 20;
				};
			}
		}
	}
}
