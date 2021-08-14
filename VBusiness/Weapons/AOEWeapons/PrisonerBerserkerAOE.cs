namespace VBusiness.Weapons
{
	class PrisonerBerserkerAOE : BasicAOEAttackWeapon
	{
		// see StonPrisonerBerserker
		public override double AOERadius => 2.5;

		public override double AOEDamagePercent => 20;

		protected override BasicAttackWeapon GetNewBaseWeapon() => new PrisonerBasicWeapon();
	}
}
