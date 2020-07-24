using System;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public class Loadout : VLoadout
	{
		public Loadout()
		{
			Stats = new Stats();
			Perks = new PerkCollection();
		}

		public override VPerkCollection Perks 
		{ 
			get => base.Perks;
			set
			{
				UnHookStatsEvents();
				base.Perks = value;
				HookStatsEvents();
			}
		}

		void UpdateStats(object sender, StatsEventArgs e)
		{
			e.Modification(Stats);
		}

		public void HookStatsEvents()
		{
			Perks.PerkLevelChanged += UpdateStats;
		}

		public void UnHookStatsEvents()
		{
			if (Perks != null)
			{
				Perks.PerkLevelChanged -= UpdateStats;
			}
		}
	}
}
