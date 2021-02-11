using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class WarpLord : Unit
	{
		public WarpLord(VLoadout loadout) : base(loadout)
		{
		}

		public override int BaseDamage => 5;

		public override int BaseArmor => 2;

		public override int BaseHealth => 100;
	}
}
