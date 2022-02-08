using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class PowerWarpingSoul : NightSoul
	{
		public PowerWarpingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.PowerWarping;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();

			var bonusDoubleWarp = 0;

			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var unit = Loadout.CurrentUnit;
				Loadout.CurrentUnit = VUnit.New(UnitType.None, Loadout);
				bonusDoubleWarp = (int)(Loadout.Stats.Attack - 100) / 10;
				Loadout.CurrentUnit = unit;
			}

			Loadout.IncomeManager.DoubleWarp += 5 + bonusDoubleWarp;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();

			var bonusDoubleWarp = 0;

			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var unit = Loadout.CurrentUnit;
				Loadout.CurrentUnit = VUnit.New(UnitType.None, Loadout);
				bonusDoubleWarp = (int)(Loadout.Stats.Attack - 100) / 10;
				Loadout.CurrentUnit = unit;
			}

			Loadout.IncomeManager.DoubleWarp -= 5 + bonusDoubleWarp;
		}
	}
}
