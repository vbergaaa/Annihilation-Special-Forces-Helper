namespace VBusiness.Weapons
{
	class DarkArchonBasicAttackAOE : BasicAOEAttackWeapon
	{
		// 100%, 1.5radius
		public override double AOERadius => 1.5;

		public override double AOEDamagePercent => 100;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new DarkArchonBasicWeapon();
		}
	}
}
