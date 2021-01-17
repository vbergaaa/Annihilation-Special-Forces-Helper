using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Perks.Page12
{
	public class MaximumPotential4Perk : Perk
	{
		public MaximumPotential4Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases maximum kill count and maximum life essense by 50";

		public override byte Page => 12;

		public override byte Position => 2;

		public override int StartingCost => 1200;

		public override int IncrementCost => 200;

		protected override string PerkName => "Maximum Potential IV";

		protected override short MaxLevelCore => 10;
	}
}
