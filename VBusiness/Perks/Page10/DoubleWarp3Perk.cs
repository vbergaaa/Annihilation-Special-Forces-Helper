﻿namespace VBusiness.Perks
{
	public class DoubleWarp3Perk : Perk
	{
		public override string Description => "Grants a 1% chance to warp in duplicates when buying units";

		public override byte Page => 10;

		public override byte Position => 1;

		public override int StartingCost => 1000;

		public override int IncrementCost => 100;

		public override short MaxLevel => 30;

		protected override string name => "Double Warp III";
	}
}
