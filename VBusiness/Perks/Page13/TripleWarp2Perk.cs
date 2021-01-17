using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class TripleWarp2Perk : Perk
	{
		public TripleWarp2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in two dulcates when buying units";

		public override byte Page => 13;

		public override byte Position => 2;

		public override int StartingCost => 3000;

		public override int IncrementCost => 300;

		protected override string PerkName => "Triple Warp II";

		protected override short MaxLevelCore => 20;
	}
}
