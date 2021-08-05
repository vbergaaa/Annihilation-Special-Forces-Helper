namespace VBusiness.Weapons.BasicWeapons
{
	public class OmniBladerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 2;


		// in relatity, The AttackCount of this is 52, because it drops 4 blades that attack 13 times. 
		// But putting it as 52 makes it to difficult to balance compared to other units so adjusting it to 4;
		public override double AttackCount => 4;

		public override double AttackIncrement => 2;

		public override double ArmorPenetration => 40;
	}
}
