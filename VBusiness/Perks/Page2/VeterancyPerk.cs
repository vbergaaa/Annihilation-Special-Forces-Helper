﻿namespace VBusiness.Perks
{
	public class VeterancyPerk : Perk
	{
		public override string Description => "Units start with 10 kills";

		public override byte Page => 2;

		public override byte Position => 4;

		public override int StartingCost => 60;

		public override int IncrementCost => 20;

		public override short MaxLevel => 10;

		protected override string name => "Veterancy";
	}
}
