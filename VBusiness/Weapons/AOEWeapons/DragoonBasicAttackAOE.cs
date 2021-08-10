namespace VBusiness.Weapons
{
	class DragoonBasicAttackAOE : BasicAOEAttackWeapon
	{
		// deal 30% extra damage to units in a radius of 1.2 of the target unit
		public override double AOERadius => 1.2;

		public override double AOEDamagePercent => 30;

		protected override BasicAttackWeapon GetNewBaseWeapon() => new DragoonBasicWeapon();
	}
}
