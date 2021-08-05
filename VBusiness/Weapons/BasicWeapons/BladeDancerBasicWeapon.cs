namespace VBusiness.Weapons
{
	public class BladeDancerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 10;

		public override double BaseAttackPeriod => 2.5;


		// in relatity, The AttackCount of this is 10, because it's blade attacks 10 times. 
		// But putting it as 10 makes it to difficult to balance compared to other units so adjusting it back to 1;
		public override double AttackCount => 1;

		public override double AttackIncrement => 1;
	}
}
