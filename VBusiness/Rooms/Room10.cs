using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room10 : Room
	{
		// Normal Room 1
		public override RoomNumber RoomNumber => RoomNumber.Room10;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpawningPool, 2),
				new EnemyQuantity(EnemyType.RoachWarren, 1),
				new EnemyQuantity(EnemyType.SporeCrawler, 8),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Zergling, 24),
				new EnemyQuantity(EnemyType.Roach, 6),
			};
		}
	}
}
