using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class ShieldBatteryBasicWeapon : BasicHealWeapon
	{
		public override double BaseAttack => -5;

		public override double BaseAttackPeriod => 1.5;

		public override double AttackIncrement => -0.25;
	}
}
