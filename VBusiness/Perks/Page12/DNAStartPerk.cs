using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Perks.Page12
{
	class DNAStartPerk : Perk
	{
		public DNAStartPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants the first DNA1 unit an extra infusion";

		public override byte Page => 12;

		public override byte Position => 5;

		public override int StartingCost => 2000;

		public override int IncrementCost => 2000;

		protected override string PerkName => "DNA Start";

		protected override short MaxLevelCore => 5;
	}
}
