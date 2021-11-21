namespace VBusiness.Weapons
{
	class BerserkerWarpLordBasicAttackAOE : BasicAOEAttackWeapon
	{
		public override double AOERadius => 1;

		public override double AOEDamagePercent => 50;

		protected override BasicAttackWeapon GetNewBaseWeapon() => new BerserkerWarpLordBasicWeapon();
	}
}
