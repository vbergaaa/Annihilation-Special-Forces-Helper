namespace VBusiness.Weapons
{
	public class LightAdeptBasicWeapon : BaseAdeptBounceWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 1.25;

		protected override int MaxBounces => 1; // this is really 0, but the base class logic requires this be > 0

		protected override double BounceDamagePercentage => throw new System.NotImplementedException();

		protected override bool IncludeTransferInDamageCalcs => true;
	}
}
