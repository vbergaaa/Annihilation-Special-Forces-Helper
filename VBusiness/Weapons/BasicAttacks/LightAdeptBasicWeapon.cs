using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class LightAdeptBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 1.25;

		protected override double GetActualWeaponPeriod(VLoadout loadout)
		{
			return WeaponHelper.GetAttackPeriodWithAdeptAnnihilationTransfer(loadout, base.GetActualWeaponPeriod(loadout), cooldown: 16, aoeTargets: 4, attacksInDuration: 5);
		}
	}
}
