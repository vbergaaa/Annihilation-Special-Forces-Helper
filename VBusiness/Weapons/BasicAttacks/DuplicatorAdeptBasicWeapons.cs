namespace VBusiness.Weapons
{
	public class DuplicatorAdeptBasicWeapon : BaseAdeptBounceWeapon
	{
		public DuplicatorAdeptBasicWeapon()
		{
		}

		public override double BaseAttack => 65;

		public override double BaseAttackPeriod => 1.1;

		public override double AttackIncrement => 2.05;

		protected override int MaxBounces => 4;

		protected override double BounceDamagePercentage => 90;

		protected override bool IncludeTransferInDamageCalcs => false;

		public override double AttackCount => 5;
	}
}
