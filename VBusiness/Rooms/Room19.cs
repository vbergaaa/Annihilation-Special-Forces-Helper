using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room19 : Room
	{
		// Insane room 3
		public override RoomNumber RoomNumber => RoomNumber.Room19;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 3),
				new EnemyQuantity(EnemyType.Lair, 2),
				new EnemyQuantity(EnemyType.HydraliskDen, 3),
				new EnemyQuantity(EnemyType.SporeCannon, 10)
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.GiantAbberation, 8),
				new EnemyQuantity(EnemyType.Hydralisk, 15),
			};
		}
	}
}
