using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class AccelerationSoul : TitanSoul
	{
		public AccelerationSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Acceleration;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			SoulCollection.Loadout.Stats.Acceleration += 10;
		}

		protected override void DeactivateSoulCore()
		{
			base.ActivateSoulCore();
			SoulCollection.Loadout.Stats.Acceleration -= 10;
		}
	}
}
