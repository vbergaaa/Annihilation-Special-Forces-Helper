using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class SoulCollection : VSoulCollection
	{
		public SoulCollection(VProfile profile) : base(profile)
		{
		}

		public override void SaveState()
		{
			savedStateList = new List<SoulType>();
			foreach (var soulType in DiscoveredSouls)
			{
				savedStateList.Add(soulType);
			}
		}

		public override void ResetState()
		{
			DiscoveredSouls.Clear();
			foreach (var soulType in savedStateList)
			{
				DiscoveredSouls.Add(soulType);
			}
			HasChanges = false;
		}

		List<SoulType> savedStateList;
	}
}
