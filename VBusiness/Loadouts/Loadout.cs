using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using VBusiness.Perks;
using VModel;

namespace VBusiness.Loadouts
{
	public class Loadout
	{
		public Loadout()
		{
			Perks = new PerkCollection();
		}
		public VPerkCollection Perks { get; set; }
	}
}
