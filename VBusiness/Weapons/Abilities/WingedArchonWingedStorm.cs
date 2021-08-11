namespace VBusiness.Weapons
{
	public class WingedArchonWingedStorm : TemplarStorm
	{
		// casts 7 storms
		// 70-840-1451 damage (0-100 atk ups, 0-15 as ups)
		// CD = 10
		// DUR = 4

		protected override double AbilityCooldown => 10;
		public override double AttackCount => base.AttackCount * 7;
	}
}
