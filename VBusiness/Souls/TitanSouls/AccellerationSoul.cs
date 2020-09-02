using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class AccellerationSoul : TitanSoul
	{
		public AccellerationSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Accelleration;

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
