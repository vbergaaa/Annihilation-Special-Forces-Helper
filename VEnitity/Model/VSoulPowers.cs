using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Data;
using VEntityFramework.Interfaces;

namespace VEntityFramework.Model
{
	public class VSoulPowers : BusinessObject, ISoulCollectable
	{
		public VSoulPowers(VLoadoutSouls loadoutSouls) : base(loadoutSouls)
		{
			LoadoutSouls = loadoutSouls;
		}

		[VXML(true)]
		public virtual List<SoulType> ActiveSouls { get; }
		public override string BizoName => "SoulPowers";

		[VXML(false)]
		public VLoadoutSouls LoadoutSouls { get; }

		public virtual int TotalUniques => 0;

		public virtual int PowerSoulsCount => 0;

		public string PowerSoulsCountCaption => "Remaining Souls:";

		public virtual bool GetBindingValue(SoulType soul) => false;

		public virtual bool GetBindingVisibility(SoulType soul) => false;

		public virtual void ToggleSoul(SoulType soul)
		{
		}
	}
}
