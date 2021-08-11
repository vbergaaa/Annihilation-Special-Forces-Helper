namespace VBusiness.Weapons
{
	public class ColossusBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 20;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackCount => 6; //sends out 2 beams but they can hit multiple enemies so saying 6;

		public override double AttackIncrement => 2.2;
	}
}
