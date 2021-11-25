using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class GiantAbberation : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.GiantAbberation;

		public override double Attack => 20;

		public override double AttackSpeed => 2;

		public override double Health => 250;

		public override double HealthArmor => 10;

		public override double AttackIncrement => 4;

		public override double HealthIncrement => 30;

		public override double HealthArmorIncrement => 3.5;

		public override int MineralBounty => 35;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Roach, 4) };

		internal override IEnumerable<EnemyQuantity> GetUnitsSpawnedOnDeath(double tierUpLevels, RoomNumber room)
		{
			return tierUpLevels > 0 && room > RoomNumber.Room23
				? Array.Empty<EnemyQuantity>()
				: UnitsSpawnedOnDeath;
		}
	}
}
