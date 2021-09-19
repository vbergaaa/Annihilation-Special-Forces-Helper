namespace VBusiness.Weapons
{
	public class SplitterAdeptBasicWeapon : BaseAdeptBounceWeapon
	{
		public SplitterAdeptBasicWeapon()
		{
		}

		public override double BaseAttack => 45;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackIncrement => 1.8;

		protected override int MaxBounces => 4;

		protected override double BounceDamagePercentage => 90;

		protected override bool IncludeTransferInDamageCalcs => false;

		public override double AttackCount => 3;
	}
}
