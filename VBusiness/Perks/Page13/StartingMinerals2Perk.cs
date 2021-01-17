using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class StartingMinerals2Perk : Perk
	{
		public StartingMinerals2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 1000 minerals";

		public override byte Page => 13;

		public override byte Position => 4;

		public override int StartingCost => 1000;

		public override int IncrementCost => 500;

		protected override string PerkName => "Starting Minerals II";

		protected override short MaxLevelCore => 30;
	}
}
