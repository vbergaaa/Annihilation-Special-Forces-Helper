namespace VBusiness.Weapons
{
	public class BladeMasterBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 15;

		public override double BaseAttackPeriod => 2.3;

		// in relatity, The AttackCount of this is 20, because it drops two blades that attack 10 times. 
		// But putting it as 20 makes it to difficult to balance compared to other units so adjusting it to 2;
		public override double AttackCount => 2;

		public override double AttackIncrement => 1.5;

		public override double ArmorPenetration => 35;
	}
}
