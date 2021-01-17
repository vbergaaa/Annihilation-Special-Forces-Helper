using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class RankRevision3Perk : Perk
	{
		public RankRevision3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "";

		public override byte Page => 12;

		public override byte Position => 6;

		public override int StartingCost => 15000;

		public override int IncrementCost => 3500;

		protected override string PerkName => "Rank Revision III";

		protected override short MaxLevelCore => 5;
	}
}
