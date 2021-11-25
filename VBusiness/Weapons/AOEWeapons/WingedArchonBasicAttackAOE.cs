namespace VBusiness.Weapons
{
	class WingedArchonBasicAttackAOE : BasicAOEAttackWeapon
	{
		// 100% radius 3
		public override double AOERadius => 3;

		public override double AOEDamagePercent => 100;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new WingedArchonBasicWeapon();
		}
	}
}
