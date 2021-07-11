using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class ExperimentalRankingSoul : HalfPitchBlackSoul
	{
		public ExperimentalRankingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.ExperimentalRanking;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.HasRSSS = true;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.HasRSSS = false;
		}
	}
}
