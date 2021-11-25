namespace VBusiness.Weapons
{
	class DisruptorBasicAttackAOE : BasicAOEAttackWeapon
	{
		// deal 100% damage in a radius of 2
		public override double AOERadius => 2;

		public override double AOEDamagePercent => 100;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new DisruptorBasicWeapon();
		}
	}
}
