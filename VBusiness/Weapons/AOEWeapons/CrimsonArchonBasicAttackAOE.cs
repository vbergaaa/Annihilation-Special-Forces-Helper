namespace VBusiness.Weapons
{
	class CrimsonArchonBasicAttackAOE : BasicAOEAttackWeapon
	{
		// 100%, 2.2radius
		public override double AOERadius => 2.2;

		public override double AOEDamagePercent => 100;

		protected override BasicAttackWeapon GetNewBaseWeapon() => new CrimsonArchonBasicWeapon();
	}
}
