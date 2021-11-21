namespace VBusiness.Weapons
{
	class DarkWarpLordBasicAtkAOE : BasicAOEAttackWeapon
	{
		//25% radius 1
		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new DarkWarpLordBasicWeapon();
		}

		public override double AOERadius => 1;

		public override double AOEDamagePercent => 25;
	}
}
