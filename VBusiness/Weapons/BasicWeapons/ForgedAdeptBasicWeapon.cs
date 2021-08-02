namespace VBusiness.Weapons
{
	public class ForgedAdeptBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 35;

		public override double BaseAttackPeriod => 1.3;

		public override double AttackIncrement => 1.6;
	}
}
