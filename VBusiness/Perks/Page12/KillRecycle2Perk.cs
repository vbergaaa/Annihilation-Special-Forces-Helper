using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Perks.Page12
{
	public class KillRecycle2Perk : Perk
	{
		public override string Description => "";

		public override byte Page => 12;

		public override byte Position => 4;

		public override int StartingCost => 1200;

		public override int IncrementCost => 375;

		protected override string PerkName => "Kill Recycle II";

		protected override short MaxLevelCore => 5;
	}
}
