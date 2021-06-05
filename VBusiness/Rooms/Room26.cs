using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room26 : Room
	{
		// Mythic Room 1
		public override RoomNumber RoomNumber => RoomNumber.Room26;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 3),
				new EnemyQuantity(EnemyType.HydraliskDen, 2),
				new EnemyQuantity(EnemyType.SporeCannon, 15),
				new EnemyQuantity(EnemyType.Hive, 2),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Hydralisk, 10),
				new EnemyQuantity(EnemyType.Infestor, 8),
			};
		}
	}
}
