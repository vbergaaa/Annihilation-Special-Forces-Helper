﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class Veterancy4Perk : Perk
	{
		public Veterancy4Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Units start with +10 kills";

		public override byte Page => 12;

		public override byte Position => 3;

		public override int StartingCost => 1300;

		public override int IncrementCost => 500;

		protected override string PerkName => "Veterancy IV";

		protected override short MaxLevelCore => 20;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.Veterancy += difference * 10;
		}
	}
}
