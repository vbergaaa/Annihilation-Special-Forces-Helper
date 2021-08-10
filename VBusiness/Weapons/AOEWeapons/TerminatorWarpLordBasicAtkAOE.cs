namespace VBusiness.Weapons
{
	class TerminatorWarpLordBasicAtkAOE : BasicAOEAttackWeapon
	{
		// 100% damage radius 1
		public override double AOERadius => 1;

		public override double AOEDamagePercent => 100;

		protected override BasicAttackWeapon GetNewBaseWeapon() => new TerminatorWarpLordBasicWeapon();
	}
}
