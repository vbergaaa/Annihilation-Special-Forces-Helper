using System.Collections.Generic;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VModsCollection : BusinessObject
	{
		public VModsCollection(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout;
		}

		public override string BizoName => "Mods";

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout { get; }

		#endregion

		#region Mods

		public virtual IEnumerable<VMod> AllMods { get; }

		public virtual VMod Damage { get; }

		public virtual VMod Health { get; }

		public virtual VMod Armor { get; }

		public virtual VMod SelfMitigation { get; }

		public virtual VMod Speed { get; }

		public virtual VMod DamageReduction { get; }

		public virtual VMod Difficulty { get; }

		public virtual VMod Potency { get; }

		public virtual VMod Taxes { get; }

		public virtual VMod Rank { get; }

		public virtual VMod Tier { get; }

		public virtual VMod Scarcity { get; }

		public virtual VMod Bountyless { get; }

		public virtual VMod Unwell { get; }

		public virtual VMod RankReversion { get; }

		public virtual VMod BossPower { get; }

		public virtual VMod CriticalMiscalculation { get; }

		public virtual VMod GlassCannon { get; }

		public virtual VMod Supply { get; }

		public virtual VMod VolatileDead { get; }

		#endregion

		public virtual int TotalModScore { get; }
	}
}
