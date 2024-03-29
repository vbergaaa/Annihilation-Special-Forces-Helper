﻿using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Data;
using VEntityFramework.Interfaces;

namespace VEntityFramework.Model
{
	public abstract class VSoulCollection : BusinessObject, ISoulCollectable
	{
		public VSoulCollection(VProfile profile) : base(profile)
		{
		}

		#region DiscoveredSouls

		[VXML(true)]
		public List<SoulType> DiscoveredSouls => fDiscoveredSouls ??= new List<SoulType>();
		List<SoulType> fDiscoveredSouls;

		#endregion

		#region TotalUniques

		public int TotalUniques => DiscoveredSouls.Count;

		#endregion

		#region PowerSouls

		public int PowerSoulsCount => TotalUniques / 24;

		#endregion

		#region Methods

		#region SaveState

		public virtual void SaveState()
		{
		}

		#endregion

		#region ResetState

		public virtual void ResetState()
		{
		}

		#endregion

		#endregion

		#region Overrides

		protected override void OnChangeMade()
		{
			base.OnChangeMade();

			RefreshPropertyBinding(nameof(PowerSoulsCount));
			RefreshPropertyBinding(nameof(TotalUniques));
		}

		#endregion

		public override string BizoName => "SoulCollection";

		#region ISoulCollectable Members

		public void ToggleSoul(SoulType soul)
		{
			if (DiscoveredSouls.Any(s => s == soul))
			{
				DiscoveredSouls.Remove(soul);
				HasChanges = true;
			}
			else
			{
				DiscoveredSouls.Add(soul);
				HasChanges = true;
			}
		}

		public bool GetBindingValue(SoulType soul)
		{
			return DiscoveredSouls.Any(s => s == soul);
		}

		public bool GetBindingVisibility(SoulType soul)
		{
			return soul != SoulType.None;
		}

		public string PowerSoulsCountCaption => "Available Souls:";

		#endregion
	}
}
