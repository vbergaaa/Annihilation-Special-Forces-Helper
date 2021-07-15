using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class BeginnerLimitBreakingSoul : HalfPitchBlackSoul
	{
		public BeginnerLimitBreakingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.BeginnerLimitBreaking;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();

			foreach (var unit in Loadout.Units)
			{
				unit.LimitlessEssenceStacks += 5;
			}

			Loadout.CurrentUnit.RefreshPropertyBinding(nameof(Loadout.CurrentUnit.MaximumKills));
			Loadout.CurrentUnit.RefreshPropertyBinding(nameof(Loadout.CurrentUnit.MaximumInfusion));
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();

			foreach (var unit in Loadout.Units)
			{
				unit.LimitlessEssenceStacks -= 5;
			}

			Loadout.CurrentUnit.RefreshPropertyBinding(nameof(Loadout.CurrentUnit.MaximumKills));
			Loadout.CurrentUnit.RefreshPropertyBinding(nameof(Loadout.CurrentUnit.MaximumInfusion));
		}
	}
}
