namespace VBusiness.Weapons
{
	class ArchonBasicAttackAOE : BasicAOEAttackWeapon
	{
		// 50% radius 1
		public override double AOERadius => 1;

		public override double AOEDamagePercent => 50;

		protected override BasicAttackWeapon GetNewBaseWeapon() => new ArchonBasicWeapon();
	}
}
