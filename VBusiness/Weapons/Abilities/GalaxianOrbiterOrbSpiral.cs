namespace VBusiness.Weapons
{
	class GalaxianOrbiterOrbSpiral : CommonOrbAbility
	{
		// shoot 16 orbs in a spiral
		// cd: 10

		public override int OrbsPerAttack => 16;

		public override int OrbTravelDuration => 6;

		protected override double AbilityCooldown => 10;

		protected override CommonOrbAttack GetBasicOrbWeapon() => new GalaxianOrbiterBasicWeapon();
	}
}
