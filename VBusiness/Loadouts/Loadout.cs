using System;
using VBusiness.Perks;
using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public class Loadout : VLoadout
	{
		public Loadout()
		{
			Perks = new PerkCollection();
		}

		public VPerkCollection Perks { get; set; }
	}
}
