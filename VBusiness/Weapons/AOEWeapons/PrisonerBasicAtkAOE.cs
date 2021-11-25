namespace VBusiness.Weapons
{
	class PrisonerBasicAtkAOE : BasicAOEAttackWeapon
	{
		// deal 30% of damage in a radius of 1.3;
		public override double AOERadius => 1.3;

		public override double AOEDamagePercent => 30;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new PrisonerBasicWeapon();
		}
	}
}
