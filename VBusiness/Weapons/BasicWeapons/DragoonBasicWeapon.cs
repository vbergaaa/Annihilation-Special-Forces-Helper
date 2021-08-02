namespace VBusiness.Weapons
{
	public class DragoonBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 15;

		public override double BaseAttackPeriod => 1.3;

		public override double AttackIncrement => 1;
	}
}
