namespace VBusiness.Weapons
{
	class TerminatorWarpLordTerminatorWarpAnnihilation : WarpLordWarpAnnihilation
	{
		// cd: 8
		// deal 15-215 damage around a unit
		// deal damage again 1sec later
		// heal 5% shields

		protected override double AbilityCooldown => 8;
		public override double AttackCount => base.AttackCount * 2;
	}
}
