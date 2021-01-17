using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class SuperJackpot2Perk : Perk
	{
		public SuperJackpot2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases Mineral Jackpot Reward by 10 Minerals and 1 Kill";

		public override byte Page => 13;

		public override byte Position => 3;

		public override int StartingCost => 6000;

		public override int IncrementCost => 2000;

		protected override string PerkName => "Super Jackpot II";

		protected override short MaxLevelCore => 20;
	}
}
