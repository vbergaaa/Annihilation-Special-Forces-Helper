using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room25 : Room
	{
		// Titanic Room 2
		public override RoomNumber RoomNumber => RoomNumber.Room25;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.HydraliskDen, 3),
				new EnemyQuantity(EnemyType.SporeCannon, 8),
				new EnemyQuantity(EnemyType.Hive, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Hydralisk, 15),
				new EnemyQuantity(EnemyType.Infestor, 4),
			};
		}
	}
}
