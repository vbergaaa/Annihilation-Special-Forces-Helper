using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class TankingSoul : TormentedSoul
	{
		public override SoulType Type => SoulType.Tanking;

		public override Action<VStats> ActivateStats
		{
			get
			{
				return (stats) =>
				{
					base.ActivateStats(stats);
					stats.DamageReduction += 5;
				};
			}
		}

		public override Action<VStats> DeactivateStats
		{
			get
			{
				return (stats) =>
				{
					base.DeactivateStats(stats);
					stats.DamageReduction -= 5;
				};
			}
		}
	}
}
