namespace VBusiness.Weapons
{
	public class PurificationWalkerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 30;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackCount => 2;

		public override double AttackIncrement => 2.5;
	}
}
