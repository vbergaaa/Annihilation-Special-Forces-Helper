using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class TankingSoul : TormentedSoul
	{
		public TankingSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Tanking;

		protected override void ActivateSoulCore()
		{
				base.ActivateSoulCore();
				SoulCollection.Loadout.Stats.DamageReduction += 5;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			SoulCollection.Loadout.Stats.DamageReduction -= 5;
		}
	}
}
