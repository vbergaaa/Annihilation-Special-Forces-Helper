namespace VBusiness.Weapons
{
	public class ForgedAdeptBasicWeapon : BaseAdeptBounceWeapon
	{
		public override double BaseAttack => 35;

		public override double BaseAttackPeriod => 1.3;

		public override double AttackIncrement => 1.6;

		protected override int MaxBounces => 3;

		protected override double BounceDamagePercentage => 85;

		protected override bool IncludeTransferInDamageCalcs => true;
	}
}
