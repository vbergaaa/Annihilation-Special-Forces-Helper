using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness
{
	public class SoulPowers : VSoulPowers
	{
		public SoulPowers(VLoadoutSouls loadoutSouls) : base(loadoutSouls)
		{
		}

		public override List<SoulType> ActiveSouls => fActiveSouls ??= new List<SoulType>();
		List<SoulType> fActiveSouls;

		VSoulCollection SoulCollection => Profile.Profile.GetProfile().SoulCollection;

		public override bool GetBindingValue(SoulType soul)
		{
			return ActiveSouls.Contains(soul);
		}

		public override bool GetBindingVisibility(SoulType soul)
		{
			return SoulCollection.GetBindingValue(soul);
		}

		public override void ToggleSoul(SoulType soul)
		{
			var maxPowerSoulCount = SoulCollection.PowerSoulsCount;
			if (maxPowerSoulCount == 0)
			{
				return;
			}

			if (ActiveSouls.Contains(soul))
			{
				ActiveSouls.Remove(soul);
			}
			else if (ActiveSouls.Count < maxPowerSoulCount)
			{
				ActiveSouls.Add(soul);
			}
			else
			{
				ActiveSouls.RemoveAt(0);
				ActiveSouls.Add(soul);
			}

			OnPropertyChanged(nameof(PowerSoulsCount));
			OnPropertyChanged(nameof(TotalUniques));
			LoadoutSouls.RefreshPropertyBinding("PowerSoul1");
			LoadoutSouls.RefreshPropertyBinding("PowerSoul2");
			HasChanges = true;
		}

		public override int PowerSoulsCount => SoulCollection.PowerSoulsCount - ActiveSouls.Count;
		public override int TotalUniques => SoulCollection.TotalUniques;
	}
}
