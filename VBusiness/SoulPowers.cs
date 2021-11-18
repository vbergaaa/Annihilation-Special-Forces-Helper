using System.Collections.Generic;
using VBusiness.Souls;
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

        static VSoulCollection SoulCollection => Profile.Profile.GetProfile().SoulCollection;

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
				RemoveSoul(soul);
			}
			else if (ActiveSouls.Count < maxPowerSoulCount)
			{
				AddSoul(soul);
			}
			else
			{
				RemoveFirst();
				AddSoul(soul);
			}

			OnPropertyChanged(nameof(PowerSoulsCount));
			OnPropertyChanged(nameof(TotalUniques));
			LoadoutSouls.RefreshPropertyBinding("PowerSoul1");
			LoadoutSouls.RefreshPropertyBinding("PowerSoul2");
			HasChanges = true;
		}

		private void RemoveFirst()
		{
			var soulType = ActiveSouls[0];
			RemoveSoul(soulType);
		}

		private void AddSoul(SoulType soulType)
		{
			ActiveSouls.Add(soulType);
			var soul = Soul.New(soulType, LoadoutSouls);
			soul.ActivateUniqueEffect();
			LoadoutSouls.DeregisterChild(soul);
		}

		void RemoveSoul(SoulType soulType)
		{
			ActiveSouls.Remove(soulType);
			var soul = Soul.New(soulType, LoadoutSouls);
			soul.DeactivateUniqueEffect();
			LoadoutSouls.DeregisterChild(soul);
		}

		public override int PowerSoulsCount => SoulCollection.PowerSoulsCount - ActiveSouls.Count;
		public override int TotalUniques => SoulCollection.TotalUniques;

		public override void OnLoaded()
		{
			foreach (var soulType in ActiveSouls)
			{
				var soul = Soul.New(soulType, LoadoutSouls);
				soul.ActivateUniqueEffect();
				LoadoutSouls.DeregisterChild(soul);
			}
			base.OnLoaded();
		}
	}
}
