namespace VBusiness.Weapons
{
	class ReaverBasicAttackAOE : BasicAOEAttackWeapon
	{
		// 80% damage radius 2
		public override double AOERadius => 2;

		public override double AOEDamagePercent => 80;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new ReaverBasicWeapon();
		}
	}
}
