using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class ForgedAdeptBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 35;

		public override double BaseAttackPeriod => 1.3;

		public override double AttackIncrement => 1.6;

		protected override double GetActualWeaponPeriod(VLoadout loadout)
		{
			return WeaponHelper.GetAttackPeriodWithAdeptAnnihilationTransfer(loadout, base.GetActualWeaponPeriod(loadout), cooldown: 16, aoeTargets: 4, attacksInDuration: 5);
		}
	}
}
