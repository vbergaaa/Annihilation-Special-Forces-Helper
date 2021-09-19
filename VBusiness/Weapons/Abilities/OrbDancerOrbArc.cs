namespace VBusiness.Weapons
{
	public class OrbDancerOrbArc : CommonOrbAbility
	{
		// shoot 5 orbs in an arc to the target location, with no AS ups, orbs attack 3 times
		// cd 8
		public override int OrbTravelDuration => 3;

		public override int OrbsPerAttack => 5;

		protected override double AbilityCooldown => 8;

		protected override CommonOrbAttack GetBasicOrbWeapon()
		{
			return new OrbDancerBasicWeapon();
		}
	}
}
