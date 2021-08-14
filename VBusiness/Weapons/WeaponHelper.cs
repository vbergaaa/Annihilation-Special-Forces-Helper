using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public static class WeaponHelper
	{
		public static double GetEnemiesInRadius(double radius)
		{
			// it's assumed throughout this app for damage calculations that there can be 4 enemies in a 1 radius block
			// therefore, averaging out the area using pi*r^2, in a 2 radius block, there can be 16 enemies, and a 3 radius block there can be 36 enemies

			return 4 * radius * radius;
		}

		internal static double GetEnemiesAttackedInDuration(double duration, VLoadout loadout, BasicAttackWeapon weapon)
		{
			var attackSpeed = weapon.GetActualWeaponPeriod(loadout);
			return duration / attackSpeed;
		}
	}
}
