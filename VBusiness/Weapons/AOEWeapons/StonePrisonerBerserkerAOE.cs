namespace VBusiness.Weapons
{
	class StonePrisonerBerserkerAOE : BasicAOEAttackWeapon
	{
		// deal 20% of you damage to enemies in 2.5 range

		// the passive part of this is applied to the unit directly, not as a weapon
		public override double AOERadius => 2.5;

		public override double AOEDamagePercent => 20;

		protected override BasicAttackWeapon GetNewBaseWeapon()
		{
			return new StonePrisonerBasicWeapon();
		}
	}
}
